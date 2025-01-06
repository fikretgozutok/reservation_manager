using Core.Entities;
using Entities.Constants;

namespace Entities.Concrete
{
    public class Service : BaseEntity
    {
        public int ProviderId { get; set; }
        public int LocationId { get; set; }
        public string ServiceTitle { get; set; } = string.Empty;
        public string ServiceDescription { get; set; } = string.Empty;
        public ServiceTypes ServiceTypes { get; set; }
        public Provider Provider { get; set; } = default!;
        public Address Location { get; set; } = default!;

    }
}