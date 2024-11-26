using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class LlamadaPersona
    {
        Data.LlamadaPersona _LlamadaPersona = new Data.LlamadaPersona();
        public Models.LlamadaPersona LlamadaPersona_Agregar(Models.LlamadaPersona llamadaPersona)
        {
            return _LlamadaPersona.LlamadaPersona_Agregar(llamadaPersona);
        }
    }
}
