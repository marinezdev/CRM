using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatEstatusMarketing
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatEstatusMarketing> CatEstatusMarketing_Seleccionar()
        {
            const string consulta = "CatEstatusMarketing_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatEstatusMarketing> resultado = new List<Models.CatEstatusMarketing>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatEstatusMarketing>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
