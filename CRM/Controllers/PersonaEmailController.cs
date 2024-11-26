using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class PersonaEmailController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        [HttpPost]
        public JsonResult PersonaEmail_Agregar(Models.PersonaEmail personaEmail, Application.PersonaEmail APPersonaEmail)
        {
            personaEmail.Usuario = Usuario;
            Models.PersonaEmail dbPersonaEmail = APPersonaEmail.PersonaEmail_Agregar(personaEmail);
            return Json(dbPersonaEmail);
        }

        [HttpPost]
        public JsonResult PersonaEmail_Seleccionar_IdPersona(Models.Persona persona, Application.PersonaEmail APPersonaEmail)
        {
            List<Models.PersonaEmail> dbPersonaEmail = APPersonaEmail.PersonaEmail_Seleccionar_IdPersona(persona);
            return Json(dbPersonaEmail);
        }

    }
}
