using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatTipoPersona
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatTipoPersona> CatTipoPersona_Seleccionar()
        {
            const string consulta = "CatTipoPersona_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatTipoPersona> resultado = new List<Models.CatTipoPersona>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatTipoPersona>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CatTipoPersona CatTipoPersona_Agregar(Models.CatTipoPersona catTipoPersona)
        {
            const string consulta = "CatTipoPersona_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", catTipoPersona.Nombre, SqlDbType.VarChar);

            Models.CatTipoPersona resultado = new Models.CatTipoPersona();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatTipoPersona>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
