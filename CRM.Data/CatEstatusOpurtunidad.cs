using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatEstatusOpurtunidad
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatEstatusOpurtunidad> CatEstatusOpurtunidad_Seleccionar()
        {
            const string consulta = "CatEstatusOpurtunidad_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatEstatusOpurtunidad> resultado = new List<Models.CatEstatusOpurtunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatEstatusOpurtunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.CatEstatusOpurtunidad CatEstatusOpurtunidad_Agregar(Models.CatEstatusOpurtunidad catEstatusOpurtunidad)
        {
            const string consulta = "CatEstatusOpurtunidad_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", catEstatusOpurtunidad.Nombre, SqlDbType.VarChar);

            Models.CatEstatusOpurtunidad resultado = new Models.CatEstatusOpurtunidad();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatEstatusOpurtunidad>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
