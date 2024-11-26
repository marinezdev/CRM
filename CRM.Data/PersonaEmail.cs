using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class PersonaEmail
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.PersonaEmail> PersonaEmail_Selecionar_Email(Models.Email email)
        {
            const string consulta = "PersonaEmail_Selecionar_Email";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Email", email.email, SqlDbType.VarChar);

            List<Models.PersonaEmail> resultado = new List<Models.PersonaEmail>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.PersonaEmail>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.PersonaEmail> PersonaEmail_Seleccionar_IdPersona(Models.Persona persona)
        {
            const string consulta = "PersonaEmail_Seleccionar_IdPersona";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", persona.Id, SqlDbType.Int);

            List<Models.PersonaEmail> resultado = new List<Models.PersonaEmail>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.PersonaEmail>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.PersonaEmail PersonaEmail_Agregar(Models.PersonaEmail personaEmail)
        {
            const string consulta = "PersonaEmail_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", personaEmail.Persona.Id, SqlDbType.Int);
            b.AddParameter("@Email", personaEmail.Email.email, SqlDbType.VarChar);
            b.AddParameter("@IdUsuario", personaEmail.Usuario.Id, SqlDbType.VarChar);

            Models.PersonaEmail resultado = new Models.PersonaEmail();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.PersonaEmail>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
