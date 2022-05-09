using AccountManager.Core.Domains;
using AccountManager.Core.Enums;
using IronOcr;
using System;

namespace AccountManager.Core.Consts
{
    public class App
    {
        public static Account Account = null;

        public static readonly OcrLanguage[] OcrLanguages = new OcrLanguage[]
        {
            OcrLanguage.JapaneseAlphabet,
            OcrLanguage.JapaneseAlphabetBest,
            OcrLanguage.JapaneseAlphabetFast,
            OcrLanguage.Japanese,
            OcrLanguage.JapaneseBest,
            OcrLanguage.JapaneseFast
        };

        public static bool BrowserIsReady = false;
        public static string MailboxUrl = "https://mail.tm/tr/";
        public static string GameEmailRegisterUrl = "http://www.mgame.jp/regist/step01.html?cp_regid=KNIGHT";
        public static string GameEmailRegisterCompleteUrl = "http://www.mgame.jp/regist/step02.html";
        public static string GameAccountRegisterCompleteUrl = "http://www.mgame.jp/regist/preview.html";
        public static string GameAccountCompleteUrl = "http://www.mgame.jp/regist/finish.html";
    }
}
