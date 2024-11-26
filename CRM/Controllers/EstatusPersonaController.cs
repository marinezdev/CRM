using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class EstatusPersonaController : Controller
    {
        [HttpPost]
        public JsonResult EstatusPersona_Listar(Application.CatEstatusPersona APcatEstatusPersona)
        {
            List<Models.CatEstatusPersona> LisEstatusPersona = APcatEstatusPersona.CatEstatusPersona_Seleccionar();
            return Json(LisEstatusPersona);
        }

        [HttpPost]
        public JsonResult EstatusPersona_Agregar(Models.CatEstatusPersona catEstatusPersona, Application.CatEstatusPersona APcatEstatusPersona)
        {
            Models.CatEstatusPersona DBEstatusPersona = APcatEstatusPersona.CatEstatusPersona_Agregar(catEstatusPersona);
            return Json(DBEstatusPersona);
        }
    }
}
