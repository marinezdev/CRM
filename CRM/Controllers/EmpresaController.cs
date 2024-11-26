using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class EmpresaController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        string cadena = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        Models.MenuPermiso menuPermiso = new Models.MenuPermiso();
        Models.Menu Menu = new Models.Menu();

        // GET: Empresa
        public ActionResult Index(Application.Empresa APempresa)
        {
            if (ValidaUsuario())
            {
                List<Models.Empresa> empresas = APempresa.Empresa_Seleccionar();
                List<Models.Empresa> empresaUsuario = APempresa.Empresa_Seleccionar_IdUsuario(Usuario);
                List<Models.Empresa> empresaUsuarioBajas = APempresa.Empresa_Seleccionar_IdUsuario_Bajas(Usuario);
                ViewBag.Empresas = empresas;
                ViewBag.EmpresasUsuarios = empresaUsuario;
                ViewBag.EmpresasUsuariosBajas = empresaUsuarioBajas;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }

        public ActionResult Crear(Application.CatIndustria APcatIndustria, Application.CatTipoEmpresa APcatTipoEmpresa, Application.CatFuenteOrigen APcatFuenteOrigen,
            Application.CatUnidadNegocio APcatUnidadNegocio, Application.CatNumeroEmpleados APcatNumeroEmpleados, Application.CatIngresoAnual APcatIngresoAnual, Application.Usuario APusuario)
        {
            if (ValidaUsuario())
            {
                List<Models.CatIndustria> catIndustrias = APcatIndustria.CatIndustria_Seleccionar();
                List<Models.CatTipoEmpresa> catTipoEmpresa = APcatTipoEmpresa.CatTipoEmpresa_Seleccionar();
                List<Models.CatFuenteOrigen> catFuenteOrigen = APcatFuenteOrigen.CatFuenteOrigen_Seleccionar();
                List<Models.CatUnidadNegocio> catUnidadNegocio = APcatUnidadNegocio.CatUnidadNegocio_Seleccionar();
                List<Models.Usuario> usuarios = APusuario.Usuario_Propietario_Seleccionar();
                List<Models.CatNumeroEmpleados> catNumeroEmpleados = APcatNumeroEmpleados.CatNumeroEmpleados_Seleccionar();
                List<Models.CatIngresoAnual> catIngresoAnual = APcatIngresoAnual.CatIngresoAnual_Seleccionar();

                ViewBag.Industrias = catIndustrias;
                ViewBag.TipoEmpresa = catTipoEmpresa;
                ViewBag.FuenteOrigen = catFuenteOrigen;
                ViewBag.UnidadNegocio = catUnidadNegocio;
                ViewBag.NumeroEmpleados = catNumeroEmpleados;
                ViewBag.IngresoAnual = catIngresoAnual;
                ViewBag.Usuarios = usuarios;

                Session["EmpresaBusqueda"] = null;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }

        public ActionResult Empresa(Application.EmpresaBitacora APempresaBitacora, Application.Departamento APdepartamento, Application.Empresa APempresa, Application.Contacto APcontacto, Application.OportunidadEmpresa APoportunidadEmpresa, Application.CatTipoTelefono APcatTipoTelefono, Application.CatEstados APcatEstados,
            Application.CatIndustria APcatIndustria, Application.CatTipoEmpresa APcatTipoEmpresa, Application.CatFuenteOrigen APcatFuenteOrigen, Application.CatUnidadNegocio APcatUnidadNegocio, Application.CatNumeroEmpleados APcatNumeroEmpleados, Application.CatIngresoAnual APcatIngresoAnual, Application.Usuario APusuario, Application.CatPrioridad APcatPrioridad,
            Application.CatTipoTarea APcatTipoTarea, Application.CatRecordatorio APcatRecordatorio, Application.CatFechaVencimiento APcatFechaVencimiento, Application.Tarea APtarea, Application.Nota APnota, Application.CatDireccionLlamada APcatDireccionLlamada, Application.CatResultadoLlamada APcatResultadoLlamada,
            Application.CatResultadoReunion APcatResultadoReunion, Application.CatDuracionReunion APcatDuracionReunion, Application.CatTipoReunion APcatTipoReunion, Application.CatTipoMensaje APcatTipoMensaje, Application.Correo APcorreo, Application.Llamada APLlamada, Application.Reunion APReunion, Application.Mensaje APmensaje)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    string DirectorioURL = System.Web.HttpContext.Current.Request.Url.Authority + "\\DocumentosTemporales\\";
                    int IdEmpresa = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));
                    Models.Empresa empresa = new Models.Empresa();
                    empresa.Id = IdEmpresa;

                    Models.CatEntidad catEntidad = new Models.CatEntidad();
                    catEntidad.Id = 2;

                    Models.TareaEntidad tareaEntidad = new Models.TareaEntidad();
                    tareaEntidad.CatEntidad = catEntidad;
                    tareaEntidad.IdValorEntidad = IdEmpresa;

                    Models.CorreoEntidad correoEntidad = new Models.CorreoEntidad();
                    correoEntidad.CatEntidad = catEntidad;
                    correoEntidad.IdValorEntidad = IdEmpresa;

                    Models.LlamadaEntidad llamadaEntidad = new Models.LlamadaEntidad();
                    llamadaEntidad.CatEntidad = catEntidad;
                    llamadaEntidad.IdValorEntidad = IdEmpresa;

                    Models.ReunionEntidad reunionEntidad = new Models.ReunionEntidad();
                    reunionEntidad.CatEntidad = catEntidad;
                    reunionEntidad.IdValorEntidad = IdEmpresa;

                    Models.MensajeEntidad mensajeEntidad = new Models.MensajeEntidad();
                    mensajeEntidad.CatEntidad = catEntidad;
                    mensajeEntidad.IdValorEntidad = IdEmpresa;

                    Models.Tarea tarea = new Models.Tarea();
                    tarea.Usuario = Usuario;
                    Models.Consulta.NuevaTarea nuevaTarea = new Models.Consulta.NuevaTarea();
                    nuevaTarea.Tarea = tarea;
                    nuevaTarea.TareaEntidad = tareaEntidad;

                    Models.NotaEntidad notaEntidad = new Models.NotaEntidad();
                    notaEntidad.CatEntidad = catEntidad;
                    notaEntidad.IdValorEntidad = IdEmpresa;

                    List<Models.Consulta.Contactos> DBcontactos = APcontacto.Contacto_Seleccionar();
                    List<Models.EmpresaBitacora> DBEmpresaBitacora = APempresaBitacora.PersonaBitacora_Seleccionar(empresa);
                    List<Models.Departamento> DBdepartamentos = APdepartamento.Departamento_Seleccionar_IdEmpresa(empresa);
                    List<Models.CatTipoTelefono> DBcatTipoTelefonos = APcatTipoTelefono.CatTipoTelefono_Seleccionar();
                    List<Models.CatEstados> DBCatEstados = APcatEstados.CatEstados_Seleccionar();

                    List<Models.CatIndustria> catIndustrias = APcatIndustria.CatIndustria_Seleccionar();
                    List<Models.CatTipoEmpresa> catTipoEmpresa = APcatTipoEmpresa.CatTipoEmpresa_Seleccionar();
                    List<Models.CatFuenteOrigen> catFuenteOrigen = APcatFuenteOrigen.CatFuenteOrigen_Seleccionar();
                    List<Models.CatUnidadNegocio> catUnidadNegocio = APcatUnidadNegocio.CatUnidadNegocio_Seleccionar();
                    List<Models.CatNumeroEmpleados> catNumeroEmpleados = APcatNumeroEmpleados.CatNumeroEmpleados_Seleccionar();
                    List<Models.CatIngresoAnual> catIngresoAnual = APcatIngresoAnual.CatIngresoAnual_Seleccionar();


                    List<Models.Contacto> Contactos = APcontacto.Contacto_Seleccionar_Email();
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


                    Models.Empresa DBEmpresa = APempresa.Empresa_Seleccionar_Id(empresa);
                    DBEmpresa.ImagenURL = DirectorioURL + DBEmpresa.ImagenURL;
                    ViewBag.EmpresaBitacora = DBEmpresaBitacora;
                    ViewBag.Departamentos = DBdepartamentos;
                    ViewBag.Empresa = DBEmpresa;
                    ViewBag.Contactos1 = DBcontactos;
                    ViewBag.CatTipoTelefonos = DBcatTipoTelefonos;
                    ViewBag.CatEstados = DBCatEstados;

                    ViewBag.Industrias = catIndustrias;
                    ViewBag.TipoEmpresa = catTipoEmpresa;
                    ViewBag.FuenteOrigen = catFuenteOrigen;
                    ViewBag.UnidadNegocio = catUnidadNegocio;
                    ViewBag.NumeroEmpleados = catNumeroEmpleados;
                    ViewBag.IngresoAnual = catIngresoAnual;


                    ViewBag.Contactos = Contactos;
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


                    Session["EmpresaIMG"] = null;
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Empresa");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }

        public ActionResult UnidadNegocio(Application.Empresa APEmpresa)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    int IdUnidadNegocio = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));
                    Models.CatUnidadNegocio catUnidadNegocio = new Models.CatUnidadNegocio();
                    catUnidadNegocio.Id = IdUnidadNegocio;
                    List<Models.Empresa> ListEmpresa = APEmpresa.Empresa_Seleccionar_UnidadNegocio(catUnidadNegocio);

                    ViewBag.Empresas = ListEmpresa;
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
        public JsonResult Empresa_Agregar(Models.Empresa empresa, Application.Empresa APEmpresa)
        {
            Models.Empresa DBEmpresa = APEmpresa.Empresa_Agregar(empresa);
            return Json(DBEmpresa);
        }

        [HttpPost]
        public JsonResult Empresa_Actualizar(Models.Empresa empresa, Application.Empresa APEmpresa)
        {
            empresa.Usuario = Usuario;
            Models.Empresa DBEmpresa = APEmpresa.Empresa_Actualizar(empresa);
            return Json(DBEmpresa);
        }

        [HttpPost]
        public JsonResult Empresa_Actualizar_Estatus(Models.Empresa empresa, Application.Empresa APEmpresa)
        {
            empresa.Usuario = Usuario;
            Models.Empresa DBEmpresa = APEmpresa.Empresa_Actualizar_Estatus(empresa);
            return Json(DBEmpresa);
        }

        [HttpPost]
        public JsonResult Empresa_AgregarImagen(Models.ProductoImagen productoImagen)
        {
            string DirectorioURL = System.Web.HttpContext.Current.Request.Url.Authority + "\\DocumentosTemporales\\";
            Models.ProductoImagen _ProductoImagen = new Models.ProductoImagen();
            string IMG = "";
            _ProductoImagen = productoImagen;
            _ProductoImagen.NmArchivo = productoImagen.NmArchivo;
            Session["EmpresaIMG"] = _ProductoImagen;
            IMG = DirectorioURL + _ProductoImagen.NmArchivo;
            return Json(IMG);
        }

        [HttpPost]
        public JsonResult Empresa_ActualizarImagen(Models.Empresa empresa, Application.Empresa APEmpresa)
        {
            Models.ProductoImagen productoImagen = new Models.ProductoImagen();
            if (Session["EmpresaIMG"] != null)
            {
                productoImagen = (Models.ProductoImagen)Session["EmpresaIMG"];
            }

            empresa.Usuario = Usuario;
            empresa.Imagen = productoImagen.NmOriginal;
            empresa.ImagenURL = productoImagen.NmArchivo;
            Models.Empresa DBEmpresa = APEmpresa.Empresa_ActualizarImagen(empresa);
            return Json(DBEmpresa);
        }

        [HttpPost]
        public JsonResult Empresa_EliminarImagen()
        {
            Session["EmpresaIMG"] = null;
            return Json(1);
        }

        [HttpPost]
        public JsonResult Empresa_Buscar_Nombre(Models.Empresa empresa, Application.Empresa APEmpresa)
        {
            List<Models.Empresa> DBEmpresa = APEmpresa.Empresa_Selecionar_Nombre(empresa);
            Models.Empresa SesionEmpresa = new Models.Empresa();

            if ((Models.Empresa)System.Web.HttpContext.Current.Session["EmpresaBusqueda"] != null)
            {
                SesionEmpresa = (Models.Empresa)System.Web.HttpContext.Current.Session["EmpresaBusqueda"];
            }


            var form = false;

            if (DBEmpresa.Count > 1)
            {
                form = true;
            }
            else
            {
                if(DBEmpresa[0].Id != 0)
                {
                    form = true;
                }
            }

            if (form)
            {
                if (SesionEmpresa.Busqueda == 1 || SesionEmpresa.Busqueda == 2)
                {
                    SesionEmpresa.Busqueda = 2;
                    Session["EmpresaBusqueda"] = SesionEmpresa;
                    DBEmpresa[0].Busqueda = SesionEmpresa.Busqueda;
                }
                else
                {
                    SesionEmpresa.Busqueda = 1;
                    Session["EmpresaBusqueda"] = SesionEmpresa;
                    DBEmpresa[0].Busqueda = SesionEmpresa.Busqueda;
                }
            }
            else
            {
                SesionEmpresa.Busqueda = 0;
                Session["EmpresaBusqueda"] = SesionEmpresa;
                DBEmpresa[0].Busqueda = SesionEmpresa.Busqueda;
            }
            
            return Json(DBEmpresa);
        }

        [HttpPost]
        public JsonResult Empresa_Contar_UnidadNegocio(Application.Empresa APEmpresa)
        {
            List<Models.Consulta.UnidadNegocio> DBEmpresas = APEmpresa.Empresa_Contar_UnidadNegocio();
            return Json(DBEmpresas);
        }

        [HttpPost]
        public JsonResult Empresa_Seleccionar_FechaRegistro(Models.Consulta.Actividades actividades, Application.Empresa APEmpresa)
        {
            List<Models.Empresa> DBEmpresas = APEmpresa.Empresa_Seleccionar_FechaRegistro(actividades);
            return Json(DBEmpresas);
        }

        [HttpPost]
        public JsonResult Empresa_Seleccionar_FechaRegistro_IdUsuario(Models.Consulta.Actividades actividades, Application.Empresa APEmpresa)
        {
            List<Models.Empresa> DBEmpresas = APEmpresa.Empresa_Seleccionar_FechaRegistro_IdUsuario(actividades);
            return Json(DBEmpresas);
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
