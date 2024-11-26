using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class Actividades
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.Consulta.Actividades> Actividades_Selecionar_FechaRegistro(Models.Consulta.Actividades actividades)
        {
            const string consulta = "Actividades_Selecionar_FechaRegistro";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Fecha1", actividades.FechaInicio, SqlDbType.Date);
            b.AddParameter("@Fecha2", actividades.FechaTermino, SqlDbType.Date);
            b.AddParameter("@IdUnidadNegocio", actividades.CatUnidadNegocio.Id, SqlDbType.Int);

            List<Models.Consulta.Actividades> resultado = new List<Models.Consulta.Actividades>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.Actividades>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
        public Models.Consulta.Actividades Actividades_Selecionar_Valor(Models.Consulta.Actividades actividades)
        {
            const string consulta = "Actividades_Selecionar_Valor";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Id", actividades.Id, SqlDbType.Int);
            b.AddParameter("@IdEntidad", actividades.IdEntidad, SqlDbType.Int);
            b.AddParameter("@Actividad", actividades.Actividad, SqlDbType.Int);

            Models.Consulta.Actividades resultado = new Models.Consulta.Actividades();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.Consulta.Actividades>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Consulta.Actividades> Actividades_Selecionar_FechaRegistro_IdUsuario(Models.Consulta.Actividades actividades)
        {
            const string consulta = "Actividades_Selecionar_FechaRegistro_IdUsuario";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@Fecha1", actividades.FechaInicio, SqlDbType.Date);
            b.AddParameter("@Fecha2", actividades.FechaTermino, SqlDbType.Date);
            b.AddParameter("@IdUsuario", actividades.Usuario.Id, SqlDbType.Int);

            List<Models.Consulta.Actividades> resultado = new List<Models.Consulta.Actividades>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.Actividades>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
