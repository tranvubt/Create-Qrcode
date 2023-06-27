using SkiaSharp;
using Svg;
using Svg.Skia;
using System.Drawing;
using System.Text;

namespace Create_Qrcode
{
    internal class QrCode
    {
        public string IdLink { get; set; }
        public string SvgCode { get; set; }

        public void CreateQrCode(string outputFilePath, string pngPath = "", string textEdit = "") {
            try
            {
                using (var svg = new SKSvg())
                {
                    svg.Load(new MemoryStream(Encoding.UTF8.GetBytes(this.SvgCode)));

                    // Kích thước hình ảnh đầu ra (ở đây là 500x500 pixel)
                    var width = 500;
                    var height = 500;

                    using (var bitmap = new SKBitmap(width, height))
                    using (var canvas = new SKCanvas(bitmap))
                    {
                        // Vẽ mã SVG lên hình ảnh
                        canvas.DrawPicture(svg.Picture);

                        if (pngPath != "")
                        {
                            // Đọc ảnh PNG
                            using (var pngStream = File.OpenRead(pngPath))
                            {
                                var pngBitmap = SKBitmap.Decode(pngStream);

                                // Chèn ảnh PNG vào hình ảnh SVG
                                int x = (bitmap.Width - pngBitmap.Width) / 2;
                                int y = (bitmap.Height - pngBitmap.Height) / 2;
                                canvas.DrawBitmap(pngBitmap, x, y);
                            }
                        }
                        
                        // Vẽ dòng chữ "Scan me" dưới hình ảnh
                        using (var paint = new SKPaint())
                        using (var typeface = SKTypeface.FromFamilyName("Arial", SKFontStyle.Bold))
                        {
                            paint.Typeface = typeface;
                            paint.TextSize = 50;
                            paint.Color = SKColors.Black;

                            var text = "SCAN ME";
                            if (textEdit != "")
                            {
                                text = textEdit;
                            }
                            var textWidth = paint.MeasureText(text);
                            var textHeight = paint.FontMetrics.Ascent;

                            var textX = (width - textWidth) / 2;
                            var textY = height - 20; // Khoảng cách từ dưới lên

                            canvas.DrawText(text, textX, textY, paint);
                        }

                        using (var image = SKImage.FromBitmap(bitmap))
                        using (var data = image.Encode(SKEncodedImageFormat.Jpeg, 100))
                        using (var stream = File.OpenWrite(outputFilePath))
                        {
                            data.SaveTo(stream);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
