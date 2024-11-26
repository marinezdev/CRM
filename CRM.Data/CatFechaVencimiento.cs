using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatFechaVencimiento
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatFechaVencimiento> CatFechaVencimiento_Seleccionar()
        {
            const string consulta = "CatFechaVencimiento_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatFechaVencimiento> resultado = new List<Models.CatFechaVencimiento>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatFechaVencimiento>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
