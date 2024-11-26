using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class PersonaBitacora
    {
        Data.PersonaBitacora _PersonaBitacora = new Data.PersonaBitacora();
        public List<Models.PersonaBitacora> PersonaBitacora_Seleccionar(Models.Contacto contacto)
        {
            return _PersonaBitacora.PersonaBitacora_Seleccionar(contacto);
        }
    }
}
