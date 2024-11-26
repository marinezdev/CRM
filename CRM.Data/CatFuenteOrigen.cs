using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatFuenteOrigen
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatFuenteOrigen> CatFuenteOrigen_Seleccionar()
        {
            const string consulta = "CatFuenteOrigen_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatFuenteOrigen> resultado = new List<Models.CatFuenteOrigen>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatFuenteOrigen>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CatFuenteOrigen CatFuenteOrigen_Agregar(Models.CatFuenteOrigen catFuenteOrigen)
        {
            const string consulta = "CatFuenteOrigen_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", catFuenteOrigen.Nombre, SqlDbType.VarChar);

            Models.CatFuenteOrigen resultado = new Models.CatFuenteOrigen();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatFuenteOrigen>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
