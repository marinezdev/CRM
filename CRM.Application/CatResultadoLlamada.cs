using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatResultadoLlamada
    {
        Data.CatResultadoLlamada _CatResultadoLlamada = new Data.CatResultadoLlamada();
        public List<Models.CatResultadoLlamada> CatResultadoLlamada_Seleccionar()
        {
            return _CatResultadoLlamada.CatResultadoLlamada_Seleccionar();
        }
    }
}
