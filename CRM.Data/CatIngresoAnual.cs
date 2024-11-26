using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatIngresoAnual
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatIngresoAnual> CatIngresoAnual_Seleccionar()
        {
            const string consulta = "CatIngresoAnual_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatIngresoAnual> resultado = new List<Models.CatIngresoAnual>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatIngresoAnual>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
