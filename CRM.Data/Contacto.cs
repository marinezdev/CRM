using CRM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Contacto
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Contacto Contacto_Agregar(Models.Consulta.NuevoContacto nuevoContacto)
        {
            const string consulta = "Contacto_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Email", nuevoContacto.Contacto.Persona.Email.email, SqlDbType.NVarChar);
            b.AddParameter("@Verificado", nuevoContacto.Contacto.Persona.Email.Verificado, SqlDbType.Int);
            b.AddParameter("@Nombre", nuevoContacto.Contacto.Persona.Nombre, SqlDbType.NVarChar);
            b.AddParameter("@ApellidoPaterno", nuevoContacto.Contacto.Persona.ApellidoPaterno, SqlDbType.NVarChar);
            b.AddParameter("@ApellidoMaterno", nuevoContacto.Contacto.Persona.ApellidoMaterno, SqlDbType.NVarChar);
            b.AddParameter("@RFC", nuevoContacto.Contacto.Persona.RFC, SqlDbType.NVarChar);
            b.AddParameter("@Sexo", nuevoContacto.Contacto.Persona.Sexo, SqlDbType.Int);
            b.AddParameter("@Descripcion", nuevoContacto.Contacto.Persona.Descripcion, SqlDbType.NVarChar);
            b.AddParameter("@FechaNacimiento", nuevoContacto.Contacto.Persona.FechaNacimiento, SqlDbType.Date);

            b.AddParameter("@IdTipoPersona", nuevoContacto.Contacto.Persona.CatTipoPersona.Id, SqlDbType.Int);
            b.AddParameter("@IdEstatusPersona", nuevoContacto.Contacto.Persona.CatEstatusPersona.Id, SqlDbType.Int);
            b.AddParameter("@IdUnidadNegocio", nuevoContacto.Contacto.Persona.CatUnidadNegocio.Id, SqlDbType.Int);

            b.AddParameter("@IdFuenteOrigen", nuevoContacto.Contacto.CatFuenteOrigen.Id, SqlDbType.Int);
            b.AddParameter("@IdCargo", nuevoContacto.Contacto.CatCargo.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", nuevoContacto.Contacto.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Restringido", nuevoContacto.Contacto.Restringido, SqlDbType.Int);

            if (nuevoContacto.Telefono == null)
            {
                b.AddParameter("@IdTipoTelefono", null, SqlDbType.Int);
                b.AddParameter("@Telefono", null, SqlDbType.NVarChar);
            }
            else
            {
                b.AddParameter("@IdTipoTelefono", nuevoContacto.Telefono.CatTipoTelefono.Id, SqlDbType.Int);
                b.AddParameter("@Telefono", nuevoContacto.Telefono.telefono, SqlDbType.NVarChar);
            }

            if (nuevoContacto.Puesto == null)
            {
                b.AddParameter("@IdPuesto", null, SqlDbType.Int);
            }
            else
            {
                b.AddParameter("@IdPuesto", nuevoContacto.Puesto.Id, SqlDbType.Int);
            }

            Models.Contacto resultado = new Models.Contacto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Contacto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Contacto Contacto_Actualizar(Models.Contacto contacto)
        {
            const string consulta = "Contacto_Actualizar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdContacto", contacto.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", contacto.Persona.Nombre, SqlDbType.NVarChar);
            b.AddParameter("@ApellidoPaterno", contacto.Persona.ApellidoPaterno, SqlDbType.NVarChar);
            b.AddParameter("@ApellidoMaterno", contacto.Persona.ApellidoMaterno, SqlDbType.NVarChar);
            b.AddParameter("@RFC", contacto.Persona.RFC, SqlDbType.NVarChar);
            b.AddParameter("@Sexo", contacto.Persona.Sexo, SqlDbType.Int);
            b.AddParameter("@Descripcion", contacto.Persona.Descripcion, SqlDbType.NVarChar);
            b.AddParameter("@FechaNacimiento", contacto.Persona.FechaNacimiento, SqlDbType.Date);

            b.AddParameter("@IdTipoPersona", contacto.Persona.CatTipoPersona.Id, SqlDbType.Int);
            b.AddParameter("@IdEstatusPersona", contacto.Persona.CatEstatusPersona.Id, SqlDbType.Int);
            b.AddParameter("@IdUnidadNegocio", contacto.Persona.CatUnidadNegocio.Id, SqlDbType.Int);

            b.AddParameter("@IdFuenteOrigen", contacto.CatFuenteOrigen.Id, SqlDbType.Int);
            b.AddParameter("@IdCargo", contacto.CatCargo.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", contacto.Usuario.Id, SqlDbType.Int);

            Models.Contacto resultado = new Models.Contacto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Contacto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Contacto Contacto_Actualizar_Estatus(Models.Contacto contacto)
        {
            const string consulta = "Contacto_Actualizar_Estatus";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdContacto", contacto.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", contacto.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdEstatusPersona", contacto.Persona.CatEstatusPersona.Id, SqlDbType.Int);
            b.AddParameter("@Descripcion", contacto.Descripcion, SqlDbType.NVarChar);
            b.AddParameter("@Clave", contacto.Clave, SqlDbType.NVarChar);

            Models.Contacto resultado = new Models.Contacto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Contacto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.Contactos> Contacto_Seleccionar_UnidadNegocio(Models.CatUnidadNegocio catUnidadNegocio)
        {
            const string consulta = "Contacto_Seleccionar_UnidadNegocio";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUnidadNegocio", catUnidadNegocio.Id, SqlDbType.Int);

            List<Models.Consulta.Contactos> resultado = new List<Models.Consulta.Contactos>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.Contactos>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.Contactos> Contacto_Seleccionar()
        {
            const string consulta = "Contacto_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.Consulta.Contactos> resultado = new List<Models.Consulta.Contactos>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.Contactos>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.Contactos> Contacto_Seleccionar_IdUsuario(Models.Usuario usuario)
        {
            const string consulta = "Contacto_Seleccionar_IdUsuario";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", usuario.Id, SqlDbType.Int);

            List<Models.Consulta.Contactos> resultado = new List<Models.Consulta.Contactos>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.Contactos>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.Contactos> Contacto_Seleccionar_FechaRegistro(Models.Consulta.Actividades actividades)
        {
            const string consulta = "Contacto_Seleccionar_FechaRegistro";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Fecha1", actividades.FechaInicio, SqlDbType.Date);
            b.AddParameter("@Fecha2", actividades.FechaTermino, SqlDbType.Date);
            b.AddParameter("@IdUnidadNegocio", actividades.CatUnidadNegocio.Id, SqlDbType.Int);

            List<Models.Consulta.Contactos> resultado = new List<Models.Consulta.Contactos>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.Contactos>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.Contactos> Contacto_Seleccionar_FechaRegistro_IdUsuario(Models.Consulta.Actividades actividades)
        {
            const string consulta = "Contacto_Seleccionar_FechaRegistro_IdUsuario";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Fecha1", actividades.FechaInicio, SqlDbType.Date);
            b.AddParameter("@Fecha2", actividades.FechaTermino, SqlDbType.Date);
            b.AddParameter("@IdUsuario", actividades.Usuario.Id, SqlDbType.Int);

            List<Models.Consulta.Contactos> resultado = new List<Models.Consulta.Contactos>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.Contactos>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.Contactos> Contacto_Seleccionar_IdUsuario_Bajas(Models.Usuario usuario)
        {
            const string consulta = "Contacto_Seleccionar_IdUsuario_Bajas";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUsuario", usuario.Id, SqlDbType.Int);

            List<Models.Consulta.Contactos> resultado = new List<Models.Consulta.Contactos>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.Contactos>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Contacto> Contacto_Seleccionar_Email()
        {
            const string consulta = "Contacto_Seleccionar_Email";
            b.ExecuteCommandSP(consulta);

            List<Models.Contacto> resultado = new List<Models.Contacto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Contacto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Contacto Contecto_Seleccionar_Id(Models.Contacto contacto)
        {
            const string consulta = "Contecto_Seleccionar_Id";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", contacto.Persona.Id, SqlDbType.NVarChar);

            Models.Contacto resultado = new Models.Contacto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Contacto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.UnidadNegocio> Contacto_Contar_UnidadNegocio()
        {
            const string consulta = "Contacto_Contar_UnidadNegocio";
            b.ExecuteCommandSP(consulta);

            List<Models.Consulta.UnidadNegocio> resultado = new List<Models.Consulta.UnidadNegocio>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.UnidadNegocio>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }



        public List<Models.Consulta.SendEmail> SendEmail(Models.CampaignCorreoElectronico Model)
        {
            const string consulta = "SendEmail";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", Model.Id, SqlDbType.NVarChar);


            List<Models.Consulta.SendEmail> resultado = new List<Models.Consulta.SendEmail>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.SendEmail>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.SendEmail> SendEmail_Id(Models.Contacto contact)
        {
            const string consulta = "SendEmail_Id";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", contact.Id, SqlDbType.NVarChar);


            List<Models.Consulta.SendEmail> resultado = new List<Models.Consulta.SendEmail>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.SendEmail>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Consulta.SendEmail> SendEmail_IdTemplate(Models.Contacto contact)
        {
            const string consulta = "SendEmail_IdTemplate";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", contact.Id, SqlDbType.NVarChar);


            List<Models.Consulta.SendEmail> resultado = new List<Models.Consulta.SendEmail>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.SendEmail>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Consulta.SendEmail EnvioCorreoBitacora(Models.Consulta.SendEmail contacto)
        {
            const string consulta = "EnvioCorreoBitacora";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", contacto.Contacto.Persona.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", contacto.Contacto.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@NameEmail", contacto.CampaignCorreoElectronico.Nombre, SqlDbType.NVarChar);


            Models.Consulta.SendEmail resultado = new Models.Consulta.SendEmail();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Consulta.SendEmail>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }


        public Models.Consulta.SendEmail CampaignBitacoraInsert(Models.CampaignCorreoElectronico contacto)
        {
            const string consulta = "CampaignBitacoraInsert";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdCampaign", contacto.Campaign.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", contacto.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdList", contacto.Lista.Id, SqlDbType.Int);

            b.AddParameter("@NameList", contacto.Lista.Nombre, SqlDbType.NVarChar);
            b.AddParameter("@NameCorreo", contacto.Nombre, SqlDbType.NVarChar);
            b.AddParameter("@FechaEnvio", contacto.FechaEnvio, SqlDbType.DateTime);


            Models.Consulta.SendEmail resultado = new Models.Consulta.SendEmail();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Consulta.SendEmail>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
