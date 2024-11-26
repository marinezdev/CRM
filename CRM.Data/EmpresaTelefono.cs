using CRM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class EmpresaTelefono
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.EmpresaTelefono> EmpresaTelefono_Seleccionar_IdEmpresa(Models.Empresa empresa)
        {
            const string consulta = "EmpresaTelefono_Seleccionar_IdEmpresa";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresa.Id, SqlDbType.Int);

            List<Models.EmpresaTelefono> resultado = new List<Models.EmpresaTelefono>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.EmpresaTelefono>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.EmpresaTelefono EmpresaTelefono_Eliminar(Models.EmpresaTelefono empresaTelefono)
        {
            const string consulta = "EmpresaTelefono_Eliminar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresaTelefono.Empresa.Id, SqlDbType.Int);
            b.AddParameter("@Id", empresaTelefono.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", empresaTelefono.Usuario.Id, SqlDbType.Int);

            Models.EmpresaTelefono resultado = new Models.EmpresaTelefono();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.EmpresaTelefono>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.EmpresaTelefono EmpresaTelefono_Actualizar(Models.EmpresaTelefono empresaTelefono)
        {
            const string consulta = "EmpresaTelefono_Editar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresaTelefono.Empresa.Id, SqlDbType.Int);
            b.AddParameter("@Id", empresaTelefono.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", empresaTelefono.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@NuevoTelefono", empresaTelefono.Telefono.telefono, SqlDbType.VarChar);

            Models.EmpresaTelefono resultado = new Models.EmpresaTelefono();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.EmpresaTelefono>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.EmpresaTelefono EmpresaTelefono_Agregar(Models.EmpresaTelefono empresaTelefono)
        {
            const string consulta = "EmpresaTelefono_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEmpresa", empresaTelefono.Empresa.Id, SqlDbType.Int);
            b.AddParameter("@Telefono", empresaTelefono.Telefono.telefono, SqlDbType.VarChar);
            b.AddParameter("@IdTipoTelefono", empresaTelefono.Telefono.CatTipoTelefono.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", empresaTelefono.Usuario.Id, SqlDbType.Int);

            Models.EmpresaTelefono resultado = new Models.EmpresaTelefono();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.EmpresaTelefono>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
