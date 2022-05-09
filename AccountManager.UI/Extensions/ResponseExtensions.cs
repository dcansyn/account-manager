using CefSharp;
using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace AccountManager.UI.Extensions
{
    public static class ReponseExtensions
    {
        public static bool IsJson(this IResponse response) =>
            response.Headers["Content-Type"] != null &&
            response.Headers["Content-Type"]?.Contains("json") == true;
    }
}
