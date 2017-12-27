using SpaceBattleArena.Core;
using SpaceBattleArena.Core.MapEntityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ArenaController : Controller
    {
        // GET: Arena
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetMapInfo()
        {
            var map = Session[Constants.SessionKeys.MapKey] as Map;
            return Json(map);
        }

        public void UpdatePlayerState()
        {

        }
    }
}