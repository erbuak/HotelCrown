using HotelCrown.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown.Data.DTOS
{
    public class ReservationDTO
    {
        public Reservation Reservation { get; set; }

        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public List<Customer> Customers { get; set; }

        public DateTime? CheckedInTime { get; set; }

        public DateTime? CheckedOutTime { get; set; }

        public Room Room { get; set; }

        public string CustomersString 
        { 
            get {
                string customersString = "";

                foreach (Customer customer in Customers)
                {
                    if (customer == Customers.Last())
                        customersString += customer.FullName;
                    else
                        customersString += customer.FullName + " - ";
                }

                return customersString;
            }
        }
            
        public string IsCheckedIn 
        { 
            get {
                if(CheckedInTime == null)
                {
                    return "Hayır";
                } 
                else
                {
                    return "Evet";
                }       
            } 
        }

        public string IsCheckedOut 
        { 
            get {
                if (CheckedOutTime == null)
                {
                    return "Hayır";
                }
                else
                {
                    return "Evet";
                }
            }
        }

        public string RoomName 
        { 
            get 
            {
                return Room.RoomName;  
            } 
        }
    }
}
