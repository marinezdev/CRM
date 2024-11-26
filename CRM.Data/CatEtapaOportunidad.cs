using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatEtapaOportunidad
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatEtapaOportunidad> CatEtapaOportunidad_Seleccionar()
        {
            const string consulta = "CatEtapaOportunidad_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatEtapaOportunidad> resultado = new List<Models.CatEtapaOportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatEtapaOportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CatEtapaOportunidad CatEtapaOportunidad_Seleccionar_Id(Models.CatEtapaOportunidad catEtapaOportunidad)
        {
            const string consulta = "CatEtapaOportunidad_Seleccionar_Id";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", catEtapaOportunidad.Id, SqlDbType.VarChar);

            Models.CatEtapaOportunidad resultado = new Models.CatEtapaOportunidad();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatEtapaOportunidad>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
