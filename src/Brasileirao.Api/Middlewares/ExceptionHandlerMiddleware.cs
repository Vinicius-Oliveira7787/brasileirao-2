using Brasileirao.Api.Client.Exceptions;
using Brasileirao.Api.Client.Responses;
using Microsoft.AspNetCore.Http;
using System;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Brasileirao.Api.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (BusinessException exception)
            {
                await HandleExceptionAsync(context, exception, statusCode: 400);
            }
            catch (NotFoundException exception)
            {
                await HandleExceptionAsync(context, exception, statusCode: 404);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception, statusCode: 500);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex, int statusCode)
        {
            context.Response.ContentType = MediaTypeNames.Application.Json;
            string result = new ExceptionResponse() { Message = ex.Message }.ToString();
            context.Response.StatusCode = statusCode;
            return context.Response.WriteAsync(result);
        }
    }
}
