using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace PlatformService.Middleware
{
    public class CustomHeaders
    {
        private readonly RequestDelegate _next;

        public CustomHeaders(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.Headers.Add("hostname", Environment.MachineName);

            return _next(httpContext);
        }
    }
}
