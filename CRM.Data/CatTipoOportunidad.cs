using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatTipoOportunidad
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatTipoOportunidad> CatTipoOportunidad_Seleccionar()
        {
            const string consulta = "CatTipoOportunidad_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatTipoOportunidad> resultado = new List<Models.CatTipoOportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatTipoOportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CatTipoOportunidad CatTipoOportunidad_Agregar(Models.CatTipoOportunidad catTipoOportunidad)
        {
            const string consulta = "CatTipoOportunidad_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", catTipoOportunidad.Nombre, SqlDbType.VarChar);

            Models.CatTipoOportunidad resultado = new Models.CatTipoOportunidad();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatTipoOportunidad>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

    }
}
