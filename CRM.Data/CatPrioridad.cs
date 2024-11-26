using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatPrioridad
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatPrioridad> CatPrioridad_Seleccionar()
        {
            const string consulta = "CatPrioridad_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatPrioridad> resultado = new List<Models.CatPrioridad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatPrioridad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
