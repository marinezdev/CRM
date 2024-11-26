using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class TipoOportunidadController : Controller
    {
        [HttpPost]
        public JsonResult TipoOportunidad_Listar(Application.CatTipoOportunidad APcatTipoOportunidad)
        {
            List<Models.CatTipoOportunidad> LisTipoPersona = APcatTipoOportunidad.CatTipoOportunidad_Seleccionar();
            return Json(LisTipoPersona);
        }

        [HttpPost]
        public JsonResult TipoOportunidad_Agregar(Models.CatTipoOportunidad catTipoOportunidad, Application.CatTipoOportunidad APcatTipoOportunidad)
        {
            Models.CatTipoOportunidad DBTipoOportunidad = APcatTipoOportunidad.CatTipoOportunidad_Agregar(catTipoOportunidad);
            return Json(DBTipoOportunidad);
        }
    }
}
