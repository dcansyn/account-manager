using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AccountManager.Core.Helpers
{
    public class TaskHelper
    {
        public static Task<T> Timeout<T>(int miliseconds, Func<T> action)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(miliseconds);

                return action();
            });
        }

        public static Task Timeout(int miliseconds, Action action)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(miliseconds);
                
                action();
            });
        }
    }
}
