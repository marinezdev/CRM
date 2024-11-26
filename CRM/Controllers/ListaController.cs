using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class ListaController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];

        public ActionResult AdminList()
        {
            return View();
        }



        [HttpPost]
        public JsonResult Lista_Read(Application.Lista APPlist, Models.Lista lista)
        {
            lista.Usuario = Usuario;
            List<Models.Lista> R = APPlist.Lista_Read(lista);
            return Json(R);
        }
        [HttpPost]
        public JsonResult Lista_Read_IdUser(Application.Lista APPlist,Models.Lista lista)
        {
            lista.Usuario = Usuario;
            List<Models.Lista> R = APPlist.Lista_Read_IdUser(lista);
            return Json(R);
        }
        [HttpPost]
        public JsonResult Lista_Read_User(Application.Lista APPlist, Models.Lista lista)
        {
            List<Models.Contacto> R = APPlist.Lista_Read_User(lista);
            return Json(R);
        }
        [HttpPost]
        public JsonResult Lista_Insert(Application.Lista APPlist, Models.Lista lista)
        {
            lista.Usuario = Usuario;
            Models.Contacto R = APPlist.Lista_Insert(lista);
            return Json(R);
        }
        [HttpPost]
        public JsonResult Lista_Read_IdList(Application.Lista APPlist, Models.Lista lista)
        {
            List<Models.Contacto> R = APPlist.Lista_Read_IdList(lista);
            return Json(R);
        }
        [HttpPost]
        public JsonResult Lista_Insert_User(Application.Lista APPlist, Models.Lista lista)
        {
            List<Models.Lista> respuestas = new List<Models.Lista>();

            var usuarios = lista.Contacto.IdContacto;

            foreach (var usuario in usuarios)
            {
                var parametros = new Models.Lista();
                parametros.Contacto = new Models.Contacto();
                parametros.Contacto.Id = usuario;
                parametros.Id = lista.Id;

                Models.Lista R = APPlist.Lista_Insert_User(parametros);
                respuestas.Add(R);
            }

            return Json(respuestas);
        }
        [HttpPost]
        public JsonResult ListaContacto_Eliminar_IdContacto(Application.Lista APPlist, Models.Lista lista)
        {
            //lista.Usuario = Usuario;
            Models.Contacto R = APPlist.ListaContacto_Eliminar_IdContacto(lista);
            return Json(R);
        }

        [HttpPost]
        public JsonResult Lista_Import(Application.Lista APPlist, Models.Lista lista)
        {
            lista.Usuario = Usuario;
            Models.Contacto R = APPlist.Lista_Import(lista);
            return Json(R);
        }

        [HttpPost]
        public JsonResult Lista_Delete(Application.Lista APPlist, Models.Lista lista)
        {
            //lista.Usuario = Usuario;
            Models.Contacto R = APPlist.Lista_Delete(lista);
            return Json(R);
        }
        [HttpPost]
        public JsonResult Lista_Update(Application.Lista APPlist, Models.Lista lista)
        {
            //lista.Usuario = Usuario;
            Models.Contacto R = APPlist.Lista_Update(lista);
            return Json(R);
        }
    }
}