using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Puesto
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.Puesto> Puesto_Seleccionar_IdDepartamento(Models.Departamento departamento)
        {
            const string consulta = "Puesto_Seleccionar_IdDepartamento";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdDepartamento", departamento.Id, SqlDbType.Int);

            List<Models.Puesto> resultado = new List<Models.Puesto>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Puesto>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.Puesto Puesto_Agregar(Models.Puesto puesto)
        {
            const string consulta = "Puesto_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdDepartamento", puesto.Departamento.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", puesto.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", puesto.Nombre, SqlDbType.VarChar);

            Models.Puesto resultado = new Models.Puesto();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Puesto>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
