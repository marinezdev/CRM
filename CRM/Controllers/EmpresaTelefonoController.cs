using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class EmpresaTelefonoController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];

        [HttpPost]
        public JsonResult EmpresaTelefono_Agregar(Models.EmpresaTelefono empresaTelefono, Application.EmpresaTelefono APEmpresaTelefono)
        {
            empresaTelefono.Usuario = Usuario;
            Models.EmpresaTelefono dbEmpresaTelefono = APEmpresaTelefono.EmpresaTelefono_Agregar(empresaTelefono);
            return Json(dbEmpresaTelefono);
        }

        [HttpPost]
        public JsonResult EmpresaTelefono_Eliminar(Models.EmpresaTelefono empresaTelefono, Application.EmpresaTelefono APEmpresaTelefono)
        {
            empresaTelefono.Usuario = Usuario;
            Models.EmpresaTelefono dbEmpresaTelefono = APEmpresaTelefono.EmpresaTelefono_Eliminar(empresaTelefono);
            return Json(dbEmpresaTelefono);
        }

        [HttpPost]
        public JsonResult EmpresaTelefono_Actualizar(Models.EmpresaTelefono empresaTelefono, Application.EmpresaTelefono APEmpresaTelefono)
        {
            empresaTelefono.Usuario = Usuario;
            Models.EmpresaTelefono dbEmpresaTelefono = APEmpresaTelefono.EmpresaTelefono_Actualizar(empresaTelefono);
            return Json(dbEmpresaTelefono);
        }

        [HttpPost]
        public JsonResult EmpresaTelefono_Seleccionar_IdEmpresa(Models.Empresa empresa, Application.EmpresaTelefono APEmpresaTelefono)
        {
            List<Models.EmpresaTelefono> dbEmpresaTelefono = APEmpresaTelefono.EmpresaTelefono_Seleccionar_IdEmpresa(empresa);
            return Json(dbEmpresaTelefono);
        }
    }
}
