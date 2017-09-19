using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace ArchitectureMonuments.Controllers
{

   

    public class MonumentController : Controller
    {
        // GET: Monument
        private Models.MonumentDBEntities db= new Models.MonumentDBEntities();
        public ActionResult Index()
        {
            var all_items = db.Monuments.ToList<ArchitectureMonuments.Models.Monument>();
            var aall_items = all_items.OrderByDescending(x => x.likes).ToList<ArchitectureMonuments.Models.Monument>();
            List<ArchitectureMonuments.Models.Monument> items = new List<Models.Monument>();
            for (int i = 0; i < 3; i++)
            {
                items.Add(aall_items[i]);
            }
            return View(items);
        }

        public ActionResult MonumentView()
        {
            var items = db.Monuments;
            return View(items);
        }

        public ActionResult Details(int id)
        {
            var item = db.Monuments;
            var items = item.ToList<ArchitectureMonuments.Models.Monument>();
            ArchitectureMonuments.Models.Monument c = items.FirstOrDefault(com => com.Id == id);
            if (c != null)
                return PartialView(c);
            return HttpNotFound();
        }



       




    }
}