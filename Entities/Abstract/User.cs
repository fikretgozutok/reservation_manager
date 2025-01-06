using Core.Entities;

namespace Entities.Abstract
{
    public abstract class User : IEntity
    {
        public int Id { get; set; }

        public DateTime CreatedTime { get; }

        public DateTime UpdatedTime { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
