using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace CRM.Controllers
{
    public class PlantillaController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];

        public ActionResult MyTemplates(Models.Plantilla template, Application.Plantilla Aplantilla)
        {
            template.Usuario = Usuario;
            List<Models.Plantilla> mytemplate = Aplantilla.ListarPlantillaUsuario(template);
            ViewBag.MyTemplates = mytemplate;

            return View();
        }


        [HttpPost]
        public JsonResult ObtenerPlantilla(Models.Plantilla template, Application.Plantilla Aplantilla)
        {
            Models.Plantilla R = Aplantilla.ObtenerPlantilla(template);
            return Json(R);
        }


        [HttpPost]
        public JsonResult Template_Save(Models.Plantilla template, Application.Plantilla Aplantilla)
        {
            template.Usuario = Usuario;
            Models.Plantilla R = Aplantilla.Template_Save(template);
            return Json(R);
        }

        [HttpPost]
        public JsonResult Template_Update(Models.Plantilla template, Application.Plantilla Aplantilla)
        {
            Models.Plantilla R = Aplantilla.Template_Update(template);
            return Json(R);
        }


        [HttpPost]
        public JsonResult CampaignCorreoElectronico_Save(Models.Plantilla template, Application.Plantilla Aplantilla)
        {
            //template.Usuario = Usuario;
            Models.Plantilla R = Aplantilla.CampaignCorreoElectronico_Save(template);
            return Json(R);
        }

        [HttpPost]
        public JsonResult Template_Eliminar(Models.Plantilla template, Application.Plantilla Aplantilla)
        {
            Models.Plantilla R = Aplantilla.Template_Eliminar(template);
            return Json(R);
        }


        [HttpPost]
        public JsonResult Template_Editar(Models.Plantilla template, Application.Plantilla Aplantilla)
        {
            Models.Plantilla R = Aplantilla.Template_Editar(template);
            return Json(R);
        }












        [HttpPost]
        public JsonResult Template_Save_Id(Models.Plantilla template, Application.Plantilla Aplantilla)
        {
            Models.Plantilla R = Aplantilla.Template_Save_Id(template);
            return Json(R);
        }
    }
}