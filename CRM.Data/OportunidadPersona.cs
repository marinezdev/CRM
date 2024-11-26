using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class OportunidadPersona
    {
        ManejoDatos b = new ManejoDatos();
        public Models.OportunidadPersona OportunidadPersona_Agregar(Models.OportunidadPersona oportunidadPersona)
        {
            const string consulta = "OportunidadPersona_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidadPersona.Oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdPersona", oportunidadPersona.Persona.Id, SqlDbType.Int);
            b.AddParameter("@IdRol", oportunidadPersona.CatPersonaOportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidadPersona.Usuario.Id, SqlDbType.Int);

            Models.OportunidadPersona resultado = new Models.OportunidadPersona();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadPersona>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.OportunidadPersona OportunidadPersona_Editar(Models.OportunidadPersona oportunidadPersona)
        {
            const string consulta = "OportunidadPersona_Editar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", oportunidadPersona.Id, SqlDbType.Int);
            b.AddParameter("@IdOportunidad", oportunidadPersona.Oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdPersona", oportunidadPersona.Persona.Id, SqlDbType.Int);
            b.AddParameter("@IdRol", oportunidadPersona.CatPersonaOportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidadPersona.Usuario.Id, SqlDbType.Int);

            Models.OportunidadPersona resultado = new Models.OportunidadPersona();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadPersona>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.OportunidadPersona OportunidadPersona_Eliminar(Models.OportunidadPersona oportunidadPersona)
        {
            const string consulta = "OportunidadPersona_Eliminar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidadPersona.Oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@Id", oportunidadPersona.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidadPersona.Usuario.Id, SqlDbType.Int);

            Models.OportunidadPersona resultado = new Models.OportunidadPersona();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadPersona>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.OportunidadPersona OportunidadPersona_Seleccionar_Id(Models.OportunidadPersona oportunidadPersona)
        {
            const string consulta = "OportunidadPersona_Seleccionar_Id";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", oportunidadPersona.Id, SqlDbType.Int);

            Models.OportunidadPersona resultado = new Models.OportunidadPersona();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadPersona>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.OportunidadPersona> OportunidadPersona_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad)
        {
            const string consulta = "OportunidadPersona_Seleccionar_IdOportunidad";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidad.Id, SqlDbType.NVarChar);

            List<Models.OportunidadPersona> resultado = new List<Models.OportunidadPersona>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.OportunidadPersona>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.OportunidadPersona> OportunidadPersona_Seleccionar_IdPersona(Models.Persona persona)
        {
            const string consulta = "OportunidadPersona_Seleccionar_IdPersona";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", persona.Id, SqlDbType.NVarChar);

            List<Models.OportunidadPersona> resultado = new List<Models.OportunidadPersona>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.OportunidadPersona>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
