namespace api_demonstration_app.Models
{
    public class BaseResponse<T>
    {
        public bool Success { get; private set; }
        public string Error { get; private set; }

        public T Content { get; private set; }

        private BaseResponse(bool success = true, string error = null, T content = default)
        {
            Success = success;
            Error = error;
            Content = content;
        }


        public static BaseResponse<T> Succeed(T content) => new BaseResponse<T>(true, content: content);
        public static BaseResponse<T> Failed(string error) => new BaseResponse<T>(false, error);
    }
}
