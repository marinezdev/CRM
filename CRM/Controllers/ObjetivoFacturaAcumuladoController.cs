using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class ObjetivoFacturaAcumuladoController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        string cadena = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        Models.MenuPermiso menuPermiso = new Models.MenuPermiso();
        Models.Menu Menu = new Models.Menu();

        public ActionResult Index(Application.ObjetivoFacturaAcumulado APobjetivoFacturaAcumulado)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    int IdObjetivo = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));
                    Models.ObjetivosResponsables objetivosResponsables = new Models.ObjetivosResponsables();
                    objetivosResponsables.Id = IdObjetivo;
                    List<Models.ObjetivoFacturaAcumulado> LisObjetivoAcumulado = APobjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Seleccionar_IdObjetivo(objetivosResponsables);

                    ViewBag.LisObjetivoAcumulado = LisObjetivoAcumulado;
                    return View();
                }
                else
                {
                    return RedirectToAction("Ventas", "Administracion");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }


        public ActionResult Anterior(Application.ObjetivoFacturaAcumulado APobjetivoFacturaAcumulado)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    if (!String.IsNullOrEmpty(Request.QueryString["year"]))
                    {
                        int IdObjetivo = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));
                        int year = Convert.ToInt32(Request.QueryString["year"]);
                        Models.ObjetivosResponsables objetivosResponsables = new Models.ObjetivosResponsables();
                        objetivosResponsables.Id = IdObjetivo;
                        objetivosResponsables.year = year;
                        List<Models.ObjetivoFacturaAcumulado> LisObjetivoAcumulado = APobjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Seleccionar_IdObjetivoYear(objetivosResponsables);

                        ViewBag.LisObjetivoAcumulado = LisObjetivoAcumulado;
                        ViewBag.Year = year;
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("Ventas", "Administracion");
                    }
                }
                else
                {
                    return RedirectToAction("Ventas", "Administracion");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }


        [HttpPost]
        public JsonResult ObjetivoFacturaAcumulado_Mes_Agregar(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado, Application.ObjetivoFacturaAcumulado APObjetivoFacturaAcumulado)
        {
            objetivoFacturaAcumulado.Usuario = Usuario;
            Models.ObjetivoFacturaAcumulado DBObjetivoFacturaAcumulado = APObjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Mes_Agregar(objetivoFacturaAcumulado);
            return Json(DBObjetivoFacturaAcumulado);
        }
        [HttpPost]
        public JsonResult ObjetivoFacturaAcumulado_Agregar_Mes(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado, Application.ObjetivoFacturaAcumulado APObjetivoFacturaAcumulado)
        {
            objetivoFacturaAcumulado.Usuario = Usuario;
            Models.ObjetivoFacturaAcumulado DBObjetivoFacturaAcumulado = APObjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Agregar_Mes(objetivoFacturaAcumulado);
            return Json(DBObjetivoFacturaAcumulado);
        }
        [HttpPost]
        public JsonResult ObjetivoFacturaAcumulado_Eliminar_Mes(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado, Application.ObjetivoFacturaAcumulado APObjetivoFacturaAcumulado)
        {
            objetivoFacturaAcumulado.Usuario = Usuario;
            Models.ObjetivoFacturaAcumulado DBObjetivoFacturaAcumulado = APObjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Eliminar_Mes(objetivoFacturaAcumulado);
            return Json(DBObjetivoFacturaAcumulado);
        }


        //////////////////////////////////// 
        //////////////////////////////////// ATULIZAR REPORTE DE VENTAS
        ////////////////////////////////////
        [HttpPost]
        public JsonResult ObjetivoFacturaAcumulado_Agregar_Mes_Year(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado, Application.ObjetivoFacturaAcumulado APObjetivoFacturaAcumulado)
        {
            objetivoFacturaAcumulado.Usuario = Usuario;
            Models.ObjetivoFacturaAcumulado DBObjetivoFacturaAcumulado = APObjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Agregar_Mes_Year(objetivoFacturaAcumulado);
            return Json(DBObjetivoFacturaAcumulado);
        }
        [HttpPost]
        public JsonResult ObjetivoFacturaAcumulado_Eliminar_Mes_Year(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado, Application.ObjetivoFacturaAcumulado APObjetivoFacturaAcumulado)
        {
            objetivoFacturaAcumulado.Usuario = Usuario;
            Models.ObjetivoFacturaAcumulado DBObjetivoFacturaAcumulado = APObjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Eliminar_Mes_Year(objetivoFacturaAcumulado);
            return Json(DBObjetivoFacturaAcumulado);
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
