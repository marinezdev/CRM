using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult IniciarSesion(Models.Usuario usuario, Application.Usuario APUsuario, Application.Menu APmenu)
        {
            if (usuario != null)
            {
                Models.Usuario DataUser = APUsuario.Iniciar(usuario);
                if (DataUser.Id > 0)
                {
                    Session["Sesion"] = DataUser;
                }
                return Json(DataUser);
            }
            else
            {
                return Json("Ha ocurrido un problema!");
            }
        }

        [HttpPost]
        public JsonResult CerrarSesion()
        {
            Models.Usuario DataUser = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
            Session.Abandon();

            if (DataUser != null)
            {
                return Json(DataUser);
            }
            else
            {
                return Json("Ha ocurrido un problema!");
            }
        }
    }
}
