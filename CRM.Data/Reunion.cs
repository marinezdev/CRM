using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Reunion
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Reunion Reunion_Agregar(Models.Consulta.NuevaReunion nuevaReunion)
        {
            const string consulta = "Reunion_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdTarea", nuevaReunion.Tarea.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", nuevaReunion.Reunion.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdEntidad", nuevaReunion.ReunionEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", nuevaReunion.ReunionEntidad.IdValorEntidad, SqlDbType.Int);
            b.AddParameter("@IdResultado", nuevaReunion.Reunion.CatResultadoReunion.Id, SqlDbType.Int);
            b.AddParameter("@IdDuracion", nuevaReunion.Reunion.CatDuracionReunion.Id, SqlDbType.Int);
            b.AddParameter("@IdTipo", nuevaReunion.Reunion.CatTipoReunion.Id, SqlDbType.Int);
            b.AddParameter("@Descripcion", nuevaReunion.Reunion.Descripcion, SqlDbType.NVarChar);
            b.AddParameter("@Fecha", nuevaReunion.Reunion.Fecha, SqlDbType.DateTime);

            Models.Reunion resultado = new Models.Reunion();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Reunion>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Consulta.NuevaReunion> Reunion_Seleccionar_Entidad_Valor(Models.ReunionEntidad reunionEntidad)
        {
            const string consulta = "Reunion_Seleccionar_Entidad_Valor";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEntidad", reunionEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", reunionEntidad.IdValorEntidad, SqlDbType.Int);

            List<Models.Consulta.NuevaReunion> resultado = new List<Models.Consulta.NuevaReunion>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.NuevaReunion>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
