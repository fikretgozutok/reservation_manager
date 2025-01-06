
namespace Core.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; }

        public DateTime CreatedTime => DateTime.Now;

        public DateTime UpdatedTime
        {
            get
            {
                return DateTime.Now;
            }

            set
            {
                UpdatedTime = value;
            }
        }
    }
}
