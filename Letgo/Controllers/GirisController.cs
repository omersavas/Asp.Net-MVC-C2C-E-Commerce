using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Letgo.Controllers
{
    public class GirisController : Controller
    {
        private Models.veritabanım1Entities db = new Models.veritabanım1Entities();
        // GET: Giris
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult giris(string mail,int sifre)
        {
            try
            {
                var resultUser = db.tblkullanıcı.Where(x => x.email == mail && x.password == sifre).FirstOrDefault();
                if (resultUser != null)
                {
                    
                    return RedirectToAction("Anasayfa", "Anasayfa", new { area = "" });
                }
            }
            catch 
            {
                Console.WriteLine("Hata");
                
            }
           
            return RedirectToAction("Index/Giris");
        }
        [HttpPost]
        public ActionResult kayitOl(string name,string mail,int sifre)
        {
            try
            {
                Models.tblkullanıcı eklenecek = new Models.tblkullanıcı();
                eklenecek.email = mail;
                eklenecek.kullanıcıAdSoyad = name;
                eklenecek.password = sifre;
                db.tblkullanıcı.Add(eklenecek);
                db.SaveChanges();

                return RedirectToAction("Anasayfa", "Anasayfa", new { area = "" });
            }
            catch
            {
                Console.WriteLine("Hata");

            }
            
            return RedirectToAction("Index/Giris");


        }
    }
}