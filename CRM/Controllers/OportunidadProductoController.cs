using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class OportunidadProductoController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];

        [HttpPost]
        public JsonResult OportunidadProducto_Sesion_Agregar(Models.OportunidadProducto oportunidadProducto, Application.CatProducto APCatProducto)
        {
            List<Models.OportunidadProducto> LstOportunidadProducto = new List<Models.OportunidadProducto>();
            Models.CatProducto _CatProductos = new Models.CatProducto();
            string DirectorioURL = System.Web.HttpContext.Current.Request.Url.Authority + "\\DocumentosTemporales\\";

            if (Session["ListaProductos"] != null)
            {
                LstOportunidadProducto = (List<Models.OportunidadProducto>)Session["ListaProductos"];
            }

            bool Agregar = false;
            for (int i = 0; i < LstOportunidadProducto.Count; i++)
            {
                if (LstOportunidadProducto[i].CatProducto.Id == oportunidadProducto.CatProducto.Id)
                {
                    Agregar = true;
                }
            }

            if (!Agregar)
            {
                _CatProductos = APCatProducto.CatProducto_Seleccionar_IdProducto(oportunidadProducto.CatProducto);

                _CatProductos.ProductoImagen.ImagenURL = DirectorioURL + _CatProductos.ProductoImagen.NmArchivo;
                oportunidadProducto.CatProducto = _CatProductos;
                LstOportunidadProducto.Add(oportunidadProducto);
            }

            LstOportunidadProducto.Sort((x, y) => string.Compare(x.CatProducto.Nombre, y.CatProducto.Nombre));
            Session["ListaProductos"] = LstOportunidadProducto;
            return Json(LstOportunidadProducto);
        }

        [HttpPost]
        public JsonResult OportunidadProducto_Sesion_Eliminar(Models.OportunidadProducto oportunidadProducto)
        {
            List<Models.OportunidadProducto> LstOportunidadProducto = new List<Models.OportunidadProducto>();
            Models.CatProducto _CatProductos = new Models.CatProducto();

            if (Session["ListaProductos"] != null)
            {
                LstOportunidadProducto = (List<Models.OportunidadProducto>)Session["ListaProductos"];
            }

            for (int i = 0; i < LstOportunidadProducto.Count; i++)
            {
                if (LstOportunidadProducto[i].CatProducto.Id == oportunidadProducto.CatProducto.Id)
                {
                    LstOportunidadProducto.Remove(LstOportunidadProducto[i]);
                }
            }

            LstOportunidadProducto.Sort((x, y) => string.Compare(x.CatProducto.Nombre, y.CatProducto.Nombre));
            Session["ListaProductos"] = LstOportunidadProducto;
            return Json(LstOportunidadProducto);
        }

        [HttpPost]
        public JsonResult OportunidadProducto_Consultar( Application.CatProducto APCatProducto)
        {
            List<Models.OportunidadProducto> LstOportunidadProducto = new List<Models.OportunidadProducto>();
            Models.CatProducto _CatProductos = new Models.CatProducto();
            string DirectorioURL = System.Web.HttpContext.Current.Request.Url.Authority + "\\DocumentosTemporales\\";

            if (Session["ListaProductos"] != null)
            {
                LstOportunidadProducto = (List<Models.OportunidadProducto>)Session["ListaProductos"];
            }

            LstOportunidadProducto.Sort((x, y) => string.Compare(x.CatProducto.Nombre, y.CatProducto.Nombre));
            Session["ListaProductos"] = LstOportunidadProducto;
            return Json(LstOportunidadProducto);
        }

        [HttpPost]
        public JsonResult OportunidadProducto_Selecionar_OportunidadProducto(Models.OportunidadProducto oportunidadProducto, Application.OportunidadProducto APoportunidadProducto)
        {
            Models.OportunidadProducto dbOportunidadProducto = APoportunidadProducto.OportunidadProducto_Selecionar_OportunidadProducto(oportunidadProducto);
            
            return Json(dbOportunidadProducto);
        }

        [HttpPost]
        public JsonResult OportunidadProducto_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad, Application.OportunidadProducto APoportunidadProducto)
        {
            List<Models.OportunidadProducto> dbOportunidadProducto = APoportunidadProducto.OportunidadProducto_Seleccionar_IdOportunidad(oportunidad);

            return Json(dbOportunidadProducto);
        }

        [HttpPost]
        public JsonResult OportunidadProducto_Eliminar(Models.OportunidadProducto oportunidadProducto, Application.OportunidadProducto APoportunidadProducto)
        {
            oportunidadProducto.Usuario = Usuario;
            Models.OportunidadProducto dbOportunidadProducto = APoportunidadProducto.OportunidadProducto_Eliminar(oportunidadProducto);
            return Json(dbOportunidadProducto);
        }
        

        [HttpPost]
        public JsonResult OportunidadProducto_Agregar(Models.Oportunidad oportunidad, Application.OportunidadProducto APoportunidadProducto, Application.OportunidadBitacora APoportunidadBitacora)
        {
            List<Models.OportunidadProducto> LstOportunidadProducto = new List<Models.OportunidadProducto>();
            Models.OportunidadBitacora oportunidadBitacora = new Models.OportunidadBitacora();

            if (Session["ListaProductos"] != null)
            {
                LstOportunidadProducto = (List<Models.OportunidadProducto>)Session["ListaProductos"];
            }

            foreach (var OportunidadProducto in LstOportunidadProducto)
            {
                OportunidadProducto.Oportunidad = oportunidad;
                OportunidadProducto.Usuario = Usuario;
                
                APoportunidadProducto.OportunidadProducto_Agregar(OportunidadProducto);
            }

            if (LstOportunidadProducto.Count > 0)
            {
                oportunidadBitacora.Oportunidad = oportunidad;
                oportunidadBitacora.Usuario = Usuario;
                if (LstOportunidadProducto.Count == 1)
                {
                    oportunidadBitacora.Operacion = "Nuevo producto";
                    oportunidadBitacora.Nota = "agrego un <strong> nuevo produto </strong> a la oportunidad";
                }
                else
                {
                    oportunidadBitacora.Operacion = "Nuevos productos";
                    oportunidadBitacora.Nota = "agrego <strong>" + LstOportunidadProducto.Count + " </strong> nuevos productos a la oportunidad";
                } 
            }
            oportunidadBitacora = APoportunidadBitacora.OportunidadBitacora_Agregar(oportunidadBitacora);

            return Json(oportunidadBitacora);
        }
    }
}
