using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class TelefonoController : Controller
    {
        [HttpPost]
        public JsonResult CatTipoTelefono_Agregar(Models.CatTipoTelefono catTipoTelefono, Application.CatTipoTelefono APcatTipoTelefono)
        {
            Models.CatTipoTelefono dbCatTipoTelefono = APcatTipoTelefono.CatTipoTelefono_Agregar(catTipoTelefono);
            return Json(dbCatTipoTelefono);
        }

        [HttpPost]
        public JsonResult CatTipoTelefono_Seleccionar(Application.CatTipoTelefono APcatTipoTelefono)
        {
            List<Models.CatTipoTelefono> dbCatTipoTelefono = APcatTipoTelefono.CatTipoTelefono_Seleccionar();
            return Json(dbCatTipoTelefono);
        }
    }
}
