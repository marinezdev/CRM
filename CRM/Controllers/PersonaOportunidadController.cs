using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class PersonaOportunidadController : Controller
    {
        [HttpPost]
        public JsonResult PersonaOportunidad_Listar(Application.CatPersonaOportunidad APcatPersonaOportunidad)
        {
            List<Models.CatPersonaOportunidad> LisPersonaOportunidad = APcatPersonaOportunidad.CatPersonaOportunidad_Seleccionar();
            return Json(LisPersonaOportunidad);
        }

        [HttpPost]
        public JsonResult PersonaOportunidad_Agregar(Models.CatPersonaOportunidad catPersonaOportunidad, Application.CatPersonaOportunidad APcatPersonaOportunidad)
        {
            Models.CatPersonaOportunidad DBPersonaOportunidad = APcatPersonaOportunidad.CatPersonaOportunidad_Agregar(catPersonaOportunidad);
            return Json(DBPersonaOportunidad);
        }
    }
}
