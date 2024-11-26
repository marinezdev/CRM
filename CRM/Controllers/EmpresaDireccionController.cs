using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class EmpresaDireccionController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];

        [HttpPost]
        public JsonResult EmpresaDireccion_Agregar(Models.EmpresaDireccion empresaDireccion, Application.EmpresaDireccion APEmpresaDireccion)
        {
            empresaDireccion.Usuario = Usuario;
            Models.EmpresaDireccion dbEmpresaDireccion = APEmpresaDireccion.EmpresaDireccion_Agregar(empresaDireccion);
            return Json(dbEmpresaDireccion);
        }
        [HttpPost]
        public JsonResult EmpresaDireccion_Eliminar(Models.EmpresaDireccion empresaDireccion, Application.EmpresaDireccion APEmpresaDireccion)
        {
            empresaDireccion.Usuario = Usuario;
            Models.EmpresaDireccion dbEmpresaDireccion = APEmpresaDireccion.EmpresaDireccion_Eliminar(empresaDireccion);
            return Json(dbEmpresaDireccion);
        }
        [HttpPost]
        public JsonResult EmpresaDireccion_Seleccionar_IdEmpresa(Models.Empresa empresa, Application.EmpresaDireccion APEmpresaDireccion)
        {
            List<Models.EmpresaDireccion> dbEmpresaDireccion = APEmpresaDireccion.EmpresaDireccion_Seleccionar_IdEmpresa(empresa);
            return Json(dbEmpresaDireccion);
        }
    }
}
