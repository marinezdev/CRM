using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatCP
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.Consulta.CatCP_Busqueda> CatCP_Busqueda(Models.CatCp catCp)
        {
            const string consulta = "CatCP_Busqueda";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@CP", catCp.CP, SqlDbType.VarChar);

            List<Models.Consulta.CatCP_Busqueda> resultado = new List<Models.Consulta.CatCP_Busqueda>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.CatCP_Busqueda>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.CatCp> CatCP_Seleccionar_IdColonia(Models.CatColonias catColonias)
        {
            const string consulta = "CatCP_Seleccionar_IdColonia";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdColonia", catColonias.Id, SqlDbType.VarChar);

            List<Models.CatCp> resultado = new List<Models.CatCp>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatCp>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
