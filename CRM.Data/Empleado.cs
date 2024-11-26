using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Empleado
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Empleado Empleado_Agregar(Models.Empleado empleado)
        {
            const string consulta = "Empleado_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", empleado.Persona.Id, SqlDbType.Int);
            b.AddParameter("@IdPuesto", empleado.Puesto.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", empleado.Usuario.Id, SqlDbType.Int);

            Models.Empleado resultado = new Models.Empleado();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Empleado>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Empleado Empleado_Eliminar(Models.Empleado empleado)
        {
            const string consulta = "Empleado_Eliminar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", empleado.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", empleado.Usuario.Id, SqlDbType.Int);

            Models.Empleado resultado = new Models.Empleado();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Empleado>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Empleado Empleado_Actualizar(Models.Empleado empleado)
        {
            const string consulta = "Empleado_Actualizar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", empleado.Id, SqlDbType.Int);
            b.AddParameter("@IdPuesto", empleado.Puesto.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", empleado.Usuario.Id, SqlDbType.Int);

            Models.Empleado resultado = new Models.Empleado();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Empleado>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Empleado Empleado_Seleccionar_Id(Models.Empleado empleado)
        {
            const string consulta = "Empleado_Seleccionar_Id";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", empleado.Id, SqlDbType.Int);

            Models.Empleado resultado = new Models.Empleado();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Empleado>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Empleado> Empleado_Seleccionar_IdPersona(Models.Empleado empleado)
        {
            const string consulta = "Empleado_Seleccionar_IdPersona";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdPersona", empleado.Persona.Id, SqlDbType.Int);

            List<Models.Empleado> resultado = new List<Models.Empleado>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Empleado>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Empleado> Empleado_Seleccionar_IdEmpresa(Models.Empresa empresa)
        {
            const string consulta = "Empleado_Seleccionar_IdEmpresa";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresa.Id, SqlDbType.Int);

            List<Models.Empleado> resultado = new List<Models.Empleado>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Empleado>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
