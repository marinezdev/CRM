using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class CorreoElectronicoController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        [HttpPost]
        public JsonResult CorreoElectronico_Agregar(Models.Consulta.NuevoCorreo nuevoCorreo, Application.Correo APCorreo, Application.CorreoPersona APcorreoPersona)
        {
            nuevoCorreo.Correo.Usuario = Usuario;
            Models.Correo dbCorreo = APCorreo.Correo_Agregar(nuevoCorreo);

            foreach (var NuevaPersona in nuevoCorreo.CorreoPersona)
            {
                NuevaPersona.Correo = dbCorreo;
                APcorreoPersona.CorreoPersona_Agregar(NuevaPersona);
            }
            return Json(dbCorreo);
        }
    }
}
