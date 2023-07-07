using AccountManager.Core.Consts;
using AccountManager.Core.Models;
using AccountManager.Core.Services;
using AccountManager.UI.Extensions;
using AccountManager.UI.Filters;
using CefSharp;
using CefSharp.Handler;
using CefSharp.ResponseFilter;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.UI.Handlers
{
    public class CustomResourceRequestHandler : ResourceRequestHandler
    {
        private readonly Action<string, IRequest, IResponse> _eventHandler;
        public CustomResourceRequestHandler(Action<string, IRequest, IResponse> eventHandler)
        {
            _eventHandler = eventHandler;
        }

        private MemoryStream memoryStream;
        protected override IResponseFilter GetResourceResponseFilter(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response)
        {
            try
            {
                memoryStream = new MemoryStream();
                return new CustomStreamResponseFilter(memoryStream);
            }
            catch (Exception)
            {
                return null;
            }
        }

        protected override void OnResourceLoadComplete(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response, UrlRequestStatus status, long receivedContentLength)
        {
            try
            {
                if (memoryStream == null)
                    return;

                switch (request.ResourceType)
                {
                    case ResourceType.MainFrame:
                    case ResourceType.SubFrame:
                    case ResourceType.Xhr:
                        var res = memoryStream.GetResponse();

                        if (_eventHandler != null)
                            _eventHandler.Invoke(res, request, response);
                        break;
                    case ResourceType.Image:
                        if (_eventHandler != null)
                            _eventHandler.Invoke(request.Url, request, response);
                        break;
                }

            }
            catch (Exception) { }
        }

        protected override CefReturnValue OnBeforeResourceLoad(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IRequestCallback callback)
        {
            return CefReturnValue.Continue;
        }

        protected override void Dispose()
        {
            if (memoryStream != null)
            {
                memoryStream.Dispose();
                memoryStream = null;
            }
            GC.SuppressFinalize(this);
            base.Dispose();
        }
    }
}