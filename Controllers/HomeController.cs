using GoldenPersonelYonetimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoldenPersonelYonetimi.Controllers
{
    public class HomeController : Controller
    {
        //PersonelListesi_Result db = new PersonelListesi_Result();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [Route("KProfil")]
        public ActionResult UserProfile(int Id)
        {
            userManagementEntities db = new userManagementEntities();
            var res = db.kullCek(Id).FirstOrDefault();
            return View(res);
        }

        [Route("Liste")]
        public ActionResult TableList()
        {
            userManagementEntities db = new userManagementEntities();
            var res = db.PersonelListesi(1).ToList();
            return View(res);
        }
    }
}