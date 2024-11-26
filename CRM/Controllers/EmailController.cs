using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CRM.Models;
using CRM.Application.Services;
using CRM.Models.Consulta;
using System.Net.Sockets;
using System.Globalization;

namespace CRM.Controllers
{
    public class EmailController : Controller
    {
        Models.Usuario Usuario = (Models.Usuario)System.Web.HttpContext.Current.Session["Sesion"];

        // GET: Email
        public ActionResult Index()
        {
            return View();
        }


        //ENVIOS PROGRAMADOS
        [HttpPost]
        public async Task<JsonResult> SendEmail(Application.Contacto contacto, Models.CampaignCorreoElectronico Model,Models.Contacto contact)
        {
            Model.Usuario = Usuario;

            List<SendEmail> DataEmail = contacto.SendEmail(Model);

            contacto.CampaignBitacoraInsert(Model);

            if (DataEmail != null && DataEmail.Any())
            {
                foreach (SendEmail email in DataEmail)
                {
                    email.Contacto.Usuario = Usuario;
                    string formatoOriginal = email.CampaignCorreoElectronico.Formato;

                    string contenidoModificado = formatoOriginal.Replace("[Nombre completo]", email.Contacto.Persona.Nombre)
                    //.Replace("[Nombre corto]", contact.Usuario.Persona.Nombre + " " + contact.Usuario.Persona.ApellidoPaterno)
                    .Replace("[Nombre empresa]", "Asae Consultores");

                    MailCreate nuevoCorreo = new MailCreate
                    {
                        Token = string.Empty,
                        AplicacionUserId = 1,
                        Aplicacion = "CRM",
                        //grupoId = 1,             // EL id de la campaña 
                        //grupoName = "nombre campaña", // El nombre de la campaña
                        Origen = "CRM ASAE",
                        Destinatario = email.Contacto.Persona.Email.email,
                        DestinatarioCC = string.Empty,
                        DestinatarioCCO = string.Empty,
                        Asunto = "Marketing Asae",
                        Contenido = contenidoModificado,
                        fechaEnvio = email.CampaignCorreoElectronico.FechaEnvio.ToString("yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture)
                    };

                    Mail resultado = await EmailService.SendAsync(nuevoCorreo);

                    SendEmail Rbitacora = contacto.EnvioCorreoBitacora(email);
                }
            }

            return Json(DataEmail);
        }


        //PARA ENVIOS DE PRUEBA

        [HttpPost]
        public async Task<JsonResult> SendEmail_Id(Application.Contacto contacto, Models.Contacto contact)
        {
            contact.Usuario = Usuario;

            List<SendEmail> DataEmail = contacto.SendEmail_Id(contact);

            if (DataEmail != null && DataEmail.Any())
            {
                foreach (SendEmail email in DataEmail)
                {
                    string formatoOriginal = email.CampaignCorreoElectronico.Formato;

                    string contenidoModificado = formatoOriginal.Replace("[Nombre completo]", contact.Usuario.Persona.Nombre +" "+contact.Usuario.Persona.ApellidoPaterno +" "+ contact.Usuario.Persona.ApellidoMaterno)
                    .Replace("[Nombre corto]", contact.Usuario.Persona.Nombre +" "+ contact.Usuario.Persona.ApellidoPaterno)
                    .Replace("[Nombre empresa]", "Asae Consultores");
                    MailCreate nuevoCorreo = new MailCreate
                    {
                        Token = string.Empty,
                        AplicacionUserId = 1,
                        Aplicacion = "CRM",
                        //grupoId = 1,             // EL id de la campaña 
                        //grupoName = "nombre campaña", // El nombre de la campaña
                        Origen = "CRM ASAE",
                        Destinatario = contact.Usuario.Persona.Email.email,
                        DestinatarioCC = string.Empty,
                        DestinatarioCCO = string.Empty,
                        Asunto = "Marketing Asae",
                        Contenido = contenidoModificado,
                        fechaEnvio = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    };

                    Mail resultado = await EmailService.SendAsync(nuevoCorreo);
                }
            }

            return Json(DataEmail);
        }


        [HttpPost]
        public async Task<JsonResult> SendEmail_IdTemplate(Application.Contacto contacto, Models.Contacto contact)
        {
            contact.Usuario = Usuario;

            List<SendEmail> DataEmail = contacto.SendEmail_IdTemplate(contact);

            if (DataEmail != null && DataEmail.Any())
            {
                foreach (SendEmail email in DataEmail)
                {
                    string formatoOriginal = email.CampaignCorreoElectronico.Formato;

                    string contenidoModificado = formatoOriginal.Replace("[Nombre completo]", contact.Usuario.Persona.Nombre + " " + contact.Usuario.Persona.ApellidoPaterno + " " + contact.Usuario.Persona.ApellidoMaterno)
                    .Replace("[Nombre corto]", contact.Usuario.Persona.Nombre + " " + contact.Usuario.Persona.ApellidoPaterno)
                    .Replace("[Nombre empresa]", "Asae Consultores");
                    MailCreate nuevoCorreo = new MailCreate
                    {
                        Token = string.Empty,
                        AplicacionUserId = 1,
                        Aplicacion = "CRM",
                        //grupoId = 1,             // EL id de la campaña 
                        //grupoName = "nombre campaña", // El nombre de la campaña
                        Origen = "CRM ASAE",
                        Destinatario = contact.Usuario.Persona.Email.email,
                        DestinatarioCC = string.Empty,
                        DestinatarioCCO = string.Empty,
                        Asunto = "Marketing Asae",
                        Contenido = contenidoModificado,
                        fechaEnvio = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    };

                    Mail resultado = await EmailService.SendAsync(nuevoCorreo);
                }
            }

            return Json(DataEmail);
        }
    }
}