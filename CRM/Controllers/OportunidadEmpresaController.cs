using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class OportunidadEmpresaController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        [HttpPost]
        public JsonResult OportunidadEmpresa_Agregar(Models.OportunidadEmpresa oportunidadEmpresa, Application.OportunidadEmpresa APOportunidadEmpresa)
        {
            oportunidadEmpresa.Usuario = Usuario;
            Models.OportunidadEmpresa dbOportunidadEmpresa = APOportunidadEmpresa.OportunidadEmpresa_Agregar(oportunidadEmpresa);
            return Json(dbOportunidadEmpresa);
        }
        [HttpPost]
        public JsonResult OportunidadEmpresa_Eliminar(Models.OportunidadEmpresa oportunidadEmpresa, Application.OportunidadEmpresa APOportunidadEmpresa)
        {
            oportunidadEmpresa.Usuario = Usuario;
            Models.OportunidadEmpresa dbOportunidadEmpresa = APOportunidadEmpresa.OportunidadEmpresa_Eliminar(oportunidadEmpresa);
            return Json(dbOportunidadEmpresa);
        }
        [HttpPost]
        public JsonResult OportunidadEmpresa_Seleccionar_IdEmpresa(Models.Empresa empresa, Application.OportunidadEmpresa APOportunidadEmpresa)
        {
            List<Models.OportunidadEmpresa> dbOportunidadEmpresa = APOportunidadEmpresa.OportunidadEmpresa_Seleccionar_IdEmpresa(empresa);
            return Json(dbOportunidadEmpresa);
        }
        [HttpPost]
        public JsonResult OportunidadEmpresa_Seleccionar_IdEmpresa_Year(Models.Empresa empresa, Application.OportunidadEmpresa APOportunidadEmpresa)
        {
            List<Models.OportunidadEmpresa> dbOportunidadEmpresa = APOportunidadEmpresa.OportunidadEmpresa_Seleccionar_IdEmpresa_Year(empresa);
            return Json(dbOportunidadEmpresa);
        }
        [HttpPost]
        public JsonResult OportunidadEmpresa_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad, Application.OportunidadEmpresa APOportunidadEmpresa)
        {
            List<Models.OportunidadEmpresa> dbOportunidadEmpresa = APOportunidadEmpresa.OportunidadEmpresa_Seleccionar_IdOportunidad(oportunidad);
            return Json(dbOportunidadEmpresa);
        }
    }
}
