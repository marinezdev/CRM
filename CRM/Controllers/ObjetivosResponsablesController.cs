using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class ObjetivosResponsablesController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        string cadena = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        Models.MenuPermiso menuPermiso = new Models.MenuPermiso();
        Models.Menu Menu = new Models.Menu();
        public ActionResult Index()
        {
            if (ValidaUsuario())
            {

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }

        [HttpPost]
        public JsonResult ObjetivosResponsables_Agregar(Models.ObjetivosResponsables objetivosResponsables, Application.ObjetivosResponsables APobjetivosResponsables)
        {
            Models.ObjetivosResponsables DBCObjetivosResponsables = APobjetivosResponsables.ObjetivosResponsables_Agregar(objetivosResponsables);
            return Json(DBCObjetivosResponsables);
        }

        [HttpPost]
        public JsonResult ObjetivosResponsables_Seleccionar_Id(Models.ObjetivosResponsables objetivosResponsables, Application.ObjetivosResponsables APobjetivosResponsables)
        {
            Models.ObjetivosResponsables DBCObjetivosResponsables = APobjetivosResponsables.ObjetivosResponsables_Seleccionar_Id(objetivosResponsables);
            return Json(DBCObjetivosResponsables);
        }

        [HttpPost]
        public JsonResult ObjetivosResponsables_Actualizar(Models.ObjetivosResponsables objetivosResponsables, Application.ObjetivosResponsables APobjetivosResponsables)
        {
            Models.ObjetivosResponsables DBCObjetivosResponsables = APobjetivosResponsables.ObjetivosResponsables_Actualizar(objetivosResponsables);
            return Json(DBCObjetivosResponsables);
        }

        [HttpPost]
        public JsonResult ObjetivosResponsables_Selecionar_Year(Application.ObjetivosResponsables APobjetivosResponsables)
        {
            List<Models.ObjetivosResponsables> LisObjetivosResponsables = APobjetivosResponsables.ObjetivosResponsables_Selecionar_Year();
            return Json(LisObjetivosResponsables);
        }

        [HttpPost]
        public JsonResult ObjetivosResponsables_Reporte_Year(Models.ObjetivosResponsables objetivosResponsables, Application.ObjetivosResponsables APobjetivosResponsables)
        {
            List<Models.ObjetivosResponsables> LisObjetivosResponsables = APobjetivosResponsables.ObjetivosResponsables_Reporte_Year(objetivosResponsables.Id);
            return Json(LisObjetivosResponsables);
        }

        public bool ValidaUsuario()
        {
            bool result = false;
            Application.Menu APmenu = new Application.Menu();

            try
            {
                menuPermiso.Rol = Usuario.Rol;
                Menu.URL = url;
                menuPermiso.Menu = Menu;
                if (APmenu.ValidacionPagina(menuPermiso))
                {
                    result = true;
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}
