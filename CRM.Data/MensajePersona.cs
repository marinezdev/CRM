using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class MensajePersona
    {
        ManejoDatos b = new ManejoDatos();
        public Models.MensajePersona MensajePersona_Agregar(Models.MensajePersona mensajePersona)
        {
            const string consulta = "MensajePersona_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdMensaje", mensajePersona.Mensaje.Id, SqlDbType.Int);
            b.AddParameter("@IdPersona", mensajePersona.Persona.Id, SqlDbType.Int);

            Models.MensajePersona resultado = new Models.MensajePersona();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.MensajePersona>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
