using Calculator.BusinessLogic.Exceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace Calculator.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await this.next(httpContext);
            }
            catch (ValidationException validationException)
            {
                // format the errors in the same way that the validator does for the response
                var errors = validationException.ValidationErrors;

                await HandleExceptionAsync(httpContext, HttpStatusCode.BadRequest, errors);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, HttpStatusCode httpStatusCode, object errorDetails)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)httpStatusCode;

            return context.Response.WriteAsync(JsonSerializer.Serialize(errorDetails));
        }
    }
}
