using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookTicket.Controllers
{
    public class MoviesTicketController : Controller
    {
        // GET: MoviesTicket
        public ActionResult Movie()
        {
            return View();
        }
    }
}