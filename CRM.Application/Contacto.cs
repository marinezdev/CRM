using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Contacto
    {
        Data.Contacto _contacto = new Data.Contacto();
        public Models.Contacto Contacto_Agregar(Models.Consulta.NuevoContacto nuevoContacto)
        {
            return _contacto.Contacto_Agregar(nuevoContacto);
        }
        public Models.Contacto Contacto_Actualizar(Models.Contacto contacto)
        {
            return _contacto.Contacto_Actualizar(contacto);
        }
        public Models.Contacto Contacto_Actualizar_Estatus(Models.Contacto contacto)
        {
            return _contacto.Contacto_Actualizar_Estatus(contacto);
        }
        public List<Models.Consulta.Contactos> Contacto_Seleccionar_UnidadNegocio(Models.CatUnidadNegocio catUnidadNegocio)
        {
            return _contacto.Contacto_Seleccionar_UnidadNegocio(catUnidadNegocio);
        }
        public List<Models.Consulta.Contactos> Contacto_Seleccionar()
        {
            return _contacto.Contacto_Seleccionar();
        }
        public List<Models.Consulta.Contactos> Contacto_Seleccionar_IdUsuario(Models.Usuario usuario)
        {
            return _contacto.Contacto_Seleccionar_IdUsuario(usuario);
        }
        public List<Models.Consulta.Contactos> Contacto_Seleccionar_FechaRegistro(Models.Consulta.Actividades actividades)
        {
            return _contacto.Contacto_Seleccionar_FechaRegistro(actividades);
        }
        public List<Models.Consulta.Contactos> Contacto_Seleccionar_FechaRegistro_IdUsuario(Models.Consulta.Actividades actividades)
        {
            return _contacto.Contacto_Seleccionar_FechaRegistro_IdUsuario(actividades);
        }
        public List<Models.Consulta.Contactos> Contacto_Seleccionar_IdUsuario_Bajas(Models.Usuario usuario)
        {
            return _contacto.Contacto_Seleccionar_IdUsuario_Bajas(usuario);
        }
        public List<Models.Contacto> Contacto_Seleccionar_Email()
        {
            return _contacto.Contacto_Seleccionar_Email();
        }
        public Models.Contacto Contecto_Seleccionar_Id(Models.Contacto contacto)
        {
            return _contacto.Contecto_Seleccionar_Id(contacto);
        }
        public List<Models.Consulta.UnidadNegocio> Contacto_Contar_UnidadNegocio()
        {
            return _contacto.Contacto_Contar_UnidadNegocio();
        }

        public List<Models.Consulta.SendEmail> SendEmail(Models.CampaignCorreoElectronico Model)
        {
            return _contacto.SendEmail(Model);
        }
        public List<Models.Consulta.SendEmail> SendEmail_Id(Models.Contacto contact)
        {
            return _contacto.SendEmail_Id(contact);
        }

        public List<Models.Consulta.SendEmail> SendEmail_IdTemplate(Models.Contacto contact)
        {
            return _contacto.SendEmail_IdTemplate(contact);
        }


        public Models.Consulta.SendEmail EnvioCorreoBitacora(Models.Consulta.SendEmail email)
        {
            return _contacto.EnvioCorreoBitacora(email);
        }

        public Models.Consulta.SendEmail CampaignBitacoraInsert(Models.CampaignCorreoElectronico email)
        {
            return _contacto.CampaignBitacoraInsert(email);
        }
    }
}
