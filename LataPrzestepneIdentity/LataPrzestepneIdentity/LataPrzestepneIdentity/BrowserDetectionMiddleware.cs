using Microsoft.AspNetCore.Http;
using Shyjus.BrowserDetection;

namespace LataPrzestepneIdentity
{
    public class BrowserDetectionMiddleware
    {
        private RequestDelegate _next;

        public BrowserDetectionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext, IBrowserDetector browserDetector)
        {
            var browser = browserDetector.Browser;
 ;
            if (browser.Name == BrowserNames.Edge || browser.Name == BrowserNames.EdgeChromium || browser.Name == BrowserNames.InternetExplorer)
            {
                httpContext.Response.Redirect(" https://www.mozilla.org/pl/firefox/new");
            }

            return _next(httpContext);
        }
    }

    public static class BrowserDetectionMiddlewareExtensions
    {
        public static IApplicationBuilder UseBrowserDetectionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<BrowserDetectionMiddleware>();
        }
    }
}
