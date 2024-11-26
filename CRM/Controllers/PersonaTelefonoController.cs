using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class PersonaTelefonoController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];

        [HttpPost]
        public JsonResult PersonaTelefono_Agregar(Models.PersonaTelefono personaTelefono, Application.PersonaTelefono APPersonaTelefono)
        {
            personaTelefono.Usuario = Usuario;
            Models.PersonaTelefono dbPersonaTelefono = APPersonaTelefono.PersonaTelefono_Agregar(personaTelefono);
            return Json(dbPersonaTelefono);
        }
        [HttpPost]
        public JsonResult PersonaTelefono_Seleccionar_IdPersona(Models.Persona persona, Application.PersonaTelefono APPersonaTelefono)
        {
            List<Models.PersonaTelefono> dbPersonaTelefono = APPersonaTelefono.PersonaTelefono_Seleccionar_IdPersona(persona);
            return Json(dbPersonaTelefono);
        }
        [HttpPost]
        public JsonResult PersonaTelefono_Eliminar(Models.PersonaTelefono personaTelefono, Application.PersonaTelefono APPersonaTelefono)
        {
            personaTelefono.Usuario = Usuario;
            Models.PersonaTelefono dbPersonaTelefono = APPersonaTelefono.PersonaTelefono_Eliminar(personaTelefono);
            return Json(dbPersonaTelefono);
        }

        [HttpPost]
        public JsonResult PersonaTelefono_Actualizar(Models.PersonaTelefono personaTelefono, Application.PersonaTelefono APPersonaTelefono)
        {
            personaTelefono.Usuario = Usuario;
            Models.PersonaTelefono dbPersonaTelefono = APPersonaTelefono.PersonaTelefono_Actualizar(personaTelefono);
            return Json(dbPersonaTelefono);
        }
    }
}
