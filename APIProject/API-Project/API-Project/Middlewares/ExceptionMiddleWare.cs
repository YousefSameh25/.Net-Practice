using API_Project.Errors;
using System.Net;
using System.Text.Json;

namespace API_Project.Middlewares
{
    public class ExceptionMiddleWare
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptionMiddleWare> logger;
        private readonly IHostEnvironment env;

        public ExceptionMiddleWare(RequestDelegate Next, ILogger<ExceptionMiddleWare> logger,
            IHostEnvironment env)
        {
            next = Next;
            this.logger = logger;
            this.env = env;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next.Invoke(context);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                //if (env.IsDevelopment())
                //{
                //    var Response = new ApiExceptionResponse(500, ex.Message, ex.StackTrace.ToString());
                //}
                //else
                //{
                //    var Response = new ApiExceptionResponse(500, ex.Message);
                //}
                var Response = new ApiExceptionResponse(500, ex.Message, env.IsDevelopment() ? ex.StackTrace.ToString() : null);
                var Options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                };
                var JsonResponse = JsonSerializer.Serialize(Response, Options);
                context.Response.WriteAsync(JsonResponse);
            }
        }
    }
}
