using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public bool Local { get; set; }

        [MaxLength(70)]
        public string FullName { get; set; }

        [MaxLength(11)]
        public string IdentityNumber { get; set; }

        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Gender { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
