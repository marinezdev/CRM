using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class EmpleadoController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];

        [HttpPost]
        public JsonResult Empleado_Agregar(Models.Empleado empleado, Application.Empleado APEmpleado)
        {
            empleado.Usuario = Usuario;
            Models.Empleado Empleado = APEmpleado.Empleado_Agregar(empleado);
            return Json(Empleado);
        }
        [HttpPost]
        public JsonResult Empleado_Eliminar(Models.Empleado empleado, Application.Empleado APEmpleado)
        {
            empleado.Usuario = Usuario;
            Models.Empleado Empleado = APEmpleado.Empleado_Eliminar(empleado);
            return Json(Empleado);
        }
        [HttpPost]
        public JsonResult Empleado_Actualizar(Models.Empleado empleado, Application.Empleado APEmpleado)
        {
            empleado.Usuario = Usuario;
            Models.Empleado Empleado = APEmpleado.Empleado_Actualizar(empleado);
            return Json(Empleado);
        }
        [HttpPost]
        public JsonResult Empleado_Seleccionar_Id(Models.Empleado empleado, Application.Empleado APEmpleado)
        {
            Models.Empleado Empleado = APEmpleado.Empleado_Seleccionar_Id(empleado);
            return Json(Empleado);
        }
        [HttpPost]
        public JsonResult Empleado_Seleccionar_IdPersona(Models.Empleado empleado, Application.Empleado APEmpleado)
        {
            List<Models.Empleado> Empleados = APEmpleado.Empleado_Seleccionar_IdPersona(empleado);
            return Json(Empleados);
        }
        [HttpPost]
        public JsonResult Empleado_Seleccionar_IdEmpresa(Models.Empresa empresa, Application.Empleado APEmpleado)
        {
            List<Models.Empleado> Empleados = APEmpleado.Empleado_Seleccionar_IdEmpresa(empresa);
            return Json(Empleados);
        }
    }
}
