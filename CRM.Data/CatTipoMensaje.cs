using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatTipoMensaje
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatTipoMensaje> CatTipoMensaje_Seleccionar()
        {
            const string consulta = "CatTipoMensaje_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatTipoMensaje> resultado = new List<Models.CatTipoMensaje>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatTipoMensaje>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
