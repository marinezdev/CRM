using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class TareaController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        string cadena = System.Web.HttpContext.Current.Request.Url.AbsoluteUri;
        Models.MenuPermiso menuPermiso = new Models.MenuPermiso();
        Models.Menu Menu = new Models.Menu();

        public ActionResult Index(Application.Tarea APTarea)
        {
            if (ValidaUsuario())
            {
                List<Models.Consulta.NuevaTarea> dbTareas = APTarea.Tarea_Seleccionar_IdUsuario_Asignadas(Usuario);
                List<Models.Consulta.NuevaTarea> dbTareasPendientes = APTarea.Tarea_Seleccionar_IdUsuario_AsignadasPendientes(Usuario);
                ViewBag.Tareas = dbTareas;
                ViewBag.TareasPendientes = dbTareasPendientes;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }

        public ActionResult MisTareas(Application.Tarea APTarea)
        {
            if (ValidaUsuario())
            {
                List<Models.Consulta.NuevaTarea> dbTareas = APTarea.Tarea_Seleccionar_IdUsuario(Usuario);
                ViewBag.Tareas = dbTareas;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }

        [HttpPost]
        public JsonResult Tarea_Agregar(Models.Consulta.NuevaTarea nuevaTarea, Application.Tarea APtarea)
        {
            nuevaTarea.Tarea.Usuario = Usuario;
            Models.Tarea dbTarea = APtarea.Tarea_Agregar(nuevaTarea);
            return Json(dbTarea);
        }

        [HttpPost]
        public JsonResult Tarea_Actulizar_Terminar(Models.Consulta.NuevaTarea nuevaTarea, Application.Tarea APtarea)
        {
            nuevaTarea.Tarea.Usuario = Usuario;
            Models.Tarea dbTarea = APtarea.Tarea_Actulizar_Terminar(nuevaTarea);
            return Json(dbTarea);
        }

        [HttpPost]
        public JsonResult Tarea_Actulizar_Cancelar(Models.Consulta.NuevaTarea nuevaTarea, Application.Tarea APtarea)
        {
            nuevaTarea.Tarea.Usuario = Usuario;
            Models.Tarea dbTarea = APtarea.Tarea_Actulizar_Cancelar(nuevaTarea);
            return Json(dbTarea);
        }

        [HttpPost]
        public JsonResult Tarea_Seleccionar_Usuairo_Entidad_IdTipoTarea(Models.Consulta.NuevaTarea nuevaTarea, Application.Tarea APtarea)
        {
            Models.Tarea tarea = new Models.Tarea();
            tarea.Usuario = Usuario;
            nuevaTarea.Tarea = tarea;
            List<Models.Tarea> dbTarea = APtarea.Tarea_Seleccionar_Usuairo_Entidad_IdTipoTarea(nuevaTarea);
            return Json(dbTarea);
        }

        [HttpPost]
        public JsonResult Tarea_Selecionar_IdUsuario_Estatus(Application.Tarea APtarea)
        {
            Models.Consulta.NuevaTarea nuevaTarea = new Models.Consulta.NuevaTarea();
            Models.Tarea tarea = new Models.Tarea();
            tarea.Usuario = Usuario;
            nuevaTarea.Tarea = tarea;
            List<Models.Tarea> dbTarea = APtarea.Tarea_Selecionar_IdUsuario_Estatus(nuevaTarea);
            return Json(dbTarea);
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
