using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class EmpresaBitacora
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.EmpresaBitacora> PersonaBitacora_Seleccionar(Models.Empresa empresa)
        {
            const string consulta = "EmpresaBitacora_Seleccionar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresa.Id, SqlDbType.NVarChar);

            List<Models.EmpresaBitacora> resultado = new List<Models.EmpresaBitacora>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.EmpresaBitacora>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

    }
}
