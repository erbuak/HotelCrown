using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Data.Entities
{
    public class Service
    {
        public int Id { get; set; }

        [MaxLength(70)]
        public string ServiceName { get; set; }

        public decimal UnitPrice { get; set; }

        public virtual ICollection<ReservationService> ReservationServices { get; set; }
    }
}
