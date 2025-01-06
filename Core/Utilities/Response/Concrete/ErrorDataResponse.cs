using Core.Utilities.Response.Abstract;

namespace Core.Utilities.Response.Concrete
{
    public class ErrorDataResponse<T> : BaseDataResponse<T>
    {
        public ErrorDataResponse(T data = default!) : base(false, data) { }
        public ErrorDataResponse(T data = default!, string message) : base(false, data, message) { }
    }
}
