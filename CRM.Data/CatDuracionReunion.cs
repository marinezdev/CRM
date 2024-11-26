using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatDuracionReunion
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatDuracionReunion> CatDuracionReunion_Seleccionar()
        {
            const string consulta = "CatDuracionReunion_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatDuracionReunion> resultado = new List<Models.CatDuracionReunion>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatDuracionReunion>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
