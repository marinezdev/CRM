using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class OportunidadController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        string cadena = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        Models.MenuPermiso menuPermiso = new Models.MenuPermiso();
        Models.Menu Menu = new Models.Menu();

        // GET: Oportunidad
        public ActionResult Index(Application.Oportunidad APoportunidad)
        {
            if (ValidaUsuario())
            {
                List<Models.Oportunidad> ListOportunidades = APoportunidad.Oportunidad_Seleccionar();
                List<Models.Oportunidad> ListOportunidadesUsuario = APoportunidad.Oportunidad_Seleccionar_IdUsuario(Usuario);
                List<Models.Oportunidad> ListOportunidadesUsuarioYear = APoportunidad.Oportunidad_Seleccionar_IdUsuario_Year(Usuario);

                ViewBag.Oportunidad = ListOportunidades;
                ViewBag.OportunidadUsuario = ListOportunidadesUsuario;
                ViewBag.OportunidadUsuarioYear = ListOportunidadesUsuarioYear;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        public ActionResult OportunidadesYear(Application.Oportunidad APoportunidad)
        {
            if (ValidaUsuario())
            {
                List<Models.Oportunidad> ListOportunidades = APoportunidad.Oportunidad_Seleccionar_Year();

                ViewBag.Oportunidad = ListOportunidades;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        public ActionResult Estatus(Application.Oportunidad APoportunidad)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    int IdEstatus = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));
                    Models.CatEstatusOpurtunidad catEstatusOpurtunidad = new Models.CatEstatusOpurtunidad();
                    catEstatusOpurtunidad.Id = IdEstatus;
                    List<Models.Oportunidad> ListOportunidades = APoportunidad.Oportunidad_Seleccionar_IdEstatus(catEstatusOpurtunidad);

                    ViewBag.Oportunidad = ListOportunidades;
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Oportunidad");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        public ActionResult UnidadNegocio(Application.Oportunidad APoportunidad)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    int IdUnidadNegocio = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));
                    Models.CatUnidadNegocio catUnidadNegocio = new Models.CatUnidadNegocio();
                    catUnidadNegocio.Id = IdUnidadNegocio;
                    List<Models.Oportunidad> ListOportunidades = APoportunidad.Oportunidad_Seleccionar_IdUnidadNegocio(catUnidadNegocio);

                    ViewBag.Oportunidad = ListOportunidades;
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Oportunidad");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        public ActionResult Etapa(Application.Oportunidad APoportunidad)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    int IdEtapa = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));
                    Models.CatEtapaOportunidad catEtapaOportunidad = new Models.CatEtapaOportunidad();
                    catEtapaOportunidad.Id = IdEtapa;
                    List<Models.Oportunidad> ListOportunidades = APoportunidad.Oportunidad_Seleccionar_IdEtapa(catEtapaOportunidad);

                    ViewBag.Oportunidad = ListOportunidades;
                    return View();
                }
                else
                {
                    return RedirectToAction("VentasUnidadNegocio", "Administracion");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        public ActionResult EtapaUnidadNegocio(Application.Oportunidad APoportunidad)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    if (!String.IsNullOrEmpty(Request.QueryString["unid"]))
                    {
                        int IdEtapa = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));
                        int IdUnidadNegocio = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["unid"]));
                        Models.CatEtapaOportunidad catEtapaOportunidad = new Models.CatEtapaOportunidad();
                        catEtapaOportunidad.Id = IdEtapa;
                        Models.CatUnidadNegocio catUnidadNegocio = new Models.CatUnidadNegocio();
                        catUnidadNegocio.Id = IdUnidadNegocio;
                        List<Models.Oportunidad> ListOportunidades = APoportunidad.Oportunidad_Seleccionar_IdEtapa_IdUnidadNegocio(catEtapaOportunidad, catUnidadNegocio);

                        ViewBag.Oportunidad = ListOportunidades;
                        return View();
                    }
                    else
                    {
                        return RedirectToAction("VentasUnidadNegocio", "Administracion");
                    }
                }
                else
                {
                    return RedirectToAction("VentasUnidadNegocio", "Administracion");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        // GET: Oportunidad/Create
        public ActionResult Crear(Application.CatUnidadNegocio APcatUnidadNegocio, Application.Usuario APusuario, Application.CatTipoOportunidad APcatTipoOportunidad, Application.CatPrioridad APcatPrioridad, Application.CatEstatusOpurtunidad APcatEstatusOpurtunidad, Application.Contacto APcontacto, Application.Empresa APEmpresa,
            Application.CatMoneda APcatMoneda, Application.CatCategoriasProducto APcatCategoriasProducto, Application.CatProducto APcatProducto, Application.CatPersonaOportunidad APcatPersonaOportunidad)
        {
            if (ValidaUsuario())
            {
                List<Models.CatUnidadNegocio> catUnidadNegocio = APcatUnidadNegocio.CatUnidadNegocio_Seleccionar();
                List<Models.Usuario> usuarios = APusuario.Usuario_Propietario_Seleccionar();
                List<Models.CatTipoOportunidad> catTipoOportunidades = APcatTipoOportunidad.CatTipoOportunidad_Seleccionar();
                List<Models.CatPrioridad> catPrioridad = APcatPrioridad.CatPrioridad_Seleccionar();
                List<Models.CatEstatusOpurtunidad> catEstatusOpurtunidads = APcatEstatusOpurtunidad.CatEstatusOpurtunidad_Seleccionar();
                List<Models.Contacto> Contactos = APcontacto.Contacto_Seleccionar_Email();
                List<Models.Empresa> Empresas = APEmpresa.Empresa_Seleccionar_Oportunidad();
                List<Models.CatMoneda> Moneda = APcatMoneda.CatMoneda_Seleccionar();
                List<Models.CatCategoriasProducto> CategoriasProducto = APcatCategoriasProducto.CatCategoriasProducto_Seleccionar();
                List<Models.CatProducto> Productos = APcatProducto.CatProducto_Seleccionar();
                List<Models.CatPersonaOportunidad> PersonaOportunidad = APcatPersonaOportunidad.CatPersonaOportunidad_Seleccionar();
                
                ViewBag.Usuarios = usuarios;
                ViewBag.UnidadNegocio = catUnidadNegocio;
                ViewBag.TipoOportunidades = catTipoOportunidades;
                ViewBag.Prioridad = catPrioridad;
                ViewBag.EstatusOpurtunidad = catEstatusOpurtunidads;
                ViewBag.Contactos = Contactos;
                ViewBag.Empresas = Empresas;
                ViewBag.Moneda = Moneda;
                ViewBag.CategoriasProducto = CategoriasProducto;
                ViewBag.Productos = Productos;
                ViewBag.PersonaOportunidad = PersonaOportunidad;

                Session["ListaProductos"] = null;
                Session["ProductoIMG"] = null;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
        }
        // GET: Oportunidad
        public ActionResult Oportunidad(Application.OportunidadBitacora APoportunidadBitacora, Application.Oportunidad APoportunidad, Application.Contacto APcontacto, Application.CatPersonaOportunidad APcatPersonaOportunidad, Application.Empresa APEmpresa,
            Application.CatProducto APcatProducto, Application.CatCategoriasProducto APcatCategoriasProducto, Application.CatMoneda APcatMoneda, Application.CatEstatusOpurtunidad APcatEstatusOpurtunidad, Application.Usuario APusuario, Application.CatPrioridad APcatPrioridad,
            Application.CatTipoTarea APcatTipoTarea, Application.CatRecordatorio APcatRecordatorio, Application.CatFechaVencimiento APcatFechaVencimiento, Application.Tarea APtarea, Application.Nota APnota, Application.CatDireccionLlamada APcatDireccionLlamada, Application.CatResultadoLlamada APcatResultadoLlamada,
            Application.CatResultadoReunion APcatResultadoReunion, Application.CatDuracionReunion APcatDuracionReunion, Application.CatTipoReunion APcatTipoReunion, Application.CatTipoMensaje APcatTipoMensaje, Application.Correo APcorreo, Application.Llamada APLlamada, Application.Reunion APReunion, Application.Mensaje APmensaje,
            Application.CatUnidadNegocio APcatUnidadNegocio, Application.CatTipoOportunidad APcatTipoOportunidad)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    int IdOportunidad = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));
                    
                    Models.Oportunidad oportunidad = new Models.Oportunidad();
                    oportunidad.Id = IdOportunidad;
                    Models.CatEntidad catEntidad = new Models.CatEntidad();
                    catEntidad.Id = 3;
                    
                    Models.TareaEntidad tareaEntidad = new Models.TareaEntidad();
                    tareaEntidad.CatEntidad = catEntidad;
                    tareaEntidad.IdValorEntidad = IdOportunidad;
                    
                    Models.CorreoEntidad correoEntidad = new Models.CorreoEntidad();
                    correoEntidad.CatEntidad = catEntidad;
                    correoEntidad.IdValorEntidad = IdOportunidad;

                    Models.LlamadaEntidad llamadaEntidad = new Models.LlamadaEntidad();
                    llamadaEntidad.CatEntidad = catEntidad;
                    llamadaEntidad.IdValorEntidad = IdOportunidad;

                    Models.ReunionEntidad reunionEntidad = new Models.ReunionEntidad();
                    reunionEntidad.CatEntidad = catEntidad;
                    reunionEntidad.IdValorEntidad = IdOportunidad;

                    Models.MensajeEntidad mensajeEntidad = new Models.MensajeEntidad();
                    mensajeEntidad.CatEntidad = catEntidad;
                    mensajeEntidad.IdValorEntidad = IdOportunidad;

                    Models.Tarea tarea = new Models.Tarea();
                    tarea.Usuario = Usuario;
                    Models.Consulta.NuevaTarea nuevaTarea = new Models.Consulta.NuevaTarea();
                    nuevaTarea.Tarea = tarea;
                    nuevaTarea.TareaEntidad = tareaEntidad;

                    Models.NotaEntidad notaEntidad = new Models.NotaEntidad();
                    notaEntidad.CatEntidad = catEntidad;
                    notaEntidad.IdValorEntidad = IdOportunidad;

                    List<Models.OportunidadBitacora> DBOportunidadBitacora = APoportunidadBitacora.OportunidadBitacora_Seleccionar(oportunidad);
                    Models.Consulta.Oportunidad DBoportunidads = APoportunidad.Oportunidad_Seleccionar_Id(oportunidad);
                    List<Models.Contacto> Contactos = APcontacto.Contacto_Seleccionar_Email();
                    List<Models.CatPersonaOportunidad> PersonaOportunidad = APcatPersonaOportunidad.CatPersonaOportunidad_Seleccionar();
                    List<Models.Empresa> dbEmpresas = APEmpresa.Empresa_Seleccionar_Oportunidad();
                    List<Models.CatProducto> Productos = APcatProducto.CatProducto_Seleccionar();
                    List<Models.CatCategoriasProducto> CategoriasProducto = APcatCategoriasProducto.CatCategoriasProducto_Seleccionar();
                    List<Models.CatMoneda> Moneda = APcatMoneda.CatMoneda_Seleccionar();
                    List<Models.CatEstatusOpurtunidad> catEstatusOpurtunidads = APcatEstatusOpurtunidad.CatEstatusOpurtunidad_Seleccionar();
                    List<Models.Usuario> usuarios = APusuario.Usuario_Propietario_Seleccionar();
                    List<Models.CatPrioridad> catPrioridad = APcatPrioridad.CatPrioridad_Seleccionar();
                    List<Models.CatTipoTarea> catTipoTarea = APcatTipoTarea.CatTipoTarea_Seleccionar();
                    List<Models.CatRecordatorio> catRecordatorio = APcatRecordatorio.CatRecordatorio_Seleccionar();
                    List<Models.CatFechaVencimiento> catFechaVencimiento = APcatFechaVencimiento.CatFechaVencimiento_Seleccionar();
                    List<Models.Consulta.NuevaTarea> DBTareas = APtarea.Tarea_Seleccionar_Entidad_Valor(tareaEntidad);
                    List<Models.Consulta.NuevaTarea> dbUsuarioTarea = APtarea.Tarea_Seleccionar_Usuairo_Entidad(nuevaTarea);
                    List<Models.Nota> dbnotas = APnota.Nota_Seleccionar_Entidad_Valor(notaEntidad);
                    List<Models.CatDireccionLlamada> dbDireccionLlamada = APcatDireccionLlamada.CatDireccionLlamada_Seleccionar();
                    List<Models.CatResultadoLlamada> dbDResultadoLlamada = APcatResultadoLlamada.CatResultadoLlamada_Seleccionar();
                    List<Models.CatResultadoReunion> dbResultadoReunion = APcatResultadoReunion.CatResultadoReunion_Seleccionar();
                    List<Models.CatDuracionReunion> dbDuracionReunion = APcatDuracionReunion.CatDuracionReunion_Seleccionar();
                    List<Models.CatTipoReunion> dbTipoReunion = APcatTipoReunion.CatTipoReunion_Seleccionar();
                    List<Models.CatTipoMensaje> dbTipoMensaje = APcatTipoMensaje.CatTipoMensaje_Seleccionar();
                    List<Models.Consulta.NuevoCorreo> DBCorreos = APcorreo.Correo_Seleccionar_Entidad_Valor(correoEntidad);
                    List<Models.Consulta.NuevaLlamada> DBLlamadas = APLlamada.Llamada_Seleccionar_Entidad_Valor(llamadaEntidad);
                    List<Models.Consulta.NuevaReunion> DBReuniones = APReunion.Reunion_Seleccionar_Entidad_Valor(reunionEntidad);
                    List<Models.Consulta.NuevoMensaje> DBMensajes = APmensaje.Mensaje_Seleccionar_Entidad_Valor(mensajeEntidad);

                    List<Models.CatUnidadNegocio> catUnidadNegocio = APcatUnidadNegocio.CatUnidadNegocio_Seleccionar();
                    List<Models.CatTipoOportunidad> catTipoOportunidades = APcatTipoOportunidad.CatTipoOportunidad_Seleccionar();


                    ViewBag.Moneda = Moneda;

                    ViewBag.PersonaOportunidad = PersonaOportunidad;
                    ViewBag.Contactos = Contactos;
                    ViewBag.OportunidadBitacora = DBOportunidadBitacora;
                    ViewBag.Oportunidad = DBoportunidads;
                    ViewBag.Empresas = dbEmpresas;

                    ViewBag.CategoriasProducto = CategoriasProducto;
                    ViewBag.Productos = Productos;
                    ViewBag.EstatusOpurtunidad = catEstatusOpurtunidads;
                    ViewBag.Usuarios = usuarios;
                    ViewBag.Prioridad = catPrioridad;
                    ViewBag.TipoTarea = catTipoTarea;
                    ViewBag.Recordatorio = catRecordatorio;
                    ViewBag.FechaVencimiento = catFechaVencimiento;

                    ViewBag.BitaoraTareas = DBTareas;
                    ViewBag.UsuarioTarea = dbUsuarioTarea;
                    ViewBag.Notas = dbnotas;
                    ViewBag.Correos = DBCorreos;
                    ViewBag.Llamadas = DBLlamadas;
                    ViewBag.Reuniones = DBReuniones;
                    ViewBag.Mensajes = DBMensajes;

                    ViewBag.DireccionLlamada = dbDireccionLlamada;
                    ViewBag.ResultadoLlamada = dbDResultadoLlamada;

                    ViewBag.ResultadoReunion = dbResultadoReunion;
                    ViewBag.DuracionReunion = dbDuracionReunion;
                    ViewBag.TipoReunion = dbTipoReunion;
                    ViewBag.TipoMensaje = dbTipoMensaje;


                    ViewBag.UnidadNegocio = catUnidadNegocio;
                    ViewBag.TipoOportunidades = catTipoOportunidades;
                    
                    Session["ListaProductos"] = null;
                    Session["ProductoIMG"] = null;

                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Oportunidad");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        [HttpPost]
        public JsonResult Oportunidad_Agregar(Models.Consulta.Oportunidad oportunidad, Application.Oportunidad APOportunidad, Application.OportunidadProducto APoportunidadProducto, Application.OportunidadBitacora APoportunidadBitacora)
        {
            List<Models.OportunidadProducto> LstOportunidadProducto = new List<Models.OportunidadProducto>();
            Models.OportunidadBitacora oportunidadBitacora = new Models.OportunidadBitacora();
            Models.Oportunidad dboportunidad = new Models.Oportunidad();
            
            Models.Oportunidad DBOportunidad = APOportunidad.Oportunidad_Agregar(oportunidad);
            dboportunidad = DBOportunidad;

            if (Session["ListaProductos"] != null)
            {
                LstOportunidadProducto = (List<Models.OportunidadProducto>)Session["ListaProductos"];
            }

            foreach (var OportunidadProducto in LstOportunidadProducto)
            {
                OportunidadProducto.Oportunidad = dboportunidad;
                OportunidadProducto.Usuario = Usuario;

                APoportunidadProducto.OportunidadProducto_Agregar(OportunidadProducto);
            }

            if (LstOportunidadProducto.Count > 0)
            {
                oportunidadBitacora.Oportunidad = dboportunidad;
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
            if (LstOportunidadProducto.Count > 0)
            {
                oportunidadBitacora = APoportunidadBitacora.OportunidadBitacora_Agregar(oportunidadBitacora);
            }
            return Json(DBOportunidad);
        }
        [HttpPost]
        public JsonResult Oportunidad_Actualizar(Models.Oportunidad oportunidad, Application.Oportunidad APOportunidad)
        {
            oportunidad.Usuario = Usuario;
            Models.Oportunidad DBOportunidad = APOportunidad.Oportunidad_Actualizar(oportunidad);
            return Json(DBOportunidad);
        }
        [HttpPost]
        public JsonResult Oportunidad_Actulizar_Estatus(Models.Oportunidad oportunidad, Application.Oportunidad APOportunidad)
        {
            oportunidad.Usuario = Usuario;
            Models.Oportunidad DBOportunidad = APOportunidad.Oportunidad_Actualizar_IdEstatus(oportunidad);
            return Json(DBOportunidad);
        }
        [HttpPost]
        public JsonResult Oportunidad_Actulizar_FechaCierre(Models.Oportunidad oportunidad, Application.Oportunidad APOportunidad)
        {
            oportunidad.Usuario = Usuario;
            Models.Oportunidad DBOportunidad = APOportunidad.Oportunidad_Actualizar_FechaCierre(oportunidad);
            return Json(DBOportunidad);
        }
        [HttpPost]
        public JsonResult Administracion_Oportunidad_Dhasbord_Importe(Application.Oportunidad APOportunidad)
        {
            List<Models.Consulta.Oportunidad> DBOportunidad = APOportunidad.Oportunidad_Dhasbord_Seleccionar_Importe();
            return Json(DBOportunidad);
        }
        [HttpPost]
        public JsonResult Administracion_Oportunidad_Dhasbord_Importe_UnidadDeNegocio(Application.Oportunidad APOportunidad)
        {
            List<Models.Consulta.Oportunidad> DBOportunidad = APOportunidad.Oportunidad_Dhasbord_Seleccionar_Importe_UnidadDeNegocio();
            return Json(DBOportunidad);
        }
        [HttpPost]
        public JsonResult Administracion_Oportunidad_Dhasbord_Seleccionar_Usuarios(Application.Oportunidad APOportunidad)
        {
            DataTable DBOportunidades = APOportunidad.Oportunidad_Dhasbord_Seleccionar_Usuarios();
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(DBOportunidades);

            return Json(JSONString);
        }
        [HttpPost]
        public JsonResult Oportunidad_Seleccionar_FechaRegistro(Models.Consulta.Actividades actividades, Application.Oportunidad APOportunidad)
        {
            List<Models.Oportunidad> DBoportunidades = APOportunidad.Oportunidad_Seleccionar_FechaRegistro(actividades);
            return Json(DBoportunidades);
        }
        [HttpPost]
        public JsonResult Oportunidad_Seleccionar_FechaRegistro_IdUsuario(Models.Consulta.Actividades actividades, Application.Oportunidad APOportunidad)
        {
            List<Models.Oportunidad> DBoportunidades = APOportunidad.Oportunidad_Seleccionar_FechaRegistro_IdUsuario(actividades);
            return Json(DBoportunidades);
        }
        [HttpPost]
        public JsonResult Oportunidad_Seleccionar_Year_CerradoGanado(Models.Oportunidad oportunidad ,Application.Oportunidad APOportunidad)
        {
            List<Models.Oportunidad> DBOportunidad = APOportunidad.Oportunidad_Seleccionar_Year_CerradoGanado(oportunidad);
            return Json(DBOportunidad);
        }
        [HttpPost]
        public JsonResult Oportunidad_Contar_UnidadNegocio(Application.Oportunidad APOportunidad)
        {
            List<Models.Consulta.UnidadNegocio> DBOportunidad = APOportunidad.Oportunidad_Contar_UnidadNegocio();
            return Json(DBOportunidad);
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
