using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class TipoEmpresaController : Controller
    {
        [HttpPost]
        public JsonResult TipoEmpresa_Listar(Application.CatTipoEmpresa APcatTipoEmpresa)
        {
            List<Models.CatTipoEmpresa> LisTipoEmpresa = APcatTipoEmpresa.CatTipoEmpresa_Seleccionar();
            return Json(LisTipoEmpresa);
        }

        [HttpPost]
        public JsonResult TipoEmpresa_Agregar(Models.CatTipoEmpresa catTipoEmpresa, Application.CatTipoEmpresa APcatTipoEmpresa)
        {
            Models.CatTipoEmpresa DBTipoEmpresa = APcatTipoEmpresa.CatTipoEmpresa_Agregar(catTipoEmpresa);
            return Json(DBTipoEmpresa);
        }

    }
}
