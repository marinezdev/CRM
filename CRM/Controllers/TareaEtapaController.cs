using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class TareaEtapaController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        string cadena = System.Web.HttpContext.Current.Request.Url.AbsoluteUri;
        Models.MenuPermiso menuPermiso = new Models.MenuPermiso();
        Models.Menu Menu = new Models.Menu();

        // GET: TareaEtapa
        public ActionResult Index(Application.CatTareaEtapa APcatTareaEtapa, Application.CatEtapaOportunidad APcatEtapaOportunidad)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    int IdEtapa = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));

                    Models.CatEtapaOportunidad catEtapaOportunidad = new Models.CatEtapaOportunidad();
                    catEtapaOportunidad.Id = IdEtapa;

                    Models.CatEtapaOportunidad DTcatEtapaOportunidad = APcatEtapaOportunidad.CatEtapaOportunidad_Seleccionar_Id(catEtapaOportunidad);
                    List<Models.CatTareaEtapa> ListTareaEtapa = APcatTareaEtapa.CatTareaEtapa_Seleccionar_IdEtapa(catEtapaOportunidad);

                    ViewBag.EtapaOportunidad = DTcatEtapaOportunidad;
                    ViewBag.TareaEtapa = ListTareaEtapa;
                    ViewBag.CatEtapaOportunidad = catEtapaOportunidad;
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Etapa");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }

        [HttpPost]
        public JsonResult CatTareaEtapa_Agregar(Models.CatTareaEtapa catTareaEtapa ,Application.CatTareaEtapa APcatTareaEtapa)
        {
            Models.CatTareaEtapa DBCatTareaEtapa = APcatTareaEtapa.CatTareaEtapa_Agregar(catTareaEtapa);
            return Json(DBCatTareaEtapa);
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
