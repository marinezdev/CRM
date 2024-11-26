using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatTareaEtapa
    {
        Data.CatTareaEtapa _CatTareaEtapa = new Data.CatTareaEtapa();
        public List<Models.CatTareaEtapa> CatTareaEtapa_Seleccionar_IdEtapa(Models.CatEtapaOportunidad catEtapaOportunidad)
        {
            return _CatTareaEtapa.CatTareaEtapa_Seleccionar_IdEtapa(catEtapaOportunidad);
        }
        public Models.CatTareaEtapa CatTareaEtapa_Agregar(Models.CatTareaEtapa catTareaEtapa)
        {
            return _CatTareaEtapa.CatTareaEtapa_Agregar(catTareaEtapa);
        }

    }
}
