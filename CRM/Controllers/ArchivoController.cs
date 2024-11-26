using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class ArchivoController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];

        [HttpPost]
        public JsonResult Archivo_Agregar(Models.ArchivoEntidad archivoEntidad, Application.Archivo APArchivo)
        {
            archivoEntidad.Archivo.Usuario = Usuario;
            Models.Archivo dbArchivo = APArchivo.Archivo_Agregar(archivoEntidad);
            return Json(dbArchivo);
        }
        [HttpPost]
        public JsonResult Archivo_Eliminar(Models.Archivo archivo, Application.Archivo APArchivo)
        {
            Models.Archivo dbArchivo = APArchivo.Archivo_Eliminar(archivo);
            return Json(dbArchivo);
        }
        [HttpPost]
        public JsonResult Archivo_Seleccionar_Id(Models.Archivo archivo, Application.Archivo APArchivo)
        {
            string DirectorioURL = System.Web.HttpContext.Current.Request.Url.Authority + "\\DocumentosTemporales\\";
            Models.Archivo dbArchivo = APArchivo.Archivo_Seleccionar_Id(archivo);
            dbArchivo.NombreNuevo = DirectorioURL + dbArchivo.NombreNuevo;
            return Json(dbArchivo);
        }
        [HttpPost]
        public JsonResult Archivo_Seleccionar_Entidad_Valor(Models.ArchivoEntidad archivoEntidad, Application.Archivo APArchivo)
        {
            List<Models.Archivo> dbArchivo = APArchivo.Archivo_Seleccionar_Entidad_Valor(archivoEntidad);
            return Json(dbArchivo);
        }
    }
}
