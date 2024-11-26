using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.UI;
using Newtonsoft.Json;

namespace CRM.Controllers
{
    public class CorreoController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        string cadena = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        Models.MenuPermiso menuPermiso = new Models.MenuPermiso();
        Models.Menu Menu = new Models.Menu();

        // GET: Correo
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

        public ActionResult Crear(Application.Usuario APusuario, Application.CatUnidadNegocio APcatUnidadNegocio, Application.CatEstatusMarketing APmarketing, Application.Campaign APcampaign)
        {
            if (ValidaUsuario())
            {
                List<Models.CatUnidadNegocio> catUnidadNegocio = APcatUnidadNegocio.CatUnidadNegocio_Seleccionar();
                List<Models.Usuario> usuarios = APusuario.Usuario_Propietario_Seleccionar();
                List<Models.CatEstatusMarketing> EstatusMarketing = APmarketing.CatEstatusMarketing_Seleccionar();
                List<Models.Campaign> LisCampaign = APcampaign.Campaign_Seleccionar();

                ViewBag.EstatusMarketing = EstatusMarketing;
                ViewBag.UnidadNegocio = catUnidadNegocio;
                ViewBag.Usuarios = usuarios;
                ViewBag.Campaign = LisCampaign;

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }

        public ActionResult Lista(Application.Lista ALista, Application.CatUnidadNegocio APcatUnidadNegocio, Application.Empresa APempresa, Models.Lista lista)
        {
            lista.Usuario = Usuario;
            List<Models.Lista> RAll = ALista.Lista_Read(lista);
            List<Models.Lista> R = ALista.Lista_Read_IdUser(lista);
            List<Models.CatUnidadNegocio> catUnidadNegocio = APcatUnidadNegocio.CatUnidadNegocio_Seleccionar();
            List<Models.Empresa> empresas = APempresa.Empresa_Seleccionar();

            ViewBag.Lista = R;
            ViewBag.UnidadNegocio = catUnidadNegocio;
            ViewBag.Empresas = empresas;
            ViewBag.ListaAll = RAll;


            return View();
        }

        public ActionResult Plantilla(Models.Plantilla template, Application.Plantilla Aplantilla,Models.CampaignCorreoElectronico campaignCorreo)
        {
            template.Usuario = Usuario;
            List<Models.Plantilla> mytemplate = Aplantilla.ListarPlantillaUsuario(template);
            List<Models.Plantilla> R = Aplantilla.ListarPlantillas();
            ViewBag.MyTemplates = mytemplate;
            ViewBag.Templates = R;

            if (!String.IsNullOrEmpty(Request.QueryString["config"]))
            {
                int IdcampaignCorreo = Convert.ToInt32(Request.QueryString["config"]);
                campaignCorreo.Id = IdcampaignCorreo;
                Models.CampaignCorreoElectronico templateCamping = Aplantilla.TemplateCampingEmail(campaignCorreo);
                ViewBag.email = templateCamping;
            }
            
            return View();
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
