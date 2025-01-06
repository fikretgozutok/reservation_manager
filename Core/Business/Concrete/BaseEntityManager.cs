using Core.Business.Abstract;
using Core.DataAccess.Abstract;
using Core.Entities;
using Core.Utilities.Response.Abstract;
using Core.Utilities.Response.Concrete;

namespace Core.Business.Concrete
{
    public abstract class BaseEntityManager<Tentity> : IBusinessService<Tentity> where Tentity : class, IEntity, new()
    {
        private readonly IEntityRepository<Tentity> _repository;

        protected BaseEntityManager(IEntityRepository<Tentity> repository) => _repository = repository;

        public BaseResponse Add(Tentity entity)
        {
            //refactor global exception handler aop
            try
            {
                _repository.Add(entity);

                return new SuccessResponse();
            }
            catch (Exception e)
            {
                return new ErrorResponse(e.Message);
            }
        }

        public BaseResponse Delete(Tentity entity)
        {
            try
            {
                _repository.Delete(entity);

                return new SuccessResponse();
            }
            catch (Exception e)
            {
                return new ErrorResponse(e.Message);
            }
        }

        public BaseDataResponse<IEnumerable<Tentity>> GetAll()
        {
            try
            {
                IEnumerable<Tentity> response = _repository.GetAll();

                return new SuccessDataResponse<IEnumerable<Tentity>>(response);
            }
            catch (Exception e)
            {
                return new ErrorDataResponse<IEnumerable<Tentity>>(message: e.Message);
            }
        }

        public BaseDataResponse<Tentity> GetById(int id)
        {
            try
            {
                Tentity response = _repository.Get((entity) => entity.Id == id);

                return new SuccessDataResponse<Tentity>(response);
            }
            catch (Exception e)
            {
                return new ErrorDataResponse<Tentity>(message: e.Message);
            }
        }

        public BaseResponse Update(Tentity entity)
        {
            try
            {
                _repository.Update(entity);

                return new SuccessResponse();
            }
            catch (Exception e)
            {
                return new ErrorResponse(e.Message);
            }
        }
    }
}
