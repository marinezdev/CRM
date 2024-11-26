using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Data
{
    public class OportunidadEtapa
    {
        ManejoDatos b = new ManejoDatos();
        public List<Models.Consulta.Etapas> OportunidadEtapa_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad)
        {
            const string consulta = "OportunidadEtapa_Seleccionar_IdOportunidad";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdOportunidad", oportunidad.Id, SqlDbType.VarChar);

            List<Models.Consulta.Etapas> resultado = new List<Models.Consulta.Etapas>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.Etapas>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Consulta.EtapaOportunidad> Funnel_Ventas()
        {
            const string consulta = "Funnel_Ventas";
            b.ExecuteCommandSP(consulta);

            List<Models.Consulta.EtapaOportunidad> resultado = new List<Models.Consulta.EtapaOportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.EtapaOportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }

        public List<Models.Consulta.EtapaOportunidad> Funnel_Ventas_UnidadNegocio(Models.CatUnidadNegocio catUnidadNegocio)
        {
            const string consulta = "Funnel_Ventas_UnidadNegocio";
            b.ExecuteCommandSP(consulta);
            b.AddParameter("@IdUnidadNegocio", catUnidadNegocio.Id, SqlDbType.VarChar);

            List<Models.Consulta.EtapaOportunidad> resultado = new List<Models.Consulta.EtapaOportunidad>();
            var reader = b.ExecuteReader();
            if (reader.Read())
            {
                resultado = JsonConvert.DeserializeObject<List<Models.Consulta.EtapaOportunidad>>(reader.GetValue(0).ToString());
            }
            reader = null;
            b.ConnectionCloseToTransaction();
            return resultado;
        }
    }
}
