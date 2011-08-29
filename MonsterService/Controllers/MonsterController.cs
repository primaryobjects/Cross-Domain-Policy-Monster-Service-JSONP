using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonsterService.Models;
using MonsterService.Managers;
using MonsterService.Filters;

namespace MonsterService.Controllers
{
    public class MonsterController : Controller
    {
        [JsonpFilter]
        public ActionResult Index()
        {
            if (Request.Params["callback"] != null)
            {
                Monster monster = MonsterManager.CreateRandom();

                return Json(monster, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return View();
            }
        }
    }
}
