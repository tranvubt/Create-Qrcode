using OfficeOpenXml;
using SkiaSharp;
using Svg.Skia;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;

namespace Create_Qrcode
{
    public partial class Form1 : Form
    {
        private List<QrCode> qrCodes = new List<QrCode>();
        private string rootFolderPath = "";
        private bool isGeneratingImages = false;
        private string textEdit = "";
        private string pngPath = "";

        public Form1()
        {

            InitializeComponent();

            string savedFolderPath = Properties.Settings.Default.FolderPath;
            string savedExcelPath = Properties.Settings.Default.ExcelPath;
            string savedPngPath = Properties.Settings.Default.PngPath;

            // Kiểm tra xem đường dẫn đã được lưu trữ hay chưa
            try
            {
                if (!string.IsNullOrEmpty(savedFolderPath))
                {
                    richTextFolder.Text = "Có " + Directory.GetDirectories(savedFolderPath).Length + " sản phẩm";
                    rootFolderPath = savedFolderPath;
                }

                if (!string.IsNullOrEmpty(savedExcelPath))
                {
                    addDataWithExcel(savedExcelPath);
                    richTextData.Text = "Có " + qrCodes.Count + " dữ liệu";
                }

                if (!string.IsNullOrEmpty(savedPngPath))
                {
                    richTextBox1.Text = savedPngPath;
                }
            }
            catch (Exception)
            {
            }

            button3.Click += button3_Click;
            ImageGenerationWorker.DoWork += ImageGenerationWorker_DoWork;
            ImageGenerationWorker.RunWorkerCompleted += ImageGenerationWorker_RunWorkerCompleted;
            ImageGenerationWorker.ProgressChanged += ImageGenerationWorker_ProgressChanged;
            ImageGenerationWorker.WorkerReportsProgress = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string excelFilePath = openFileDialog1.FileName;
                try
                {
                    addDataWithExcel(excelFilePath);
                    Properties.Settings.Default.ExcelPath = excelFilePath;
                    Properties.Settings.Default.Save();
                    richTextData.Text = "Có " + qrCodes.Count + " dữ liệu";
                }
                catch (IOException)
                {
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    rootFolderPath = fbd.SelectedPath;
                    Properties.Settings.Default.FolderPath = rootFolderPath;
                    Properties.Settings.Default.Save();
                    richTextFolder.Text = Path.GetFileName(rootFolderPath) +" Có " + Directory.GetDirectories(rootFolderPath).Length + " sản phẩm";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            if (!isGeneratingImages && !ImageGenerationWorker.IsBusy)
            {
                isGeneratingImages = true;
                ImageGenerationWorker.RunWorkerAsync();
            }
            else
            {
                status.Text = "Đợi tí";
            }
        }

        private void ImageGenerationWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int totalQrCodes = qrCodes.Count;
            int currentQrCode = 0;

            foreach (var qrCode in qrCodes)
            {
                string folderPath = Path.Combine(rootFolderPath, qrCode.IdLink);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string outputFilePath = Path.Combine(folderPath, "WTM Qrcode.jpg");
                qrCode.CreateQrCode(outputFilePath, pngPath, textEdit);

                currentQrCode++;

                // Cập nhật giá trị ProgressBar
                int progressPercentage = (int)((double)currentQrCode / totalQrCodes * 100);
                ImageGenerationWorker.ReportProgress(progressPercentage);
            }
        }

        private void ImageGenerationWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            status.Text = "Đang tạo Qrcode";
            progressBar1.Value = e.ProgressPercentage;
        }

        private void ImageGenerationWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            // Cập nhật giá trị của ProgressBar thành giá trị tối đa
            progressBar1.Value = progressBar1.Maximum;

            isGeneratingImages = false;

            // Hiển thị thông báo hoàn thành cho người dùng
            status.Text = "Hoàn thành";
        }

        private void richTextEditText_TextChanged(object sender, EventArgs e)
        {
            textEdit = richTextEditText.Text;
        }

        private void addDataWithExcel(string excelFilePath)
        {
            using (var package = new ExcelPackage(new FileInfo(excelFilePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1]; // Chọn worksheet đầu tiên

                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++) // Bắt đầu từ dòng thứ 2 (bỏ qua tiêu đề)
                {
                    string idLink = worksheet.Cells[row, 1].Value?.ToString();
                    string svgCode = worksheet.Cells[row, 2].Value?.ToString();

                    if (!string.IsNullOrEmpty(idLink) && !string.IsNullOrEmpty(svgCode))
                    {
                        // Thay thế width và height
                        svgCode = Regex.Replace(svgCode, @"width=""\d+""", "width=\"500\"");
                        svgCode = Regex.Replace(svgCode, @"height=""\d+""", "height=\"500\"");

                        // Thay thế scale và translate
                        if (svgCode.Length >= 4000)
                            svgCode = Regex.Replace(svgCode, @"scale\(\d+(\.\d+)?\)", "scale(2.7)");
                        else
                        {
                            svgCode = Regex.Replace(svgCode, @"scale\(\d+(\.\d+)?\)", "scale(3)");
                        }
                        svgCode = Regex.Replace(svgCode, @"translate\(\d+(\.\d+)?,\d+(\.\d+)?\)", "translate(5.5,4)");

                        QrCode qrCode = new QrCode
                        {
                            IdLink = idLink,
                            SvgCode = svgCode
                        };

                        qrCodes.Add(qrCode);
                    }
                }
            }
        }

        private void richTextEditText_Click(object sender, EventArgs e)
        {
            richTextEditText.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                pngPath = openFileDialog1.FileName;
                try
                {
                    Properties.Settings.Default.PngPath = pngPath;
                    Properties.Settings.Default.Save();
                    richTextBox1.Text = pngPath;
                }
                catch (IOException)
                {
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            pngPath = richTextBox1.Text;
        }

    }
}