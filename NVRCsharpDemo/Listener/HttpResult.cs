namespace NVRCsharpDemo.Listener
{
    public class HttpResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public HttpResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}