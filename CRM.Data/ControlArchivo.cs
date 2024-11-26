using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class ControlArchivo
    {
        ManejoDatos b = new ManejoDatos();

        public Models.ControlArchivo NuevoArchivo()
        {
            const string consulta = "ControlArchivo_Id";
            b.ExecuteCommandSP(consulta);

            Models.ControlArchivo resultado = new Models.ControlArchivo();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.ControlArchivo>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
