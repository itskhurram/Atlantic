using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using Atlantic.Domain.Core.Exceptions;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Atlantic.MasterData.Infrastructure.Middleware {
    public class ExceptionMiddleware {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IHostEnvironment _environment;
        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment environment) {
            _next = next;
            _logger = logger;
            _environment = environment;
        }
        public async Task InvokeAsync(HttpContext httpContext) {
            try {
                await _next(httpContext);
            }
            catch (Exception exception) {
                _logger.LogError(exception, exception.Message);
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                var respose = _environment.IsDevelopment()
                    ? new ExceptionInformation(httpContext.Response.StatusCode, exception.Message, exception.StackTrace?.ToString())
                    : new ExceptionInformation(httpContext.Response.StatusCode, "Internal Server Error");
                var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                var ExceptionJson = JsonSerializer.Serialize(respose, options);
                await httpContext.Response.WriteAsync(ExceptionJson);
            }
        }
    }
}
