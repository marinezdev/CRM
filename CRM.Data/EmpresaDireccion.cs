using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class EmpresaDireccion
    {
        ManejoDatos b = new ManejoDatos();
        public Models.EmpresaDireccion EmpresaDireccion_Agregar(Models.EmpresaDireccion empresaDireccion)
        {
            const string consulta = "EmpresaDireccion_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresaDireccion.Empresa.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", empresaDireccion.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", empresaDireccion.Nombre, SqlDbType.NVarChar);
            b.AddParameter("@NumExterior", empresaDireccion.NumExterior, SqlDbType.NVarChar);
            b.AddParameter("@NumInterior", empresaDireccion.NumInterior, SqlDbType.NVarChar);
            b.AddParameter("@Calle", empresaDireccion.Calle, SqlDbType.NVarChar);
            b.AddParameter("@IdColonia", empresaDireccion.CatColonias.Id, SqlDbType.Int);

            Models.EmpresaDireccion resultado = new Models.EmpresaDireccion();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.EmpresaDireccion>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.EmpresaDireccion EmpresaDireccion_Eliminar(Models.EmpresaDireccion empresaDireccion)
        {
            const string consulta = "EmpresaDireccion_Eliminar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresaDireccion.Empresa.Id, SqlDbType.Int);
            b.AddParameter("@Id", empresaDireccion.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", empresaDireccion.Usuario.Id, SqlDbType.Int);

            Models.EmpresaDireccion resultado = new Models.EmpresaDireccion();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.EmpresaDireccion>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.EmpresaDireccion> EmpresaDireccion_Seleccionar_IdEmpresa(Models.Empresa empresa)
        {
            const string consulta = "EmpresaDireccion_Seleccionar_IdEmpresa";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresa.Id, SqlDbType.Int);

            List<Models.EmpresaDireccion> resultado = new List<Models.EmpresaDireccion>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.EmpresaDireccion>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
