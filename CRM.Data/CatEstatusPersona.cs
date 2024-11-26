using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatEstatusPersona
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatEstatusPersona> CatEstatusPersona_Seleccionar()
        {
            const string consulta = "CatEstatusPersona_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatEstatusPersona> resultado = new List<Models.CatEstatusPersona>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatEstatusPersona>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.CatEstatusPersona CatEstatusPersona_Agregar(Models.CatEstatusPersona catEstatusPersona)
        {
            const string consulta = "CatEstatusPersona_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", catEstatusPersona.Nombre, SqlDbType.VarChar);

            Models.CatEstatusPersona resultado = new Models.CatEstatusPersona();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatEstatusPersona>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
