using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Data.Entities
{
    public class Reservation
    {
        public int Id { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public DateTime? CheckedInTime { get; set; }

        public DateTime? CheckedOutTime { get; set; }

        public bool IsPaid { get; set; }

        public bool IsPaidServices { get; set; }

        public int RoomId { get; set; }

        public Room Room { get; set; }

        public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

        public virtual ICollection<ReservationService> ReservationServices { get; set; }
    }
}
