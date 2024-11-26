using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Departamento
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.Departamento> Departamento_Seleccionar_IdEmpresa(Models.Empresa empresa)
        {
            const string consulta = "Departamento_Seleccionar_IdEmpresa";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresa.Id, SqlDbType.Int);

            List<Models.Departamento> resultado = new List<Models.Departamento>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Departamento>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Departamento Departamento_Agregar(Models.Departamento departamento)
        {
            const string consulta = "Departamento_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", departamento.Empresa.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", departamento.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", departamento.Nombre, SqlDbType.VarChar);

            Models.Departamento resultado = new Models.Departamento();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Departamento>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
