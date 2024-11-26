using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class DepartamentoController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];

        [HttpPost]
        public JsonResult Departamento_Seleccionar_IdEmpresa(Models.Empresa empresa, Application.Departamento APDepartamento)
        {
            List<Models.Departamento> DBDepartamentos = APDepartamento.Departamento_Seleccionar_IdEmpresa(empresa);
            return Json(DBDepartamentos);
        }

        [HttpPost]
        public JsonResult Departamento_Agregar(Models.Departamento departamento, Application.Departamento APDepartamento)
        {
            departamento.Usuario = Usuario;
            Models.Departamento DBDepartamento = APDepartamento.Departamento_Agregar(departamento);
            return Json(DBDepartamento);
        }
    }
}
