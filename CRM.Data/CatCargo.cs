using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatCargo
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatCargo> CatCargo_Seleccionar()
        {
            const string consulta = "CatCargo_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatCargo> resultado = new List<Models.CatCargo>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatCargo>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.CatCargo CatCargo_Agregar(Models.CatCargo catCargo)
        {
            const string consulta = "CatCargo_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", catCargo.Nombre, SqlDbType.VarChar);

            Models.CatCargo resultado = new Models.CatCargo();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatCargo>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
