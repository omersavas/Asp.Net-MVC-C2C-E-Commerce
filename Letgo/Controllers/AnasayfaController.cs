using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Letgo.Controllers
{
    public class AnasayfaController : Controller
    {

        // GET: Anasayfa
        public ActionResult Anasayfa()
        {
            Models.veritabanım1Entities db = new Models.veritabanım1Entities();
            List<Models.tblurun> urunler = new List<Models.tblurun>();
            foreach (var item in db.tblurun)
            {
                urunler.Add(item);
            }

            
            return View(urunler);
        }
    }
}