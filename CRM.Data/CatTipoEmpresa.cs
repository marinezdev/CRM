using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatTipoEmpresa
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatTipoEmpresa> CatTipoEmpresa_Seleccionar()
        {
            const string consulta = "CatTipoEmpresa_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatTipoEmpresa> resultado = new List<Models.CatTipoEmpresa>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatTipoEmpresa>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CatTipoEmpresa CatTipoEmpresa_Agregar(Models.CatTipoEmpresa catTipoEmpresa)
        {
            const string consulta = "CatTipoEmpresa_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", catTipoEmpresa.Nombre, SqlDbType.VarChar);

            Models.CatTipoEmpresa resultado = new Models.CatTipoEmpresa();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatTipoEmpresa>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

    }
}
