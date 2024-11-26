using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatNumeroEmpleados
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatNumeroEmpleados> CatNumeroEmpleados_Seleccionar()
        {
            const string consulta = "CatNumeroEmpleados_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.CatNumeroEmpleados> resultado = new List<Models.CatNumeroEmpleados>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatNumeroEmpleados>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
