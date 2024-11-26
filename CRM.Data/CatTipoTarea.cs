using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatTipoTarea
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatTipoTarea> CatTipoTarea_Seleccionar()
        {
            const string consulta = "CatTipoTarea_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatTipoTarea> resultado = new List<Models.CatTipoTarea>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatTipoTarea>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
