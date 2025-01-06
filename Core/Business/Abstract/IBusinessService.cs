using Core.Entities;
using Core.Utilities.Response.Abstract;

namespace Core.Business.Abstract
{
    public interface IBusinessService<T> where T : class, IEntity, new()
    {
        BaseResponse Add(T entity);
        BaseResponse Delete(T entity);
        BaseResponse Update(T entity);
        BaseDataResponse<IEnumerable<T>> GetAll();
        BaseDataResponse<T> GetById(int id);
    }
}
