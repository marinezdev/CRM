using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class ObjetivosResponsables
    {
        Data.ObjetivosResponsables _ObjetivosResponsables = new Data.ObjetivosResponsables();
        public Models.ObjetivosResponsables ObjetivosResponsables_Agregar(Models.ObjetivosResponsables objetivosResponsables)
        {
            return _ObjetivosResponsables.ObjetivosResponsables_Agregar(objetivosResponsables);
        }

        public Models.ObjetivosResponsables ObjetivosResponsables_Seleccionar_Id(Models.ObjetivosResponsables objetivosResponsables)
        {
            return _ObjetivosResponsables.ObjetivosResponsables_Seleccionar_Id(objetivosResponsables);
        }

        public Models.ObjetivosResponsables ObjetivosResponsables_Actualizar(Models.ObjetivosResponsables objetivosResponsables)
        {
            return _ObjetivosResponsables.ObjetivosResponsables_Actualizar(objetivosResponsables);
        }

        public List<Models.ObjetivosResponsables> ObjetivosResponsables_Selecionar_Year()
        {
            return _ObjetivosResponsables.ObjetivosResponsables_Selecionar_Year();
        }

        public List<Models.ObjetivosResponsables> ObjetivosResponsables_Reporte_Year(int year)
        {
            return _ObjetivosResponsables.ObjetivosResponsables_Reporte_Year(year);
        }
    }
}
