using AccountManager.Core.Consts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.Core.Helpers
{
    public class StorageHelper
    {
        public static void SaveClient()
        {
            var data = string.Join(Environment.NewLine, new[]
            {
                $"Email: {App.Account.Mail}",
                $"Email Password: {App.Account.MailPassword}",
                $"Game Id: {App.Account.GameId}",
                $"Game User Name: {App.Account.Username}",
                $"Game Password: {App.Account.Password}",
                $"Birth Date: {App.Account.BirthDate:dd.MM.yyyy}",
                $"Address: {App.Account.Address}",
                $"Secret Question: {App.Account.Question}",
                $"Secret Question Answer: {App.Account.Answer}"
            });

            Write(Path.Combine(Environment.CurrentDirectory, "Data", $"{App.Account.GameId}.txt"), data);
        }

        public static void Write(string path, string data)
        {
            var fileInfo = new FileInfo(path);

            if (!Directory.Exists(fileInfo.DirectoryName))
                Directory.CreateDirectory(fileInfo.DirectoryName);

            using (var st = new StreamWriter(path))
                st.Write(data);
        }

        public static string Read(string path)
        {
            if (!File.Exists(path))
                return null;

            return File.ReadAllText(path);
        }

        public static bool Exists(string path)
        {
            return File.Exists(path);
        }

        public static bool CheckFileCount(string path, int count)
        {
            if (!Directory.Exists(path))
                return false;

            return Directory.GetFiles(path).Length == count;
        }
    }
}
