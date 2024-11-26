using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatTipoReunion
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatTipoReunion> CatTipoReunion_Seleccionar()
        {
            const string consulta = "CatTipoReunion_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatTipoReunion> resultado = new List<Models.CatTipoReunion>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatTipoReunion>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
