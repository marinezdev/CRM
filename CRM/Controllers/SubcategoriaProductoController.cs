using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class SubcategoriaProductoController : Controller
    {
        [HttpPost]
        public JsonResult SubcategoriaProducto_Listar(Models.CatCategoriasProducto catCategoriasProducto ,Application.CatSubcategoriaProducto APcatSubcategoriaProducto)
        {
            List<Models.CatSubcategoriaProducto> LisSubcategoriaProducto = APcatSubcategoriaProducto.CatSubcategoriaProducto_Seleccionar(catCategoriasProducto);
            return Json(LisSubcategoriaProducto);
        }

        [HttpPost]
        public JsonResult SubcategoriaProducto_Agregar(Models.CatSubcategoriaProducto catSubcategoriaProducto, Application.CatSubcategoriaProducto APcatSubcategoriaProducto)
        {
            Models.CatSubcategoriaProducto DBSubcategoriaProducto = APcatSubcategoriaProducto.CatSubcategoriaProducto_Agregar(catSubcategoriaProducto);
            return Json(DBSubcategoriaProducto);
        }
    }
}
