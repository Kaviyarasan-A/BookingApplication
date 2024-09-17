using DataAccessLayer.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
     public interface IBookingRepository
    {
        public void InsertUser(BookingTicket TicketID);
        public BookingTicket GetUserByName(string Busname);
        public List<BookingTicket> GetAllUser();
        public void UpdateUser(BookingTicket loc);
        public void DeleteUser(long TicketId);

    }
}
