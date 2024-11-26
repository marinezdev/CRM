using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class OportunidadImporteController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        [HttpPost]
        public JsonResult OportunidadImporte_Agregar(Models.OportunidadImporte oportunidadImporte, Application.OportunidadImporte APOportunidadImporte)
        {
            oportunidadImporte.Usuario = Usuario;
            Models.OportunidadImporte dbOportunidadImporte = APOportunidadImporte.OportunidadImporte_Agregar(oportunidadImporte);
            return Json(dbOportunidadImporte);
        }
        [HttpPost]
        public JsonResult OportunidadImporte_Eliminar(Models.OportunidadImporte oportunidadImporte, Application.OportunidadImporte APOportunidadImporte)
        {
            oportunidadImporte.Usuario = Usuario;
            Models.OportunidadImporte dbOportunidadImporte = APOportunidadImporte.OportunidadImporte_Eliminar(oportunidadImporte);
            return Json(dbOportunidadImporte);
        }
        [HttpPost]
        public JsonResult OportunidadImporte_Editar(Models.OportunidadImporte oportunidadImporte, Application.OportunidadImporte APOportunidadImporte)
        {
            oportunidadImporte.Usuario = Usuario;
            Models.OportunidadImporte dbOportunidadImporte = APOportunidadImporte.OportunidadImporte_Editar(oportunidadImporte);
            return Json(dbOportunidadImporte);
        }
        [HttpPost]
        public JsonResult OportunidadImporte_Seleccionar_Id(Models.OportunidadImporte oportunidadImporte, Application.OportunidadImporte APOportunidadImporte)
        {
            Models.OportunidadImporte dbOportunidadImporte = APOportunidadImporte.OportunidadImporte_Seleccionar_Id(oportunidadImporte);
            return Json(dbOportunidadImporte);
        }
        [HttpPost]
        public JsonResult OportunidadImporte_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad, Application.OportunidadImporte APOportunidadImporte)
        {
            List<Models.OportunidadImporte> dbOportunidadImporte = APOportunidadImporte.OportunidadImporte_Seleccionar_IdOportunidad(oportunidad);
            return Json(dbOportunidadImporte);
        }

    }
}
