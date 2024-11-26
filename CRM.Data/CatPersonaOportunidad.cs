using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatPersonaOportunidad
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatPersonaOportunidad> CatPersonaOportunidad_Seleccionar()
        {
            const string consulta = "CatPersonaOportunidad_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatPersonaOportunidad> resultado = new List<Models.CatPersonaOportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatPersonaOportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CatPersonaOportunidad CatPersonaOportunidad_Agregar(Models.CatPersonaOportunidad catPersonaOportunidad)
        {
            const string consulta = "CatPersonaOportunidad_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", catPersonaOportunidad.Nombre, SqlDbType.VarChar);

            Models.CatPersonaOportunidad resultado = new Models.CatPersonaOportunidad();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatPersonaOportunidad>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
