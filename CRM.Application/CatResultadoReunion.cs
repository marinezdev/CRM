using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatResultadoReunion
    {
        Data.CatResultadoReunion _CatResultadoReunion = new Data.CatResultadoReunion();

        public List<Models.CatResultadoReunion> CatResultadoReunion_Seleccionar()
        {
            return _CatResultadoReunion.CatResultadoReunion_Seleccionar();
        }
    }
}
