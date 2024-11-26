using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class LlamadaController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        [HttpPost]
        public JsonResult Llamada_Agregar(Models.Consulta.NuevaLlamada nuevaLlamada, Application.Llamada APLlamada, Application.LlamadaPersona APLlamadaPersona)
        {
            nuevaLlamada.Llamada.Usuario = Usuario;
            Models.Llamada dbLlamada = APLlamada.Llamada_Agregar(nuevaLlamada);

            foreach (var NuevaPersona in nuevaLlamada.LlamadaPersona)
            {
                NuevaPersona.Llamada = dbLlamada;
                APLlamadaPersona.LlamadaPersona_Agregar(NuevaPersona);
            }
            return Json(dbLlamada);
        }
    }
}
