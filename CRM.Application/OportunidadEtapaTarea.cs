using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class OportunidadEtapaTarea
    {
        Data.OportunidadEtapaTarea _OportunidadEtapaTarea = new Data.OportunidadEtapaTarea();
        public Models.OportunidadEtapaTarea OportunidadEtapaTarea_ActulizarEstatus(Models.OportunidadEtapaTarea oportunidadEtapaTarea)
        {
            return _OportunidadEtapaTarea.OportunidadEtapaTarea_ActulizarEstatus(oportunidadEtapaTarea);
        }

        public Models.OportunidadEtapaTarea OportunidadEtapaTarea_RetrocederEtapa(Models.OportunidadEtapaTarea oportunidadEtapaTarea)
        {
            return _OportunidadEtapaTarea.OportunidadEtapaTarea_RetrocederEtapa(oportunidadEtapaTarea);
        }
    }
}
