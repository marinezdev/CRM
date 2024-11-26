using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Mensaje
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Mensaje Mensaje_Agregar(Models.Consulta.NuevoMensaje nuevoMensaje)
        {
            const string consulta = "Mensaje_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdTarea", nuevoMensaje.Tarea.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", nuevoMensaje.Mensaje.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdEntidad", nuevoMensaje.MensajeEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", nuevoMensaje.MensajeEntidad.IdValorEntidad, SqlDbType.Int);
            b.AddParameter("@IdTipo", nuevoMensaje.Mensaje.CatTipoMensaje.Id, SqlDbType.Int);
            b.AddParameter("@Descripcion", nuevoMensaje.Mensaje.Descripcion, SqlDbType.NVarChar);
            b.AddParameter("@Fecha", nuevoMensaje.Mensaje.Fecha, SqlDbType.DateTime);

            Models.Mensaje resultado = new Models.Mensaje();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Mensaje>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public List<Models.Consulta.NuevoMensaje> Mensaje_Seleccionar_Entidad_Valor(Models.MensajeEntidad mensajeEntidad)
        {
            const string consulta = "Mensaje_Seleccionar_Entidad_Valor";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEntidad", mensajeEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", mensajeEntidad.IdValorEntidad, SqlDbType.Int);

            List<Models.Consulta.NuevoMensaje> resultado = new List<Models.Consulta.NuevoMensaje>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.NuevoMensaje>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
