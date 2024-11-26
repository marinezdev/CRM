using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class UnidadNegocioController : Controller
    {
        [HttpPost]
        public JsonResult UnidadNegocio_Listar(Application.CatUnidadNegocio APcatUnidadNegocio)
        {
            List<Models.CatUnidadNegocio> LisUnidadNegocio   = APcatUnidadNegocio.CatUnidadNegocio_Seleccionar();
            return Json(LisUnidadNegocio);
        }
    
        [HttpPost]
        public JsonResult UnidadNegocio_Agregar(Models.CatUnidadNegocio catUnidadNegocio, Application.CatUnidadNegocio APcatUnidadNegocio)
        {
            Models.CatUnidadNegocio DBUnidadesNegocio = APcatUnidadNegocio.CatUnidadNegocio_Agregar(catUnidadNegocio);
            return Json(DBUnidadesNegocio);
        }
    }
}
