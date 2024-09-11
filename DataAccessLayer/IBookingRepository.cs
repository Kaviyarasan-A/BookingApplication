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
        public List<BookingTicket> SelectALLUser();

        public BookingTicket SelectUserByUsername(string Busname);
        public void Registeruser(BookingTicket userRegData);
        public void UpdateUser(BookingTicket reg);
        public void DeleteUser(long TicketId);
        
    }
}
