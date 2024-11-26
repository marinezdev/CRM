using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class AdministracionController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        string cadena = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        Models.MenuPermiso menuPermiso = new Models.MenuPermiso();
        Models.Menu Menu = new Models.Menu();
        
        // : Administracion
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
        public ActionResult Dashbord()
        {
            //if (ValidaUsuario())
            //{
                return View();
            //}
            //else
            //{
            //    return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            //}
        } 
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Ventas(Application.Usuario APusuario, Application.CatUnidadNegocio APcatUnidadNegocio)
        {
            if (ValidaUsuario())
            {
                List<Models.Usuario> usuarios = APusuario.Usuario_Propietario_Seleccionar();
                List<Models.CatUnidadNegocio> catUnidadNegocio = APcatUnidadNegocio.CatUnidadNegocio_Seleccionar();

                ViewBag.Usuarios = usuarios;
                ViewBag.UnidadNegocio = catUnidadNegocio;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        public ActionResult VentasUnidadNegocio(Application.Oportunidad APoportunidad, Application.ObjetivoFacturaAcumulado APobjetivoFacturaAcumulado)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    int IdUnidadNegocio = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));
                    Models.CatUnidadNegocio catUnidadNegocio = new Models.CatUnidadNegocio();
                    catUnidadNegocio.Id = IdUnidadNegocio;
                    List<Models.Oportunidad> ListOportunidades = APoportunidad.Oportunidad_Seleccionar_IdUnidadNegocio_Funnel(catUnidadNegocio);
                    List<Models.ObjetivoFacturaAcumulado> ListobjetivoFacturaAcumulados = APobjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_IdUnidadNegocio(catUnidadNegocio);
                    
                    ViewBag.Oportunidad = ListOportunidades;
                    ViewBag.ObjetivoFacturaAcumulado = ListobjetivoFacturaAcumulados;
                    ViewBag.Id = IdUnidadNegocio;
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Administracion");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
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

        public ActionResult Prueba()
        {
            return View();
        }

    }
}
