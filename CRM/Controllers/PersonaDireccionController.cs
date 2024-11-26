using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class PersonaDireccionController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];

        [HttpPost]
        public JsonResult PersonaDireccion_Agregar(Models.PersonaDireccion personaDireccion, Application.PersonaDireccion APPersonaDireccion)
        {
            personaDireccion.Usuario = Usuario;
            Models.PersonaDireccion dbPersonaDireccion = APPersonaDireccion.PersonaDireccion_Agregar(personaDireccion);
            return Json(dbPersonaDireccion);
        }
        [HttpPost]
        public JsonResult PersonaDireccion_Eliminar(Models.PersonaDireccion personaDireccion, Application.PersonaDireccion APPersonaDireccion)
        {
            personaDireccion.Usuario = Usuario;
            Models.PersonaDireccion dbPersonaDireccion = APPersonaDireccion.PersonaDireccion_Eliminar(personaDireccion);
            return Json(dbPersonaDireccion);
        }
        [HttpPost]
        public JsonResult PersonaDireccion_Seleccionar_IdPersona(Models.Persona persona, Application.PersonaDireccion APPersonaDireccion)
        {
            List<Models.PersonaDireccion> dbPersonaDireccion = APPersonaDireccion.PersonaDireccion_Seleccionar_IdPersona(persona);
            return Json(dbPersonaDireccion);
        }
    }
}
