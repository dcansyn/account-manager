using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.UI.Handlers
{
    public class CustomJsDialogHandler : IJsDialogHandler
    {
        public void OnDialogClosed(IWebBrowser chromiumWebBrowser, IBrowser browser) { }
        public void OnResetDialogState(IWebBrowser chromiumWebBrowser, IBrowser browser) { }
        public bool OnBeforeUnloadDialog(IWebBrowser chromiumWebBrowser, IBrowser browser, string messageText, bool isReload, IJsDialogCallback callback) => true;
        public bool OnJSDialog(IWebBrowser chromiumWebBrowser, IBrowser browser, string originUrl, CefJsDialogType dialogType, string messageText, string defaultPromptText, IJsDialogCallback callback, ref bool suppressMessage)
        {
            callback.Continue(true);
            return true;
        }
    }
}
