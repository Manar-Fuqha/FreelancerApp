
using FreelancerApp.Application.Exceptions;
using Newtonsoft.Json;
using System.Net;

namespace FreelancerApp.Api.Middlewares
{
    public class GlobalExceptionHandler
    {
        private readonly RequestDelegate next;

        public GlobalExceptionHandler(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context )
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);

            }
        }

        private async Task HandleExceptionAsync(HttpContext context, object ex)
        {
            HttpStatusCode statusCode;
            string message;

            switch (ex)
            {
                case NotFoundException _:
                    statusCode = HttpStatusCode.NotFound;
                    message = "Not Found";
                    break;
                case KeyNotFoundException _:
                    statusCode = HttpStatusCode.NotFound;
                    message = "Not Found";
                    break;

                default:
                    statusCode = HttpStatusCode.InternalServerError;
                    message = ex.ToString();
                    break;

            }


            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;

            var result = JsonConvert.SerializeObject(new { message });
            await context.Response.WriteAsync(result);
        }
    }
}
