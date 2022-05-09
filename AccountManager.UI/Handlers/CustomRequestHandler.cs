using CefSharp;
using CefSharp.Handler;
using System;

namespace AccountManager.UI.Handlers
{
    public class CustomRequestHandler : RequestHandler
    {
        private readonly Action<string, IRequest, IResponse> _eventHandler;
        public CustomRequestHandler(Action<string, IRequest, IResponse> eventHandler)
        {
            _eventHandler = eventHandler;
        }

        protected override IResourceRequestHandler GetResourceRequestHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
        {
            return new CustomResourceRequestHandler(_eventHandler);
        }
    }
}
