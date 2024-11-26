using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class PersonaTelefono
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.PersonaTelefono> PersonaTelefono_Seleccionar_IdPersona(Models.Persona persona)
        {
            const string consulta = "PersonaTelefono_Seleccionar_IdPersona";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", persona.Id, SqlDbType.Int);

            List<Models.PersonaTelefono> resultado = new List<Models.PersonaTelefono>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.PersonaTelefono>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.PersonaTelefono PersonaTelefono_Agregar(Models.PersonaTelefono personaTelefono)
        {
            const string consulta = "PersonaTelefono_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", personaTelefono.Persona.Id, SqlDbType.Int);
            b.AddParameter("@Telefono", personaTelefono.Telefono.telefono, SqlDbType.VarChar);
            b.AddParameter("@IdTipoTelefono", personaTelefono.Telefono.CatTipoTelefono.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", personaTelefono.Usuario.Id, SqlDbType.Int);

            Models.PersonaTelefono resultado = new Models.PersonaTelefono();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.PersonaTelefono>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.PersonaTelefono PersonaTelefono_Eliminar(Models.PersonaTelefono personaTelefono)
        {
            const string consulta = "PersonaTelefono_Eliminar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", personaTelefono.Persona.Id, SqlDbType.Int);
            b.AddParameter("@Id", personaTelefono.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", personaTelefono.Usuario.Id, SqlDbType.Int);

            Models.PersonaTelefono resultado = new Models.PersonaTelefono();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.PersonaTelefono>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }


        public Models.PersonaTelefono PersonaTelefono_Actualizar(Models.PersonaTelefono personaTelefono)
        {
            const string consulta = "PersonaTelefono_Editar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", personaTelefono.Persona.Id, SqlDbType.Int);
            b.AddParameter("@Id", personaTelefono.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", personaTelefono.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@NuevoTelefono", personaTelefono.Telefono.telefono, SqlDbType.VarChar);


            Models.PersonaTelefono resultado = new Models.PersonaTelefono();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.PersonaTelefono>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
