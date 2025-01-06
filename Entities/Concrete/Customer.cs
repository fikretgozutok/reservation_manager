using Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer : User
    {
        public int CustomerId { get; set; }
        public IEnumerable<Address> Addresses { get; set; } = default!;
    }
}