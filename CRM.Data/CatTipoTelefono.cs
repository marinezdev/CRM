using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatTipoTelefono
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatTipoTelefono> CatTipoTelefono_Seleccionar()
        {
            const string consulta = "CatTipoTelefono_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatTipoTelefono> resultado = new List<Models.CatTipoTelefono>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatTipoTelefono>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CatTipoTelefono CatTipoTelefono_Agregar(Models.CatTipoTelefono catTipoTelefono)
        {
            const string consulta = "CatTipoTelefono_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Nombre", catTipoTelefono.Nombre, SqlDbType.VarChar);

            Models.CatTipoTelefono resultado = new Models.CatTipoTelefono();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatTipoTelefono>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
