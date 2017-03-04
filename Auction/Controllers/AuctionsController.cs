using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auction.Controllers
{
    public class AuctionsController : Controller
    {
        //
        // GET: /Auctions/

        public ActionResult Index()
        {
            return View();
            
        }

        public ActionResult TempDataDemo()
        {
            TempData["SuccessMessage"] = "The action succedded";
            return RedirectToAction("Index");
        }

        public ActionResult Auction()
        {
            var auction = new Auction.Models.Auction()
            {
                Title = "Example Auction",
                Description = "This is an example Auction",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00m,
                CurrentPrice = null
            };
            
            return View(auction);
        }

        public ActionResult Amar()
        {
            return View();
        }

    }
}
