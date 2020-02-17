using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace project_banhang.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CheckLoginMiddleware
    {
        private readonly RequestDelegate _next;

        public CheckLoginMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            //lấy đường dẫn url
            var path = httpContext.Request.Path.ToString();
            //nếu path bắt đầu bằng /Admin thì kiểm tra xem session đã tồn tại hay chưa, nếu chưa thì chuyển sang trang login
            path = path.ToLower();
            if (path != null && path.StartsWith("/admin"))
            {
                if (httpContext.Session.GetString("email") == null)
                    //di chuyển đến trang login
                    httpContext.Response.Redirect("/login");
            }
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CheckLoginMiddlewareExtensions
    {
        public static IApplicationBuilder UseCheckLoginMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CheckLoginMiddleware>();
        }
    }
}
