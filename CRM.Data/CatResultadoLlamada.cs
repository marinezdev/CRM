using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatResultadoLlamada
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatResultadoLlamada> CatResultadoLlamada_Seleccionar()
        {
            const string consulta = "CatResultadoLlamada_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatResultadoLlamada> resultado = new List<Models.CatResultadoLlamada>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatResultadoLlamada>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
