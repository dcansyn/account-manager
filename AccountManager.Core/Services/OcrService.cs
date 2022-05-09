using AccountManager.Core.Consts;
using IronOcr;
using System.Drawing;
using System.Net;

namespace AccountManager.Core.Services
{
    public class OcrService
    {
        public string RecognitionFromUrl(string url, int languageRow = 0)
        {
            using (var wc = new WebClient())
            using (var s = wc.OpenRead(url))
            using (var bmp = new Bitmap(s))
            using (var input = new OcrInput(bmp))
            {
                var ocr = new IronTesseract() { Language = App.OcrLanguages[languageRow] };
                
                var result = ocr.Read(input);
                return result.Text.Replace(" ", "").Trim();
            }
        }

        public string RecognitionFromFile(string filePath, int languageRow = 0)
        {
            using (var input = new OcrInput(filePath))
            {
                var ocr = new IronTesseract() { Language = App.OcrLanguages[languageRow] };

                var result = ocr.Read(input);
                return result.Text.Replace(" ", "").Trim();
            }
        }
    }
}
