using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class IndustriaController : Controller
    {
        [HttpPost]
        public JsonResult Industria_Listar(Application.CatIndustria APcatIndustria)
        {
            List<Models.CatIndustria> LisIndustria = APcatIndustria.CatIndustria_Seleccionar();
            return Json(LisIndustria);
        }

        [HttpPost]
        public JsonResult Industria_Agregar(Models.CatIndustria catIndustria, Application.CatIndustria APcatIndustria)
        {
            Models.CatIndustria DBIndustrias = APcatIndustria.CatIndustria_Agregar(catIndustria);
            return Json(DBIndustrias);
        }
    }
}
