using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class OportunidadEtapaController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];

        [HttpPost]
        public JsonResult OportunidadEtapa_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad, Application.OportunidadEtapa APOportunidadEtapa)
        {
            oportunidad.Usuario = Usuario;
            List<Models.Consulta.Etapas> DBCatTareaEtapa = APOportunidadEtapa.OportunidadEtapa_Seleccionar_IdOportunidad(oportunidad);
            return Json(DBCatTareaEtapa);
        }
        [HttpPost]
        public JsonResult OportunidadEtapaTarea_ActulizarEstatus(Models.OportunidadEtapaTarea oportunidadEtapaTarea, Application.OportunidadEtapaTarea APOportunidadEtapaTarea)
        {
            oportunidadEtapaTarea.Usuario = Usuario;
            Models.OportunidadEtapaTarea DBCatTareaEtapa = APOportunidadEtapaTarea.OportunidadEtapaTarea_ActulizarEstatus(oportunidadEtapaTarea);
            return Json(DBCatTareaEtapa);
        }
        [HttpPost]
        public JsonResult OportunidadEtapaTarea_RetrocederEtapa(Models.OportunidadEtapaTarea oportunidadEtapaTarea, Application.OportunidadEtapaTarea APOportunidadEtapaTarea)
        {
            oportunidadEtapaTarea.Usuario = Usuario;
            Models.OportunidadEtapaTarea DBCatTareaEtapa = APOportunidadEtapaTarea.OportunidadEtapaTarea_RetrocederEtapa(oportunidadEtapaTarea);
            return Json(DBCatTareaEtapa);
        }
        [HttpPost]
        public JsonResult Funnel_Ventas(Application.OportunidadEtapa APOportunidadEtapa)
        {
            List<Models.Consulta.EtapaOportunidad> DBCatTareaEtapa = APOportunidadEtapa.Funnel_Ventas();
            return Json(DBCatTareaEtapa);
        }
        [HttpPost]
        public JsonResult Funnel_Ventas_UnidadNegocio(Models.CatUnidadNegocio catUnidadNegocio ,Application.OportunidadEtapa APOportunidadEtapa)
        {
            List<Models.Consulta.EtapaOportunidad> DBCatTareaEtapa = APOportunidadEtapa.Funnel_Ventas_UnidadNegocio(catUnidadNegocio);
            return Json(DBCatTareaEtapa);
        }
    }
}
