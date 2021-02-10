using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ALLMVC.MiddleWare
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomWare
    {
        private readonly RequestDelegate _next;

        public CustomWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            //if (httpContext.Request.Path.Equals("/Home/Idiot"))
            //{
            //    httpContext.Response.Redirect("https://www.tollplus.com");
            //}

            httpContext.Response.Redirect("https://www.tollplus.com");
            await _next(httpContext);
            
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CustomWareExtensions
    {
        public static IApplicationBuilder UseCustomWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomWare>();
        }
    }
}
