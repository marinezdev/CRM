using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class NotasController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        [HttpPost]
        public JsonResult Nota_Agregar(Models.NotaEntidad notaEntidad, Application.Nota APnota)
        {
            notaEntidad.Nota.Usuario = Usuario;
            Models.Nota dbNota = APnota.Nota_Agregar(notaEntidad);
            return Json(dbNota);
        }
    }
}
