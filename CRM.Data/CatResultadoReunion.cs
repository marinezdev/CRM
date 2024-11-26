using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatResultadoReunion
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatResultadoReunion> CatResultadoReunion_Seleccionar()
        {
            const string consulta = "CatResultadoReunion_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatResultadoReunion> resultado = new List<Models.CatResultadoReunion>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatResultadoReunion>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
