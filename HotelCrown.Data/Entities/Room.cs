using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Data.Entities
{
    public class Room
    {
        public int Id { get; set; }

        [MaxLength(70)]
        public string RoomName { get; set; }

        public int Capacity { get; set; } = 1;

        public decimal Price { get; set; }

        public virtual ICollection<Feature> Features { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

    }
}
