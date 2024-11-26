using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class ReunionController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        [HttpPost]
        public JsonResult Reunion_Agregar(Models.Consulta.NuevaReunion nuevaReunion, Application.Reunion APReunion, Application.ReunionPersona APReunionPersona)
        {
            nuevaReunion.Reunion.Usuario = Usuario;
            Models.Reunion dbReunion = APReunion.Reunion_Agregar(nuevaReunion);

            foreach (var NuevaPersona in nuevaReunion.ReunionPersona)
            {
                NuevaPersona.Reunion = dbReunion;
                APReunionPersona.ReunionPersona_Agregar(NuevaPersona);
            }
            return Json(dbReunion);
        }
    }
}
