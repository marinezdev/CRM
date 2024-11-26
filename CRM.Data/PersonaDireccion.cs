using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class PersonaDireccion
    {
        ManejoDatos b = new ManejoDatos();
        public Models.PersonaDireccion PersonaDireccion_Agregar(Models.PersonaDireccion personaDireccion)
        {
            const string consulta = "PersonaDireccion_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", personaDireccion.Persona.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", personaDireccion.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", personaDireccion.Nombre, SqlDbType.NVarChar);
            b.AddParameter("@NumExterior", personaDireccion.NumExterior, SqlDbType.NVarChar);
            b.AddParameter("@NumInterior", personaDireccion.NumInterior, SqlDbType.NVarChar);
            b.AddParameter("@Calle", personaDireccion.Calle, SqlDbType.NVarChar);
            b.AddParameter("@IdColonia", personaDireccion.CatColonias.Id, SqlDbType.Int);

            Models.PersonaDireccion resultado = new Models.PersonaDireccion();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.PersonaDireccion>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.PersonaDireccion> PersonaDireccion_Seleccionar_IdPersona(Models.Persona persona)
        {
            const string consulta = "PersonaDireccion_Seleccionar_IdPersona";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", persona.Id, SqlDbType.Int);

            List<Models.PersonaDireccion> resultado = new List<Models.PersonaDireccion>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.PersonaDireccion>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.PersonaDireccion PersonaDireccion_Eliminar(Models.PersonaDireccion personaDireccion)
        {
            const string consulta = "PersonaDireccion_Eliminar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", personaDireccion.Persona.Id, SqlDbType.Int);
            b.AddParameter("@Id", personaDireccion.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", personaDireccion.Usuario.Id, SqlDbType.Int);

            Models.PersonaDireccion resultado = new Models.PersonaDireccion();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.PersonaDireccion>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
