using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class FuenteOrigenController : Controller
    {
        [HttpPost]
        public JsonResult FuenteOrigen_Listar(Application.CatFuenteOrigen APcatFuenteOrigen)
        {
            List<Models.CatFuenteOrigen> LisFuenteOrigen = APcatFuenteOrigen.CatFuenteOrigen_Seleccionar();
            return Json(LisFuenteOrigen);
        }

        [HttpPost]
        public JsonResult FuenteOrigen_Agregar(Models.CatFuenteOrigen catFuenteOrigen, Application.CatFuenteOrigen APcatFuenteOrigen)
        {
            Models.CatFuenteOrigen FuenteOrigen = APcatFuenteOrigen.CatFuenteOrigen_Agregar(catFuenteOrigen);
            return Json(FuenteOrigen);
        }
    }
}
