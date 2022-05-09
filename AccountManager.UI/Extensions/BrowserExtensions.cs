using CefSharp;
using CefSharp.WinForms;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManager.UI.Extensions
{
    public static class BrowserExtensions
    {
        public static void ChangeAcceptLanguage(this ChromiumWebBrowser browser, string language = "ja")
        {
            browser.GetBrowser()
                .GetHost()
                .RequestContext
                .SetPreference("intl.accept_languages", language, out string error);
        }
    }
}
