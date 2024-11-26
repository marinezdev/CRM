using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.Controllers
{
    public class ContactoController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];
        string url = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        string cadena = System.Web.HttpContext.Current.Request.Url.AbsolutePath;
        Models.MenuPermiso menuPermiso = new Models.MenuPermiso();
        Models.Menu Menu = new Models.Menu();

        public ActionResult Index(Application.Contacto APcontacto)
        {
            if (ValidaUsuario())
            {
                List<Models.Consulta.Contactos> Contactos = APcontacto.Contacto_Seleccionar(); 
                List<Models.Consulta.Contactos> ContactosUsuario = APcontacto.Contacto_Seleccionar_IdUsuario(Usuario);
                List<Models.Consulta.Contactos> ContactosBajas = APcontacto.Contacto_Seleccionar_IdUsuario_Bajas(Usuario);
                
                ViewBag.Contactos = Contactos;
                ViewBag.ContactosUsuario = ContactosUsuario;
                ViewBag.ContactosBajas = ContactosBajas;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        public ActionResult Crear(Application.CatTipoPersona APcatTipoPersona, Application.CatUnidadNegocio APcatUnidadNegocio, Application.CatEstatusPersona APcatEstatusPersona, Application.CatCargo APcatCargo, Application.CatFuenteOrigen APcatFuenteOrigen, Application.Usuario APusuario, Application.Empresa APEmpresa, Application.CatTipoTelefono APcatTipoTelefono)
        {
            if (ValidaUsuario())
            {
                Models.PersonaEmail SesionEmail = new Models.PersonaEmail();
                List<Models.CatTipoPersona> catTipoPersona = APcatTipoPersona.CatTipoPersona_Seleccionar();
                List<Models.CatUnidadNegocio> catUnidadNegocio = APcatUnidadNegocio.CatUnidadNegocio_Seleccionar();
                List<Models.CatEstatusPersona> catEstatusPersona = APcatEstatusPersona.CatEstatusPersona_Seleccionar();
                List<Models.CatCargo> catCargo = APcatCargo.CatCargo_Seleccionar();
                List<Models.CatFuenteOrigen> catFuenteOrigen = APcatFuenteOrigen.CatFuenteOrigen_Seleccionar();
                List<Models.Usuario> usuarios = APusuario.Usuario_Propietario_Seleccionar();
                List<Models.Empresa> Empresas = APEmpresa.Empresa_Seleccionar_Oportunidad();
                List<Models.CatTipoTelefono> DBcatTipoTelefonos = APcatTipoTelefono.CatTipoTelefono_Seleccionar();

                ViewBag.TipoPersona = catTipoPersona;
                ViewBag.UnidadNegocio = catUnidadNegocio;
                ViewBag.EstatusPersona = catEstatusPersona;
                ViewBag.Cargo = catCargo;
                ViewBag.FuenteOrigen = catFuenteOrigen;
                ViewBag.Usuarios = usuarios;
                ViewBag.Empresas = Empresas;
                ViewBag.CatTipoTelefonos = DBcatTipoTelefonos;

                Session["EmailBusqueda"] = null;
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        public ActionResult UnidadNegocio(Application.Contacto APcontacto)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    int IdUnidadNegocio = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));
                    Models.CatUnidadNegocio catUnidadNegocio = new Models.CatUnidadNegocio();
                    catUnidadNegocio.Id = IdUnidadNegocio;
                    List<Models.Consulta.Contactos> Contactos = APcontacto.Contacto_Seleccionar_UnidadNegocio(catUnidadNegocio);

                    ViewBag.Contactos = Contactos;
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Contacto");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        public ActionResult Contacto(Application.Empresa APempresa, Application.Contacto APcontacto, Application.PersonaBitacora APpersonaBitacora, Application.CatTipoTelefono APcatTipoTelefono, Application.CatEstados APcatEstados,
            Application.CatTipoPersona APcatTipoPersona, Application.CatUnidadNegocio APcatUnidadNegocio, Application.CatEstatusPersona APcatEstatusPersona, Application.CatCargo APcatCargo, Application.CatFuenteOrigen APcatFuenteOrigen, Application.Usuario APusuario, Application.CatPrioridad APcatPrioridad,
            Application.CatTipoTarea APcatTipoTarea, Application.CatRecordatorio APcatRecordatorio, Application.CatFechaVencimiento APcatFechaVencimiento, Application.Tarea APtarea, Application.Nota APnota, Application.CatDireccionLlamada APcatDireccionLlamada, Application.CatResultadoLlamada APcatResultadoLlamada,
            Application.CatResultadoReunion APcatResultadoReunion, Application.CatDuracionReunion APcatDuracionReunion, Application.CatTipoReunion APcatTipoReunion, Application.CatTipoMensaje APcatTipoMensaje, Application.Correo APcorreo, Application.Llamada APLlamada, Application.Reunion APReunion, Application.Mensaje APmensaje)
        {
            if (ValidaUsuario())
            {
                if (!String.IsNullOrEmpty(Request.QueryString["cont"]))
                {
                    Models.Contacto contacto = new Models.Contacto();
                    Models.Persona persona = new Models.Persona();

                    List<Models.Empresa> empresas = APempresa.Empresa_Seleccionar();
                    int IdPersona = Convert.ToInt32(Application.UrlCifrardo.Decrypt(Request.QueryString["cont"]));
                    persona.Id = IdPersona;
                    contacto.Persona = persona;

                    Models.CatEntidad catEntidad = new Models.CatEntidad();
                    catEntidad.Id = 1;

                    Models.TareaEntidad tareaEntidad = new Models.TareaEntidad();
                    tareaEntidad.CatEntidad = catEntidad;
                    tareaEntidad.IdValorEntidad = IdPersona;

                    Models.CorreoEntidad correoEntidad = new Models.CorreoEntidad();
                    correoEntidad.CatEntidad = catEntidad;
                    correoEntidad.IdValorEntidad = IdPersona;

                    Models.LlamadaEntidad llamadaEntidad = new Models.LlamadaEntidad();
                    llamadaEntidad.CatEntidad = catEntidad;
                    llamadaEntidad.IdValorEntidad = IdPersona;

                    Models.ReunionEntidad reunionEntidad = new Models.ReunionEntidad();
                    reunionEntidad.CatEntidad = catEntidad;
                    reunionEntidad.IdValorEntidad = IdPersona;

                    Models.MensajeEntidad mensajeEntidad = new Models.MensajeEntidad();
                    mensajeEntidad.CatEntidad = catEntidad;
                    mensajeEntidad.IdValorEntidad = IdPersona;

                    Models.Tarea tarea = new Models.Tarea();
                    tarea.Usuario = Usuario;
                    Models.Consulta.NuevaTarea nuevaTarea = new Models.Consulta.NuevaTarea();
                    nuevaTarea.Tarea = tarea;
                    nuevaTarea.TareaEntidad = tareaEntidad;

                    Models.NotaEntidad notaEntidad = new Models.NotaEntidad();
                    notaEntidad.CatEntidad = catEntidad;
                    notaEntidad.IdValorEntidad = IdPersona;


                    Models.Contacto DBContacto = APcontacto.Contecto_Seleccionar_Id(contacto);
                    List<Models.PersonaBitacora> DBpersonaBitacoras = APpersonaBitacora.PersonaBitacora_Seleccionar(contacto);
                    List<Models.CatTipoTelefono> DBcatTipoTelefonos = APcatTipoTelefono.CatTipoTelefono_Seleccionar();
                    List<Models.CatEstados> DBCatEstados = APcatEstados.CatEstados_Seleccionar();
                    List<Models.CatTipoPersona> catTipoPersona = APcatTipoPersona.CatTipoPersona_Seleccionar();
                    List<Models.CatUnidadNegocio> catUnidadNegocio = APcatUnidadNegocio.CatUnidadNegocio_Seleccionar();
                    List<Models.CatEstatusPersona> catEstatusPersona = APcatEstatusPersona.CatEstatusPersona_Seleccionar();
                    List<Models.CatCargo> catCargo = APcatCargo.CatCargo_Seleccionar();
                    List<Models.CatFuenteOrigen> catFuenteOrigen = APcatFuenteOrigen.CatFuenteOrigen_Seleccionar();

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

                    Session["EmailBusqueda"] = null;

                    ViewBag.Empresas = empresas;
                    ViewBag.Contato = DBContacto;
                    ViewBag.PersonaBitacora = DBpersonaBitacoras;
                    ViewBag.CatTipoTelefonos = DBcatTipoTelefonos;
                    ViewBag.CatEstados = DBCatEstados;


                    ViewBag.TipoPersona = catTipoPersona;
                    ViewBag.UnidadNegocio = catUnidadNegocio;
                    ViewBag.EstatusPersona = catEstatusPersona;
                    ViewBag.Cargo = catCargo;
                    ViewBag.FuenteOrigen = catFuenteOrigen;

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

                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Contacto");
                }
            }
            else
            {
                return RedirectToAction("Index", "Login", new { @rd = Application.UrlCifrardo.Encrypt(cadena), @rdv = Application.UrlCifrardo.Encrypt(url) });
            }
        }
        [HttpPost]
        public JsonResult Contacto_Agregar(Models.Consulta.NuevoContacto nuevoContacto, Application.Contacto APContacto)
        {
            Models.Contacto DBContacto = APContacto.Contacto_Agregar(nuevoContacto);
            return Json(DBContacto);
        }
        [HttpPost]
        public JsonResult Contacto_Actualizar(Models.Contacto contacto, Application.Contacto APContacto)
        {
            contacto.Usuario = Usuario;
            Models.Contacto DBContacto = APContacto.Contacto_Actualizar(contacto);
            return Json(DBContacto);
        }
        [HttpPost]
        public JsonResult Contacto_Actualizar_Estatus(Models.Contacto contacto, Application.Contacto APContacto)
        {
            contacto.Usuario = Usuario;
            Models.Contacto DBContacto = APContacto.Contacto_Actualizar_Estatus(contacto);
            return Json(DBContacto);
        }
        [HttpPost]
        public JsonResult Contacto_Buscar_Email(Models.Email email, Application.PersonaEmail APPersonaEmail)
        {
            List<Models.PersonaEmail> DBPersonaEmail = APPersonaEmail.PersonaEmail_Selecionar_Email(email);
            Models.PersonaEmail SesionEmail = new Models.PersonaEmail();

            if ((Models.PersonaEmail)System.Web.HttpContext.Current.Session["EmailBusqueda"] != null)
            {
                SesionEmail = (Models.PersonaEmail)System.Web.HttpContext.Current.Session["EmailBusqueda"];
            }

            var form = false;
            if (DBPersonaEmail.Count > 1)
            {
                form = true;
            }
            else
            {
                if (DBPersonaEmail[0].Persona.Id != 0)
                {
                    form = true;
                }
            }

            if (form)
            {
                if (SesionEmail.Busqueda == 1 || SesionEmail.Busqueda == 2)
                {
                    SesionEmail.Busqueda = 2;
                    Session["EmailBusqueda"] = SesionEmail;
                    DBPersonaEmail[0].Busqueda = SesionEmail.Busqueda;
                }
                else
                {
                    SesionEmail.Busqueda = 1;
                    Session["EmailBusqueda"] = SesionEmail;
                    DBPersonaEmail[0].Busqueda = SesionEmail.Busqueda;
                }
            }
            else
            {
                SesionEmail.Busqueda = 0;
                Session["EmailBusqueda"] = SesionEmail;
                DBPersonaEmail[0].Busqueda = SesionEmail.Busqueda;
            }

            return Json(DBPersonaEmail);
        }
        [HttpPost]
        public JsonResult Contacto_Seleccionar_FechaRegistro(Models.Consulta.Actividades actividades, Application.Contacto APContacto)
        {
            List<Models.Consulta.Contactos> dbContactos = APContacto.Contacto_Seleccionar_FechaRegistro(actividades);
            return Json(dbContactos);
        }
        [HttpPost]
        public JsonResult Contacto_Seleccionar_FechaRegistro_IdUsuario(Models.Consulta.Actividades actividades, Application.Contacto APContacto)
        {
            List<Models.Consulta.Contactos> dbContactos = APContacto.Contacto_Seleccionar_FechaRegistro_IdUsuario(actividades);
            return Json(dbContactos);
        }
        [HttpPost]
        public JsonResult Contacto_Contar_UnidadNegocio(Application.Contacto APContacto)
        {
            List<Models.Consulta.UnidadNegocio> DBContacto = APContacto.Contacto_Contar_UnidadNegocio();
            return Json(DBContacto);
        }




        [HttpPost]
        public JsonResult Contacto_Seleccionar_IdEmpresa(Application.Lista APPlist, Models.Empresa empresa)
        {
            List<Models.Contacto> R = APPlist.Contacto_Seleccionar_IdEmpresa(empresa);
            return Json(R);
        }

        [HttpPost]
        public JsonResult Contacto_Seleccionar_IdUnidadNegocio(Application.Lista APPlist, Models.CatUnidadNegocio UDN)
        {
            List<Models.Contacto> R = APPlist.Contacto_Seleccionar_IdUnidadNegocio(UDN);
            return Json(R);
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
