using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class CampaignController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        string cadena = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        Models.MenuPermiso menuPermiso = new Models.MenuPermiso();
        Models.Menu Menu = new Models.Menu();

        public ActionResult Index(Application.CatUnidadNegocio APcatUnidadNegocio, Application.Usuario APusuario, Application.CatEstatusMarketing APmarketing)
        {
            List<Models.CatUnidadNegocio> catUnidadNegocio = APcatUnidadNegocio.CatUnidadNegocio_Seleccionar();
            List<Models.Usuario> usuarios = APusuario.Usuario_Propietario_Seleccionar();
            List<Models.CatEstatusMarketing> EstatusMarketing = APmarketing.CatEstatusMarketing_Seleccionar();

            ViewBag.UnidadNegocio = catUnidadNegocio;
            ViewBag.Usuarios = usuarios;
            ViewBag.EstatusMarketing = EstatusMarketing;

            return View();
        }

        public ActionResult CampaingnCorreo()
        {
            ViewBag.usuario = Usuario.Id;
            return View();
        }

        public ActionResult CampaingnInfo(Models.CampaignCorreoElectronico campaignCorreo, Application.Campaign APcampaign, Application.CatUnidadNegocio APcatUnidadNegocio, Application.CatEstatusMarketing APmarketing, Application.Lista APPlist, Models.Lista lista, Application.Usuario APusuario)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["config"]))
            {
                int Id = Convert.ToInt32(Request.QueryString["config"]);
                campaignCorreo.Id = Id;
                Models.Campaign campaign = new Models.Campaign();
                campaign.Id = Id;
                lista.Campaign = campaign;

                Models.Campaign R = APcampaign.Campaign_Seleccionar_Id(campaignCorreo);
                List<Models.CatUnidadNegocio> catUnidadNegocio = APcatUnidadNegocio.CatUnidadNegocio_Seleccionar();
                List<Models.CampaignCorreoElectronico> LisCampaign = APcampaign.CampaignCorreoElectronico_listCorreo(campaignCorreo);
                List<Models.OportunidadBitacora> CampanaBitacora = APcampaign.CampaignBitacora_Seleccionar(campaignCorreo);
                List<Models.CatEstatusMarketing> EstatusMarketing = APmarketing.CatEstatusMarketing_Seleccionar();
                List<Models.Usuario> usuarios = APusuario.Usuario_Propietario_Seleccionar();
                List<Models.Lista> listContactos = APPlist.Lista_Read_UserIdCampaing(lista);
                Models.Lista DataCampana = APPlist.Lista_Read_IdCampaing(lista);
                List<Models.Campaign> ListaCampaign = APcampaign.Campaign_Seleccionar();



                ViewBag.Campana = R;
                ViewBag.Correos = LisCampaign;
                ViewBag.CampanaBitacora = CampanaBitacora;
                ViewBag.UnidadNegocio = catUnidadNegocio;
                ViewBag.EstatusMarketing = EstatusMarketing;
                ViewBag.contactos = listContactos;
                ViewBag.InfoCampana = DataCampana;
                ViewBag.Usuarios = usuarios;
                ViewBag.Campaign = ListaCampaign;



                return View();
            }
            else
            {
                return RedirectToAction("CampaingnCorreo", "Campaign");
            }

        }




        [HttpPost]
        public JsonResult Campaign_Seleccionar(Application.Campaign APcampaign)
        {
            List<Models.Campaign> LisCampaign = APcampaign.Campaign_Seleccionar();
            return Json(LisCampaign);
        }

        [HttpPost]
        public JsonResult Campaign_Agregar(Models.CampaignUnidadNegocio campaignUnidadNegocio, Application.Campaign APCampaign)
        {
            Models.Campaign DBCampaign = APCampaign.Campaign_Agregar(campaignUnidadNegocio);
            return Json(DBCampaign);
        }

        [HttpPost]
        public JsonResult Campaign_Actualizar(Models.CampaignUnidadNegocio campaignUnidadNegocio, Application.Campaign APCampaign)
        {
            campaignUnidadNegocio.Campaign.Usuario = Usuario;

            Models.Campaign DBCampaign = APCampaign.Campaign_Actualizar(campaignUnidadNegocio);
            return Json(DBCampaign);
        }

        [HttpPost]
        public JsonResult Campaign_ActualizarEstatus(Models.CampaignUnidadNegocio campaignUnidadNegocio, Application.Campaign APCampaign)
        {
            campaignUnidadNegocio.Campaign.Usuario = Usuario;
            Models.Campaign DBCampaign = APCampaign.Campaign_ActualizarEstatus(campaignUnidadNegocio);
            return Json(DBCampaign);
        }
        [HttpPost]
        public JsonResult CampaignCorreoElectronico_Insert(Models.CampaignCorreoElectronico Model, Application.Campaign APCampaign)
        {
            Model.Usuario = Usuario;
            Models.CampaignCorreoElectronico DBCampaign = APCampaign.CampaignCorreoElectronico_Insert(Model);
            return Json(DBCampaign);
        }

        [HttpPost]
        public JsonResult CampaignCorreoElectronico_ListaInsert(Models.CampaignCorreoElectronico Model, Application.Campaign APCampaign)
        {
            Model.Usuario = Usuario;
            Models.CampaignCorreoElectronico DBCampaign = APCampaign.CampaignCorreoElectronico_Lista(Model);
            return Json(DBCampaign);
        }

        [HttpPost]
        public JsonResult CampaignCorreoElectronico_listCorreo(Application.Campaign APcampaign, Models.CampaignCorreoElectronico Model)
        {
            List<Models.CampaignCorreoElectronico> LisCampaign = APcampaign.CampaignCorreoElectronico_listCorreo(Model);
            return Json(LisCampaign);
        }


        [HttpPost]
        public JsonResult EXITSCAMPINGLIST(Models.Campaign campaign, Application.Campaign APCampaign)
        {
            Models.Campaign DBCampaign = APCampaign.EXITSCAMPINGLIST(campaign);
            return Json(DBCampaign);
        }
















        [HttpPost]
        public JsonResult CampaignCorreoElectronico_Seleccionar_Id(Models.CampaignCorreoElectronico Model, Application.Campaign APCampaign)
        {
            Models.CampaignCorreoElectronico DBCampaign = APCampaign.CampaignCorreoElectronico_Seleccionar_Id(Model);
            return Json(DBCampaign);
        }


        [HttpPost]
        public JsonResult CampaignCorreoElectronico_Actualizar(Models.CampaignCorreoElectronico CampaignCorreoElectronico, Application.Campaign APCampaign)
        {
            CampaignCorreoElectronico.Campaign.Usuario = Usuario;

            Models.CampaignCorreoElectronico DBCampaign = APCampaign.CampaignCorreoElectronico_Actualizar(CampaignCorreoElectronico);
            return Json(DBCampaign);
        }

    }
}
