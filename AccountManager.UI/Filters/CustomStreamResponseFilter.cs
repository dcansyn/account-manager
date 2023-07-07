using CefSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.UI.Filters
{
    public class CustomStreamResponseFilter : IResponseFilter, IDisposable
    {
        private Stream responseStream;
        public CustomStreamResponseFilter(Stream stream)
        {
            responseStream = stream;
        }

        bool IResponseFilter.InitFilter()
        {
            if (responseStream != null)
            {
                return responseStream.CanWrite;
            }

            return false;
        }

        FilterStatus IResponseFilter.Filter(Stream dataIn, out long dataInRead, Stream dataOut, out long dataOutWritten)
        {
            if (dataIn == null || !responseStream.CanWrite)
            {
                dataInRead = 0L;
                dataOutWritten = 0L;
                return FilterStatus.Done;
            }

            dataInRead = Math.Min(dataIn.Length, dataOut.Length);
            dataOutWritten = dataInRead;
            byte[] array = new byte[dataInRead];
            dataIn.Read(array, 0, array.Length);
            dataOut.Write(array, 0, array.Length);
            responseStream.Write(array, 0, array.Length);
            if (dataInRead < dataIn.Length)
            {
                return FilterStatus.NeedMoreData;
            }

            return FilterStatus.Done;
        }

        void IDisposable.Dispose()
        {
            responseStream = null;
        }
    }
}
