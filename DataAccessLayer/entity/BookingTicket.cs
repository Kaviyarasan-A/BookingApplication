using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.entity

{
     public class BookingTicket
    {
        [Key]
        public long TicketID { get; set; }
        public string Busname { get; set; }
        public string Startingpoint { get; set; }
        public string Droppingpoint { get; set; }
        public long Amount { get; set; }
        public long NoOfpeople { get; set; }
        public DateTime JourneyDate { get; set; }
        public long ContactNo { get; set; }
    }
}
