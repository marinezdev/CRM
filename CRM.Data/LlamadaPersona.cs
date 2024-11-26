using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class LlamadaPersona
    {
        ManejoDatos b = new ManejoDatos();
        public Models.LlamadaPersona LlamadaPersona_Agregar(Models.LlamadaPersona llamadaPersona)
        {
            const string consulta = "LlamadaPersona_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdLlamada", llamadaPersona.Llamada.Id, SqlDbType.Int);
            b.AddParameter("@IdPersona", llamadaPersona.Persona.Id, SqlDbType.Int);

            Models.LlamadaPersona resultado = new Models.LlamadaPersona();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.LlamadaPersona>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
