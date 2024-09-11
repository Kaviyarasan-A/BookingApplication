using DataAccessLayer;
using DataAccessLayer.entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApplication.Controllers
{
    public class BookingController : Controller
    {
        IBookingRepository reg= null;

        public BookingController(IBookingRepository regs)
        {
            reg = regs;
        }
        // GET: BookingController
        public ActionResult List()
        {
            var result = reg.SelectALLUser();
            return View("list",result);
        }

        // GET: BookingController/Details/5
        public ActionResult Details(string Busname)
        {
            var details = reg.SelectUserByUsername(Busname);
            return View("Details",details);
        }

        // GET: BookingController/Create
        public ActionResult Create()
        {
            
            return View("Create",new BookingTicket());
        }

        // POST: BookingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookingTicket regs)
        {
            try
            {
                reg.Registeruser(regs);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingController/Edit/5
        public ActionResult Edit(string Busname)
        {
            var edit = reg.SelectUserByUsername(Busname);
            return View("Edit",edit);
        }

        // POST: BookingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BookingTicket regs)
        {
            try
            {
                reg.UpdateUser(regs);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingController/Delete/5
        public ActionResult Delete( )
        {
           
           
            return View();
        }

        // POST: BookingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long TicketId)
        {
            try
            {
                reg.DeleteUser(TicketId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
