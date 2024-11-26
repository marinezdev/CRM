using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatIndustria
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatIndustria> CatIndustria_Seleccionar()
        {
            const string consulta = "CatIndustria_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatIndustria> resultado = new List<Models.CatIndustria>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatIndustria>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CatIndustria CatIndustria_Agregar(Models.CatIndustria catIndustria)
        {
            const string consulta = "CatIndustria_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", catIndustria.Nombre, SqlDbType.VarChar);

            Models.CatIndustria resultado = new Models.CatIndustria();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatIndustria>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
