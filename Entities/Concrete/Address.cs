using Core.Entities;

namespace Entities.Concrete
{
    public class Address : BaseEntity
    {
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Detail { get; set; } = string.Empty;
        public ICollection<Customer> Customers { get; set; } = default!;
        public ICollection<Provider> Providers { get; set; } = default!;
    }
}
