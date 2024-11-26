using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CorreoPersona
    {
        ManejoDatos b = new ManejoDatos();
        public Models.CorreoPersona CorreoPersona_Agregar(Models.CorreoPersona correoPersona)
        {
            const string consulta = "CorreoPersona_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdCorreo", correoPersona.Correo.Id, SqlDbType.Int);
            b.AddParameter("@IdPersona", correoPersona.Persona.Id, SqlDbType.Int);

            Models.CorreoPersona resultado = new Models.CorreoPersona();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CorreoPersona>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
