using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatRecordatorio
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatRecordatorio> CatRecordatorio_Seleccionar()
        {
            const string consulta = "CatRecordatorio_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatRecordatorio> resultado = new List<Models.CatRecordatorio>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatRecordatorio>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
