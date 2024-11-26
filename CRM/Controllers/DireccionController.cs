using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class DireccionController : Controller
    {
        [HttpPost]
        public JsonResult CatEstados_Seleccionar(Application.CatEstados APCatEstados)
        {
            List<Models.CatEstados> DBCatEstados = APCatEstados.CatEstados_Seleccionar();
            return Json(DBCatEstados);
        }

        [HttpPost]
        public JsonResult CatPoblaciones_Seleccionar_IdEstado(Models.CatEstados catEstados, Application.CatPoblaciones APCatPoblaciones)
        {
            List<Models.CatPoblaciones> DBCatPoblaciones = APCatPoblaciones.CatPoblaciones_Seleccionar_IdEstado(catEstados);
            return Json(DBCatPoblaciones);
        }

        [HttpPost]
        public JsonResult CatColonias_Seleccionar_IdPoblacion(Models.CatPoblaciones catPoblaciones, Application.CatColonias APCatColonias)
        {
            List<Models.CatColonias> DBCatColonias = APCatColonias.CatColonias_Seleccionar_IdPoblacion(catPoblaciones);
            return Json(DBCatColonias);
        }

        [HttpPost]
        public JsonResult CatCP_Seleccionar_IdColonia(Models.CatColonias catColonias, Application.CatCP APCatCP)
        {
            List<Models.CatCp> DBCatCp = APCatCP.CatCP_Seleccionar_IdColonia(catColonias);
            return Json(DBCatCp);
        }

        [HttpPost]
        public JsonResult CatCP_Busqueda(Models.CatCp catCp, Application.CatCP APCatCP)
        {
            List<Models.Consulta.CatCP_Busqueda> DBCatCp = APCatCP.CatCP_Busqueda(catCp);
            return Json(DBCatCp);
        }

        

    }
}
