using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class OportunidadEtapa
    {
        Data.OportunidadEtapa _OportunidadEtapaa = new Data.OportunidadEtapa();
        public List<Models.Consulta.Etapas> OportunidadEtapa_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad)
        {
            return _OportunidadEtapaa.OportunidadEtapa_Seleccionar_IdOportunidad(oportunidad);
        }
        public List<Models.Consulta.EtapaOportunidad> Funnel_Ventas()
        {
            return _OportunidadEtapaa.Funnel_Ventas();
        }
        public List<Models.Consulta.EtapaOportunidad> Funnel_Ventas_UnidadNegocio(Models.CatUnidadNegocio catUnidadNegocio)
        {
            return _OportunidadEtapaa.Funnel_Ventas_UnidadNegocio(catUnidadNegocio);
        }
    }
}
