using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class ClasificacionProductoController : Controller
    {

        [HttpPost]
        public JsonResult ClasificacionProducto_Listar(Models.CatSubcategoriaProducto catSubcategoriaProducto, Application.CatClasificacionProducto APcatClasificacionProducto)
        {
            List<Models.CatClasificacionProducto> LisClasificacionProducto = APcatClasificacionProducto.CatClasificacionProducto_Listar(catSubcategoriaProducto);
            return Json(LisClasificacionProducto);
        }

        [HttpPost]
        public JsonResult ClasificacionProducto_Agregar(Models.CatClasificacionProducto catClasificacionProducto, Application.CatClasificacionProducto APcatClasificacionProducto)
        {
            Models.CatClasificacionProducto DBClasificacionProducto = APcatClasificacionProducto.CatClasificacionProducto_Agregar(catClasificacionProducto);
            return Json(DBClasificacionProducto);
        }
    }
}
