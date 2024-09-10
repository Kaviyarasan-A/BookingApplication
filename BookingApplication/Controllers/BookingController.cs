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
            var result = reg.SelectUserByUsername(Busname);
            return View();
        }

        // GET: BookingController/Create
        public ActionResult Create(BookingTicket value)
        {
            reg.Registeruser(value);
            return View();
        }

        // POST: BookingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
