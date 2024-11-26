using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Llamada
    {
        ManejoDatos b = new ManejoDatos();
        public Models.Llamada Llamada_Agregar(Models.Consulta.NuevaLlamada nuevaLlamada)
        {
            const string consulta = "Llamada_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdTarea", nuevaLlamada.Tarea.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", nuevaLlamada.Llamada.Usuario.Id, SqlDbType.Int);
            b.AddParameter("@IdEntidad", nuevaLlamada.LlamadaEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", nuevaLlamada.LlamadaEntidad.IdValorEntidad, SqlDbType.Int);
            b.AddParameter("@IdResultado", nuevaLlamada.Llamada.CatResultadoLlamada.Id, SqlDbType.Int);
            b.AddParameter("@IdDireccion", nuevaLlamada.Llamada.CatDireccionLlamada.Id, SqlDbType.Int);
            b.AddParameter("@Descripcion", nuevaLlamada.Llamada.Descripcion, SqlDbType.NVarChar);
            b.AddParameter("@Fecha", nuevaLlamada.Llamada.Fecha, SqlDbType.DateTime);

            Models.Llamada resultado = new Models.Llamada();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Llamada>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Consulta.NuevaLlamada> Llamada_Seleccionar_Entidad_Valor(Models.LlamadaEntidad llamadaEntidad)
        {
            const string consulta = "Llamada_Seleccionar_Entidad_Valor";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEntidad", llamadaEntidad.CatEntidad.Id, SqlDbType.Int);
            b.AddParameter("@IdValorEntidad", llamadaEntidad.IdValorEntidad, SqlDbType.Int);

            List<Models.Consulta.NuevaLlamada> resultado = new List<Models.Consulta.NuevaLlamada>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.NuevaLlamada>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
