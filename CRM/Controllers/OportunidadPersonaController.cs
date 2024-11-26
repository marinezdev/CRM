using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class OportunidadPersonaController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];

        [HttpPost]
        public JsonResult OportunidadPersona_Agregar(Models.OportunidadPersona oportunidadPersona, Application.OportunidadPersona APOportunidadPersona)
        {
            oportunidadPersona.Usuario = Usuario;
            Models.OportunidadPersona dbOportunidadPersona = APOportunidadPersona.OportunidadPersona_Agregar(oportunidadPersona);
            return Json(dbOportunidadPersona);
        }
        [HttpPost]
        public JsonResult OportunidadPersona_Editar(Models.OportunidadPersona oportunidadPersona, Application.OportunidadPersona APOportunidadPersona)
        {
            oportunidadPersona.Usuario = Usuario;
            Models.OportunidadPersona dbOportunidadPersona = APOportunidadPersona.OportunidadPersona_Editar(oportunidadPersona);
            return Json(dbOportunidadPersona);
        }
        [HttpPost]
        public JsonResult OportunidadPersona_Eliminar(Models.OportunidadPersona oportunidadPersona, Application.OportunidadPersona APOportunidadPersona)
        {
            oportunidadPersona.Usuario = Usuario;
            Models.OportunidadPersona dbOportunidadPersona = APOportunidadPersona.OportunidadPersona_Eliminar(oportunidadPersona);
            return Json(dbOportunidadPersona);
        }
        [HttpPost]
        public JsonResult OportunidadPersona_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad, Application.OportunidadPersona APOportunidadPersona)
        {
            List<Models.OportunidadPersona> dbOportunidadPersona = APOportunidadPersona.OportunidadPersona_Seleccionar_IdOportunidad(oportunidad);
            return Json(dbOportunidadPersona);
        }
        [HttpPost]
        public JsonResult OportunidadPersona_Seleccionar_Id(Models.OportunidadPersona oportunidadPersona, Application.OportunidadPersona APOportunidadPersona)
        {
            Models.OportunidadPersona dbOportunidadPersona = APOportunidadPersona.OportunidadPersona_Seleccionar_Id(oportunidadPersona);
            return Json(dbOportunidadPersona);
        }
        [HttpPost]
        public JsonResult OportunidadPersona_Seleccionar_IdPersona(Models.Persona persona, Application.OportunidadPersona APOportunidadPersona)
        {
            List<Models.OportunidadPersona> dbOportunidadPersona = APOportunidadPersona.OportunidadPersona_Seleccionar_IdPersona(persona);
            return Json(dbOportunidadPersona);
        }
    }
}
