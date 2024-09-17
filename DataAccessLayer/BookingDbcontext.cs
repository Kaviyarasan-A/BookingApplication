using DataAccessLayer.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookingDbcontext:DbContext
    {
        public BookingDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<BookingTicket> BookingTickets { get; set; }
    }
}
