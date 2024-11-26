using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class CategoriasProductoController : Controller
    {
        [HttpPost]
        public JsonResult CategoriasProducto_Listar(Application.CatCategoriasProducto APcategoriasProducto)
        {
            List<Models.CatCategoriasProducto> LisCategoriasProducto = APcategoriasProducto.CatCategoriasProducto_Seleccionar();
            return Json(LisCategoriasProducto);
        }

        [HttpPost]
        public JsonResult CategoriasProducto_Agregar(Models.CatCategoriasProducto catCategoriasProducto, Application.CatCategoriasProducto APcatCategoriasProducto)
        {
            Models.CatCategoriasProducto DBCCategoriasProducto = APcatCategoriasProducto.CatCategoriasProducto_Agregar(catCategoriasProducto);
            return Json(DBCCategoriasProducto);
        }
    }
}
