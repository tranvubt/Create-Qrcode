namespace Create_Qrcode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            richTextFolder = new RichTextBox();
            label2 = new Label();
            richTextData = new RichTextBox();
            button1 = new Button();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            richTextEditText = new RichTextBox();
            label5 = new Label();
            button3 = new Button();
            status = new Label();
            label4 = new Label();
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            button4 = new Button();
            progressBar1 = new ProgressBar();
            ImageGenerationWorker = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(progressBar1, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40.70352F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 59.2964821F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(359, 218);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.712328F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.287674F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 93F));
            tableLayoutPanel1.Controls.Add(button2, 2, 1);
            tableLayoutPanel1.Controls.Add(richTextFolder, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(richTextData, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(353, 75);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(262, 39);
            button2.Name = "button2";
            button2.Size = new Size(88, 33);
            button2.TabIndex = 5;
            button2.Text = "Chọn folder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextFolder
            // 
            richTextFolder.Dock = DockStyle.Fill;
            richTextFolder.Location = new Point(72, 39);
            richTextFolder.Multiline = false;
            richTextFolder.Name = "richTextFolder";
            richTextFolder.ReadOnly = true;
            richTextFolder.ScrollBars = RichTextBoxScrollBars.None;
            richTextFolder.Size = new Size(184, 33);
            richTextFolder.TabIndex = 4;
            richTextFolder.Text = "Chọn folder cần tạo Qrcode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 36);
            label2.TabIndex = 0;
            label2.Text = "Excel Data";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextData
            // 
            richTextData.Dock = DockStyle.Fill;
            richTextData.Location = new Point(72, 3);
            richTextData.Multiline = false;
            richTextData.Name = "richTextData";
            richTextData.ReadOnly = true;
            richTextData.RightToLeft = RightToLeft.No;
            richTextData.Size = new Size(184, 30);
            richTextData.TabIndex = 1;
            richTextData.Text = "Chọn file data";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(262, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 30);
            button1.TabIndex = 2;
            button1.Text = "File data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 36);
            label3.Name = "label3";
            label3.Size = new Size(63, 39);
            label3.TabIndex = 3;
            label3.Text = "Folder";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.44476F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.5552444F));
            tableLayoutPanel3.Controls.Add(richTextEditText, 1, 1);
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(button3, 1, 2);
            tableLayoutPanel3.Controls.Add(status, 0, 2);
            tableLayoutPanel3.Controls.Add(label4, 0, 1);
            tableLayoutPanel3.Controls.Add(panel1, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 84);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel3.Size = new Size(353, 112);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // richTextEditText
            // 
            richTextEditText.Dock = DockStyle.Fill;
            richTextEditText.Location = new Point(114, 40);
            richTextEditText.Multiline = false;
            richTextEditText.Name = "richTextEditText";
            richTextEditText.ScrollBars = RichTextBoxScrollBars.None;
            richTextEditText.Size = new Size(236, 28);
            richTextEditText.TabIndex = 3;
            richTextEditText.Text = "Mặc định chữ là \"SCAN ME\"";
            richTextEditText.Click += richTextEditText_Click;
            richTextEditText.TextChanged += richTextEditText_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 37);
            label5.TabIndex = 9;
            label5.Text = "Thêm ảnh Png";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(114, 74);
            button3.Name = "button3";
            button3.Size = new Size(236, 35);
            button3.TabIndex = 0;
            button3.Text = "TẠO QR CODE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Dock = DockStyle.Fill;
            status.Location = new Point(3, 71);
            status.Name = "status";
            status.Size = new Size(105, 41);
            status.TabIndex = 1;
            status.Text = "Sẵn sàng";
            status.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 37);
            label4.Name = "label4";
            label4.Size = new Size(105, 34);
            label4.TabIndex = 2;
            label4.Text = "Chữ dưới Qrcode";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(114, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 31);
            panel1.TabIndex = 8;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Multiline = false;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(148, 31);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Dock = DockStyle.Right;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(148, 0);
            button4.Name = "button4";
            button4.Size = new Size(88, 31);
            button4.TabIndex = 0;
            button4.Text = "Chọn ảnh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(3, 202);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(353, 13);
            progressBar1.TabIndex = 3;
            // 
            // ImageGenerationWorker
            // 
            ImageGenerationWorker.WorkerReportsProgress = true;
            ImageGenerationWorker.DoWork += ImageGenerationWorker_DoWork;
            ImageGenerationWorker.ProgressChanged += ImageGenerationWorker_ProgressChanged;
            ImageGenerationWorker.RunWorkerCompleted += ImageGenerationWorker_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 218);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tạo Qrcode";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private RichTextBox richTextFolder;
        private Label label2;
        private RichTextBox richTextData;
        private Button button1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button3;
        private Label status;
        private ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker ImageGenerationWorker;
        private Label label4;
        private RichTextBox richTextEditText;
        private RichTextBox richTextBox1;
        private Button button4;
        private Label label5;
        private Panel panel1;
    }
}