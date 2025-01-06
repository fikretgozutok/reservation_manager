namespace Core.Utilities.Response.Abstract
{
    public abstract class BaseResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;

        protected BaseResponse(bool isSuccess) => IsSuccess = isSuccess;

        protected BaseResponse(bool isSuccess, string message) : this(isSuccess) => Message = message;
    }
}
