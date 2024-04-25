
namespace API_Project.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }

        public ApiResponse(int StatusCode, string? Message = null)
        {
            this.StatusCode = StatusCode;
            this.Message = Message ?? GetDefaultMessageForStatusCode(StatusCode);
        }

        private string? GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Bad Request",
                401 => "You are not authorized",
                404 => "Request Not Found",
                500 => "Internal Server Error",
                _ => null,
            };
        }
    }
}
