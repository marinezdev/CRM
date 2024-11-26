using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class MensajePersona
    {
        Data.MensajePersona _MensajePersona = new Data.MensajePersona();
        public Models.MensajePersona MensajePersona_Agregar(Models.MensajePersona mensajePersona)
        {
            return _MensajePersona.MensajePersona_Agregar(mensajePersona);
        }
    }
}
