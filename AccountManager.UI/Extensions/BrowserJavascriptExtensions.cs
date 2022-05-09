using CefSharp;
using CefSharp.WinForms;
using System;
using System.Threading.Tasks;

namespace AccountManager.UI.Extensions
{
    public static class BrowserJavascriptExtensions
    {
        private static string GetJavascriptCode(string code, int miliseconds = 0, bool interval = false)
        {
            var result = $"(function() {{";

            if (miliseconds > 0)
                result += $"{(interval ? "setInterval" : "setTimeout")}(function(){{ {code} }}, {miliseconds})";
            else
                result += code;

            result += $"}})()";

            return result;
        }

        public static void Redirect(this ChromiumWebBrowser browser, string url, int miliseconds = 0, bool interval = false)
        {
            browser.ExecuteScriptAsync(GetJavascriptCode($"window.location='{url}';", miliseconds, interval));
        }

        public static void CallFunction(this ChromiumWebBrowser browser, string function, int miliseconds = 0, bool interval = false)
        {
            browser.ExecuteScriptAsync(GetJavascriptCode(function, miliseconds, interval));
        }

        public static void ClickElement(this ChromiumWebBrowser browser, string selector, int miliseconds = 0, bool interval = false)
        {
            browser.ExecuteScriptAsync(GetJavascriptCode($"document.querySelector(\"{selector}\").click();", miliseconds, interval));
        }

        public static void SubmitElement(this ChromiumWebBrowser browser, string selector, int miliseconds = 0, bool interval = false)
        {
            browser.ExecuteScriptAsync(GetJavascriptCode($"document.querySelector(\"{selector}\").submit();", miliseconds, interval));
        }

        public static void SetElementValue(this ChromiumWebBrowser browser, string selector, string value, int miliseconds = 0, bool interval = false)
        {
            browser.ExecuteScriptAsync(GetJavascriptCode($"document.querySelector(\"{selector}\").value=\"{value}\";", miliseconds, interval));
        }

        public static void SetElementChecked(this ChromiumWebBrowser browser, string selector, bool value, int miliseconds = 0, bool interval = false)
        {
            browser.ExecuteScriptAsync(GetJavascriptCode($"document.querySelector(\"{selector}\").checked=\"{Convert.ToInt32(value)}\";", miliseconds, interval));
        }

        public static Task<JavascriptResponse> GetElementValue(this ChromiumWebBrowser browser, string selector)
        {
            return browser.EvaluateScriptAsync($"document.querySelector(\"{selector}\").value;");
        }

        public static Task<JavascriptResponse> GetElementText(this ChromiumWebBrowser browser, string selector)
        {
            return browser.EvaluateScriptAsync($"document.querySelector(\"{selector}\").textContent;");
        }

        public static Task<JavascriptResponse> GetElementAttribute(this ChromiumWebBrowser browser, string selector, string attributeName)
        {
            return browser.EvaluateScriptAsync($"document.querySelector(\"{selector}\").getAttribute(\"{attributeName}\");");
        }
    }
}
