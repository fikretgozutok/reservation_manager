using Entities.Abstract;

namespace Entities.Concrete
{
    public class Provider : User
    {
        public Address Address { get; set; } = default!;
    }
}