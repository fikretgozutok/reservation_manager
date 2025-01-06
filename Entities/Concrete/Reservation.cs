using Core.Entities;
using Entities.Constants;

namespace Entities.Concrete
{
    public class Reservation : BaseEntity
    {
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public ReservationStatus Status { get; set; }
        public Service Service { get; set; } = default!;
    }
}