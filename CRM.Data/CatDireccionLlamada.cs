using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatDireccionLlamada
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatDireccionLlamada> CatDireccionLlamada_Seleccionar()
        {
            const string consulta = "CatDireccionLlamada_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatDireccionLlamada> resultado = new List<Models.CatDireccionLlamada>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatDireccionLlamada>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
