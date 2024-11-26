using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class MensajeController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        [HttpPost]
        public JsonResult Mensaje_Agregar(Models.Consulta.NuevoMensaje nuevoMensaje, Application.Mensaje APMensaje, Application.MensajePersona APMensajePersona)
        {
            nuevoMensaje.Mensaje.Usuario = Usuario;
            Models.Mensaje dbReunion = APMensaje.Mensaje_Agregar(nuevoMensaje);

            foreach (var NuevaPersona in nuevoMensaje.MensajePersona)
            {
                NuevaPersona.Mensaje = dbReunion;
                APMensajePersona.MensajePersona_Agregar(NuevaPersona);
            }
            return Json(dbReunion);
        }
    }
}
