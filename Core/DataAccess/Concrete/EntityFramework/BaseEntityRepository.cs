using Core.DataAccess.Abstract;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class BaseEntityRepository<Tentity, Tcontext> : IEntityRepository<Tentity>
        where Tentity : class, IEntity, new()
        where Tcontext : DbContext, new()
    {
        public void Add(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                var entityToAdd = context.Entry(entity);
                entityToAdd.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                var entityToDelete = context.Entry(entity);
                entityToDelete.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Tentity? Get(Func<Tentity, bool> filter)
        {
            using (var context = new Tcontext())
            {
                return context.Set<Tentity>().FirstOrDefault(filter);
            }
        }

        public IEnumerable<Tentity> GetAll(Func<Tentity, bool>? filter = null)
        {
            using (var context = new Tcontext())
            {
                return filter == null ?
                    context.Set<Tentity>().ToList() :
                    context.Set<Tentity>().Where(filter).ToList();
            }
        }

        public void Update(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                var entityToUpdate = context.Entry(entity);
                entityToUpdate.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
