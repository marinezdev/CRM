using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class ReunionPersona
    {
        ManejoDatos b = new ManejoDatos();
        public Models.ReunionPersona ReunionPersona_Agregar(Models.ReunionPersona reunionPersona)
        {
            const string consulta = "ReunionPersona_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdReunion", reunionPersona.Reunion.Id, SqlDbType.Int);
            b.AddParameter("@IdPersona", reunionPersona.Persona.Id, SqlDbType.Int);

            Models.ReunionPersona resultado = new Models.ReunionPersona();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.ReunionPersona>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
