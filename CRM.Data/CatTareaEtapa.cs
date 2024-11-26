using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class CatTareaEtapa
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.CatTareaEtapa> CatTareaEtapa_Seleccionar_IdEtapa(Models.CatEtapaOportunidad catEtapaOportunidad)
        {
            const string consulta = "CatTareaEtapa_Seleccionar_IdEtapa";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEtapa", catEtapaOportunidad.Id, SqlDbType.VarChar);

            List<Models.CatTareaEtapa> resultado = new List<Models.CatTareaEtapa>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.CatTareaEtapa>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public Models.CatTareaEtapa CatTareaEtapa_Agregar(Models.CatTareaEtapa catTareaEtapa)
        {
            const string consulta = "CatTareaEtapa_Agregar";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdEtapa", catTareaEtapa.CatEtapaOportunidad.Id, SqlDbType.Int);
            b.AddParameter("@Nombre", catTareaEtapa.Nombre, SqlDbType.VarChar);

            Models.CatTareaEtapa resultado = new Models.CatTareaEtapa();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<Models.CatTareaEtapa>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

    }
}
