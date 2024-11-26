using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class OportunidadEtapaTarea
    {
        ManejoDatos b = new ManejoDatos();
        public Models.OportunidadEtapaTarea OportunidadEtapaTarea_ActulizarEstatus(Models.OportunidadEtapaTarea oportunidadEtapaTarea)
        {
            const string consulta = "OportunidadEtapaTarea_ActulizarEstatus";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidadEtapaTarea.Oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdEtapa", oportunidadEtapaTarea.CatTareaEtapa.CatEtapaOportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdEtapaTarea", oportunidadEtapaTarea.CatTareaEtapa.Id, SqlDbType.Int);
            b.AddParameter("@Estatus", oportunidadEtapaTarea.Estatus, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidadEtapaTarea.Usuario.Id, SqlDbType.Int);

            Models.OportunidadEtapaTarea resultado = new Models.OportunidadEtapaTarea();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadEtapaTarea>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.OportunidadEtapaTarea OportunidadEtapaTarea_RetrocederEtapa(Models.OportunidadEtapaTarea oportunidadEtapaTarea)
        {
            const string consulta = "OportunidadEtapaTarea_RetrocederEtapa";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidadEtapaTarea.Oportunidad.Id, SqlDbType.Int);
            b.AddParameter("@IdUsuario", oportunidadEtapaTarea.Usuario.Id, SqlDbType.Int);

            Models.OportunidadEtapaTarea resultado = new Models.OportunidadEtapaTarea();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.OportunidadEtapaTarea>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

    }
}
