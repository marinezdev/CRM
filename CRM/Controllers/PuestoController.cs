using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class PuestoController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        [HttpPost]
        public JsonResult Puesto_Seleccionar_IdDepartamento(Models.Departamento departamento, Application.Puesto APPuesto)
        {
            List<Models.Puesto> DBPuesto = APPuesto.Puesto_Seleccionar_IdDepartamento(departamento);
            return Json(DBPuesto);
        }

        [HttpPost]
        public JsonResult Puesto_Agregar(Models.Puesto puesto, Application.Puesto APPuesto)
        {
            puesto.Usuario = Usuario;
            Models.Puesto DBPuesto = APPuesto.Puesto_Agregar(puesto);
            return Json(DBPuesto);
        }
    }
}
