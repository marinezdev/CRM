using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class ReunionPersona
    {
        Data.ReunionPersona _ReunionPersona = new Data.ReunionPersona();
        public Models.ReunionPersona ReunionPersona_Agregar(Models.ReunionPersona reunionPersona)
        {
            return _ReunionPersona.ReunionPersona_Agregar(reunionPersona);
        }
    }
}
