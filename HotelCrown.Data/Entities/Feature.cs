using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Data.Entities
{
    public class Feature
    {
        public int Id { get; set; }

        [MaxLength(70)]
        public string FeatureName { get; set; }

        public bool IsStandard { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
