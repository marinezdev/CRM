using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Usuario
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Usuario Usuario_autentificar(Models.Usuario usuarios)
        {
            const string consulta = "Administracion.Usuario_autentificar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Usuario", usuarios.usuario, SqlDbType.VarChar);
            b.AddParameter("@Password", usuarios.Password, SqlDbType.VarChar);

            Models.Usuario resultado = new Models.Usuario();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Usuario>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Usuario> Usuario_Propietario_Seleccionar()
        {
            const string consulta = "Administracion.Usuario_Propietario_Seleccionar";
            b.ExecuteCommandSP(consulta);

            List<Models.Usuario> resultado = new List<Models.Usuario>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Usuario>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
