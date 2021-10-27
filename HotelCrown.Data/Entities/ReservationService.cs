using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Data.Entities
{
    public class ReservationService
    {
        public int Id { get; set; }

        public int ReservationId { get; set; }

        public Reservation Reservation { get; set; }

        public int ServiceId { get; set; }

        public Service Service { get; set; }

        public string ServiceName { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
