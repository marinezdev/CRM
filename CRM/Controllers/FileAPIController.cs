using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CRM.Controllers
{
    public class FileAPIController : ApiController
    {
        [Route("api/FileAPI/UploadFilesImagen")]
        [HttpPost]
        public HttpResponseMessage UploadFilesImagen()
        {
            string DirectorioUsuario = HttpContext.Current.Server.MapPath("~") + "\\DocumentosTemporales\\";
            Application.ControlArchivo _ControlArchivo = new Application.ControlArchivo();
            Models.ProductoImagen productoImagen = new Models.ProductoImagen();

            for (int i = 0; i < HttpContext.Current.Request.Files.Count; i++)
            {
                HttpPostedFile POT = HttpContext.Current.Request.Files[i];
                productoImagen = _ControlArchivo.NuevaImagen(POT, DirectorioUsuario);
            }

            //Send OK Response to Client.
            return Request.CreateResponse(HttpStatusCode.OK, productoImagen);
        }

        [Route("api/FileAPI/UploadFileArchivo")]
        [HttpPost]
        public HttpResponseMessage UploadFileArchivo()
        {
            string DirectorioUsuario = HttpContext.Current.Server.MapPath("~") + "\\DocumentosTemporales\\";
            Application.ControlArchivo _ControlArchivo = new Application.ControlArchivo();
            Models.Archivo NuevoProducto = new Models.Archivo();

            for (int i = 0; i < HttpContext.Current.Request.Files.Count; i++)
            {
                HttpPostedFile POT = HttpContext.Current.Request.Files[i];
                NuevoProducto = _ControlArchivo.NuevoArchivo(POT, DirectorioUsuario);
            }
            //Send OK Response to Client.
            return Request.CreateResponse(HttpStatusCode.OK, NuevoProducto);
        }
    }
}
