using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class CargoController : Controller
    {
        [HttpPost]
        public JsonResult Cargo_Listar(Application.CatCargo APcatCargo)
        {
            List<Models.CatCargo> LisCargo = APcatCargo.CatCargo_Seleccionar();
            return Json(LisCargo);
        }

        [HttpPost]
        public JsonResult Cargo_Agregar(Models.CatCargo catCargo, Application.CatCargo APcatCargo)
        {
            Models.CatCargo DBCargo = APcatCargo.CatCargo_Agregar(catCargo);
            return Json(DBCargo);
        }
    }
}
