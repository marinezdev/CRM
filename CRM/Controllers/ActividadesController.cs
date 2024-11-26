using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class ActividadesController : Controller
    {
        [HttpPost]
        public JsonResult Actividades_Selecionar_FechaRegistro(Models.Consulta.Actividades actividades, Application.Actividades APActividades)
        {
            List<Models.Consulta.Actividades> DBActividades = APActividades.Actividades_Selecionar_FechaRegistro(actividades);
            return Json(DBActividades);
        }

        [HttpPost]
        public JsonResult Actividades_Selecionar_Valor(Models.Consulta.Actividades actividades, Application.Actividades APActividades)
        {
            Models.Consulta.Actividades DBActividades = APActividades.Actividades_Selecionar_Valor(actividades);
            return Json(DBActividades);
        }

        [HttpPost]
        public JsonResult Actividades_Selecionar_FechaRegistro_IdUsuario(Models.Consulta.Actividades actividades, Application.Actividades APActividades)
        {
            List<Models.Consulta.Actividades> DBActividades = APActividades.Actividades_Selecionar_FechaRegistro_IdUsuario(actividades);
            return Json(DBActividades);
        }
    }
}
