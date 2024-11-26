using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class ClaveMovimientoController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        [HttpPost]
        public JsonResult ClaveMovimiento_Agregar(Models.ClaveMovimiento claveMovimiento, Application.ClaveMovimiento APclaveMovimiento)
        {
            claveMovimiento.Usuario = Usuario;
            Models.ClaveMovimiento DBClaveMovimiento = APclaveMovimiento.ClaveMovimiento_Agregar(claveMovimiento);
            return Json(DBClaveMovimiento);
        }
    }
}
