using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class ProductoController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        string cadena = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        Models.MenuPermiso menuPermiso = new Models.MenuPermiso();
        Models.Menu Menu = new Models.Menu();

        // GET: Oportunidad
        public ActionResult Index(Application.CatProducto APcatProducto)
        {
            if (ValidaUsuario())
            {
                List<Models.CatProducto> ListProducto = APcatProducto.CatProducto_Seleccionar_Producto();
                List<Models.CatProducto> ListMisProducto = APcatProducto.CatProducto_Seleccionar_Producto_IdUsaurio(Usuario);
                ViewBag.Productos = ListProducto;
                ViewBag.MisProductos = ListMisProducto;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        public ActionResult Crear(Application.CatCategoriasProducto APcatCategoriasProducto, Application.CatMoneda APcatMoneda)
        {
            if (ValidaUsuario())
            {
                List<Models.CatCategoriasProducto> CategoriasProducto = APcatCategoriasProducto.CatCategoriasProducto_Seleccionar();
                List<Models.CatMoneda> Moneda = APcatMoneda.CatMoneda_Seleccionar();

                ViewBag.CategoriasProducto = CategoriasProducto;
                ViewBag.Moneda = Moneda;
                Session["ProductoIMG"] = null;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        public ActionResult Editar(Application.CatCategoriasProducto APcatCategoriasProducto, Application.CatProducto APcatProducto)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    int IdProducto = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));
                    string DirectorioURL = System.Web.HttpContext.Current.Request.Url.Authority + "\\DocumentosTemporales\\";
                    Models.CatProducto _producto = new Models.CatProducto();
                    _producto.Id = IdProducto;
                    List<Models.CatCategoriasProducto> CategoriasProducto = APcatCategoriasProducto.CatCategoriasProducto_Seleccionar();
                    List<Models.CatProducto> Productos = APcatProducto.CatProducto_Seleccionar();
                    Models.CatProducto producto = APcatProducto.CatProducto_Seleccionar_IdProducto(_producto);
                    producto.ProductoImagen.NmOriginal = DirectorioURL + producto.ProductoImagen.NmArchivo;
                    
                    ViewBag.CategoriasProducto = CategoriasProducto;
                    ViewBag.Productos = Productos;
                    ViewBag.Producto = producto;
                    Session["ProductoIMG"] = null;

                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Producto");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        [HttpPost]
        public JsonResult Producto_Listar(Application.CatProducto APcatProducto)
        {
            List<Models.CatProducto> LisCatProducto = APcatProducto.CatProducto_Seleccionar();
            return Json(LisCatProducto);
        }
        [HttpPost]
        public JsonResult Producto_Listar_Clasificacion(Models.CatClasificacionProducto catClasificacionProducto,Application.CatProducto APcatProducto)
        {
            List<Models.CatProducto> LisCatProducto = APcatProducto.CatProducto_Seleccionar_IdClasificacion(catClasificacionProducto);
            return Json(LisCatProducto);
        }
        [HttpPost]
        public JsonResult Producto_Agregar(Models.CatProducto catProducto, Application.CatProducto APcatProducto, Application.ProductoImagen APproductoImagen)
        {
            catProducto.Usuario = Usuario;
            Models.CatProducto DBCatProducto = APcatProducto.CatProducto_Agregar(catProducto);
            Models.ProductoImagen productoImagen = new Models.ProductoImagen();

            if (DBCatProducto.Id > 0)
            {
                if (Session["ProductoIMG"] != null)
                {
                    productoImagen = (Models.ProductoImagen)Session["ProductoIMG"];
                    productoImagen.CatProducto = DBCatProducto;
                    APproductoImagen.ProductoImagen_Agregar(productoImagen);
                    Session["ProductoIMG"] = null;
                }
                else
                {
                    Models.ProductoImagen _productoImagen = new Models.ProductoImagen();
                    _productoImagen.CatProducto = DBCatProducto;
                    _productoImagen.NmArchivo = "Default.png";
                    _productoImagen.NmOriginal = "Default.png";
                    _productoImagen.ImagenURL = "";
                    APproductoImagen.ProductoImagen_Agregar(_productoImagen);
                }
            }
            

            return Json(DBCatProducto);
        }
        [HttpPost]
        public JsonResult Producto_Editar(Models.CatProducto catProducto, Application.CatProducto APcatProducto, Application.ProductoImagen APproductoImagen)
        {
            catProducto.Usuario = Usuario;
            Models.CatProducto DBCatProducto = APcatProducto.CatProducto_Editar(catProducto);
            Models.ProductoImagen productoImagen = new Models.ProductoImagen();

            if (DBCatProducto.Id > 0)
            {
                if (Session["ProductoIMG"] != null)
                {
                    productoImagen = (Models.ProductoImagen)Session["ProductoIMG"];
                    productoImagen.CatProducto = DBCatProducto;
                    APproductoImagen.ProductoImagen_Agregar(productoImagen);
                    Session["ProductoIMG"] = null;
                }
            }
            return Json(DBCatProducto);
        }
        [HttpPost]
        public JsonResult Producto_Eliminar(Models.CatProducto catProducto, Application.CatProducto APcatProducto)
        {
            catProducto.Usuario = Usuario;
            Models.CatProducto DBCatProducto = APcatProducto.CatProducto_Eliminar(catProducto);
            return Json(DBCatProducto);
        }
        [HttpPost]
        public JsonResult Producto_AgregarImagen(Models.ProductoImagen productoImagen)
        {
            string DirectorioURL = System.Web.HttpContext.Current.Request.Url.Authority + "\\DocumentosTemporales\\";
            Models.ProductoImagen _ProductoImagen = new Models.ProductoImagen();
            string IMG = "";
            _ProductoImagen = productoImagen;
            _ProductoImagen.NmArchivo = productoImagen.NmArchivo;
            Session["ProductoIMG"] = _ProductoImagen;
            IMG = DirectorioURL + _ProductoImagen.NmArchivo;
            return Json(IMG);
        }
        [HttpPost]
        public JsonResult Producto_EliminarImagen()
        {
            Session["ProductoIMG"] = null;
            return Json(1);
        }
        [HttpPost]
        public JsonResult Producto_Seleccionar_IdProducto(Models.CatProducto catProducto, Application.CatProducto APcatProducto)
        {
            Models.CatProducto DBProducto = APcatProducto.CatProducto_Seleccionar_IdProducto(catProducto);
            return Json(DBProducto);
        }
        public bool ValidaUsuario()
        {
            bool result = false;
            Application.Menu APmenu = new Application.Menu();

            try
            {
                menuPermiso.Rol = Usuario.Rol;
                Menu.URL = url;
                menuPermiso.Menu = Menu;
                if (APmenu.ValidacionPagina(menuPermiso))
                {
                    result = true;
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}
