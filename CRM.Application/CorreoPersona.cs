using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CorreoPersona
    {
        Data.CorreoPersona _CorreoPersona = new Data.CorreoPersona();

        public Models.CorreoPersona CorreoPersona_Agregar(Models.CorreoPersona correoPersona)
        {
            return _CorreoPersona.CorreoPersona_Agregar(correoPersona);
        }
    }
}
