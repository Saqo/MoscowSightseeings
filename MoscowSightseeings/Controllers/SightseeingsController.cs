using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoscowSightseeings.Models;

namespace MoscowSightseeings.Controllers
{
    public class SightseeingsController : Controller
    {
        //
        // GET: /Sightseeings/

        public ActionResult Index()
        {


            DataManager db = new DataManager();

            ViewData.Model = db.GetItems();
            return View();
        }

        public ActionResult Place(Guid ID, string content)
        {
            DataManager db = new DataManager();
            Places place = db.GetItemByID(ID);
            return View(place);
        }
    }
}
