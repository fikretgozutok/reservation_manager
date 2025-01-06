using Core.Entities;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<Tentity> where Tentity : class, IEntity, new()
    {
        void Add(Tentity entity);
        void Delete(Tentity entity);
        void Update(Tentity entity);
        IEnumerable<Tentity> GetAll(Func<Tentity, bool>? filter = null);
        Tentity? Get(Func<Tentity, bool> filter);
    }
}
