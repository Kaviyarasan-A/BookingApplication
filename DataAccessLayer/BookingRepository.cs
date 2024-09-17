using DataAccessLayer.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookingRepository : IBookingRepository
    {
        BookingDbcontext Dbcontext = null;
        public BookingRepository(BookingDbcontext context)
        {
            Dbcontext = context;
        }
        public void InsertUser(BookingTicket loc)
        {
            try
            {
                Dbcontext.Add(loc);
                Dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public BookingTicket GetUserByName(string busname)
        {
            try
            {
                return Dbcontext.BookingTickets.FirstOrDefault(X => X.Busname == busname);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public List<BookingTicket> GetAllUser()
        {
            try
            {
                return Dbcontext.BookingTickets.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void UpdateUser(BookingTicket loc)
        {
            try
            {
                Dbcontext.Update(loc);
                Dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void DeleteUser(long TicketId)
        {
            try
            {
                var count = Dbcontext.BookingTickets.Find(TicketId);
                Dbcontext.Remove(count);
                Dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
