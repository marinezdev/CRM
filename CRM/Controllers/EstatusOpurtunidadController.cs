using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class EstatusOpurtunidadController : Controller
    {
        [HttpPost]
        public JsonResult EstatusOpurtunidad_Listar(Application.CatEstatusOpurtunidad APcatEstatusOpurtunidad)
        {
            List<Models.CatEstatusOpurtunidad> LisEstatusOpurtunidad = APcatEstatusOpurtunidad.CatEstatusOpurtunidad_Seleccionar();
            return Json(LisEstatusOpurtunidad);
        }

        [HttpPost]
        public JsonResult EstatusOpurtunidad_Agregar(Models.CatEstatusOpurtunidad catEstatusOpurtunidad, Application.CatEstatusOpurtunidad APcatEstatusOpurtunidad)
        {
            Models.CatEstatusOpurtunidad DBEstatusOpurtunidad = APcatEstatusOpurtunidad.CatEstatusOpurtunidad_Agregar(catEstatusOpurtunidad);
            return Json(DBEstatusOpurtunidad);
        }
    }
}
