using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class TestWhatsappController : Controller
    {
        // GET: TestWhatsapp
        public ActionResult Index(Application.TestWhatsapp testWhatsapp)
        {
            _ = testWhatsapp.EnviarImagenAsync();
            return View();
        }
    }
}
