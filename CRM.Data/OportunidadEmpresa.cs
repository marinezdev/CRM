using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class OportunidadEmpresa
    {
        ManejoDatos b = new ManejoDatos();

        public Models.OportunidadEmpresa OportunidadEmpresa_Agregar(Models.OportunidadEmpresa oportunidadEmpresa)
        {
            const string consulta = "OportunidadEmpresa_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidadEmpresa.Oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdEmpresa", oportunidadEmpresa.Empresa.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidadEmpresa.Usuario.Id, SqlDbType.Int);

            Models.OportunidadEmpresa resultado = new Models.OportunidadEmpresa();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadEmpresa>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.OportunidadEmpresa OportunidadEmpresa_Eliminar(Models.OportunidadEmpresa oportunidadEmpresa)
        {
            const string consulta = "OportunidadEmpresa_Eliminar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidadEmpresa.Oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@Id", oportunidadEmpresa.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidadEmpresa.Usuario.Id, SqlDbType.Int);

            Models.OportunidadEmpresa resultado = new Models.OportunidadEmpresa();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadEmpresa>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.OportunidadEmpresa> OportunidadEmpresa_Seleccionar_IdEmpresa(Models.Empresa empresa)
        {
            const string consulta = "OportunidadEmpresa_Seleccionar_IdEmpresa";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresa.Id, SqlDbType.Int);

            List<Models.OportunidadEmpresa> resultado = new List<Models.OportunidadEmpresa>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.OportunidadEmpresa>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.OportunidadEmpresa> OportunidadEmpresa_Seleccionar_IdEmpresa_Year(Models.Empresa empresa)
        {
            const string consulta = "OportunidadEmpresa_Seleccionar_IdEmpresa_Year";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresa.Id, SqlDbType.Int);

            List<Models.OportunidadEmpresa> resultado = new List<Models.OportunidadEmpresa>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.OportunidadEmpresa>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.OportunidadEmpresa> OportunidadEmpresa_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad)
        {
            const string consulta = "OportunidadEmpresa_Seleccionar_IdOportunidad";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidad.Id, SqlDbType.Int);

            List<Models.OportunidadEmpresa> resultado = new List<Models.OportunidadEmpresa>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.OportunidadEmpresa>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
