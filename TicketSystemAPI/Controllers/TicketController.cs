using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TicketSystemAPI.Models;

namespace TicketSystemAPI.Controllers
{
    public class TicketController : Controller
    {
        [HttpGet]
        public ActionResult <IEnumerable<TicketDto>> GetAll()
        {
            return View();
        }
    }
}
