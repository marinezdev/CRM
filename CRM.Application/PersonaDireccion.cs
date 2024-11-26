using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class PersonaDireccion
    {
        Data.PersonaDireccion _PersonaDireccion = new Data.PersonaDireccion();
        public Models.PersonaDireccion PersonaDireccion_Agregar(Models.PersonaDireccion personaDireccion)
        {
            return _PersonaDireccion.PersonaDireccion_Agregar(personaDireccion);
        }
        public List<Models.PersonaDireccion> PersonaDireccion_Seleccionar_IdPersona(Models.Persona persona)
        {
            return _PersonaDireccion.PersonaDireccion_Seleccionar_IdPersona(persona);
        }
        public Models.PersonaDireccion PersonaDireccion_Eliminar(Models.PersonaDireccion personaDireccion)
        {
            return _PersonaDireccion.PersonaDireccion_Eliminar(personaDireccion);
        }
    }
}
