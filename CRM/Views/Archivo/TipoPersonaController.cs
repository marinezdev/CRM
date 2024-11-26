using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class TipoPersonaController : Controller
    {

        [HttpPost]
        public JsonResult TipoPersona_Listar(Application.CatTipoPersona APcatTipoPersona)
        {
            List<Models.CatTipoPersona> LisTipoPersona = APcatTipoPersona.CatTipoPersona_Seleccionar();
            return Json(LisTipoPersona);
        }

        [HttpPost]
        public JsonResult TipoPersona_Agregar(Models.CatTipoPersona catTipoPersona, Application.CatTipoPersona APcatTipoPersona)
        {
            Models.CatTipoPersona DBTipoPersona = APcatTipoPersona.CatTipoPersona_Agregar(catTipoPersona);
            return Json(DBTipoPersona);
        }
    }
}
