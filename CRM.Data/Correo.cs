using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Correo
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Correo Correo_Agregar(Models.Consulta.NuevoCorreo nuevoCorreo)
        {
            const string consulta = "Correo_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdTarea", nuevoCorreo.Tarea.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", nuevoCorreo.Correo.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdEntidad", nuevoCorreo.CorreoEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", nuevoCorreo.CorreoEntidad.IdValorEntidad, SqlDbType.Int);
            b.AddParameter("@Mensaje", nuevoCorreo.Correo.Mensaje, SqlDbType.NVarChar);
            b.AddParameter("@FechaEnvio", nuevoCorreo.Correo.FechaEnvio, SqlDbType.DateTime);

            Models.Correo resultado = new Models.Correo();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Correo>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Consulta.NuevoCorreo> Correo_Seleccionar_Entidad_Valor(Models.CorreoEntidad correoEntidad)
        {
            const string consulta = "Correo_Seleccionar_Entidad_Valor";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEntidad", correoEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", correoEntidad.IdValorEntidad, SqlDbType.Int);

            List<Models.Consulta.NuevoCorreo> resultado = new List<Models.Consulta.NuevoCorreo>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.NuevoCorreo>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
