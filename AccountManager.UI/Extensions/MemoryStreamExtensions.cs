using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.UI.Extensions
{
    public static class MemoryStreamExtensions
    {
        public static string GetResponse(this MemoryStream memoryStream)
        {
            return Encoding.UTF8.GetString(memoryStream.ToArray(), 0, (int)memoryStream.Length);
        }
    }
}
