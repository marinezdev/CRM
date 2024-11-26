using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class PersonaTelefono
    {
        Data.PersonaTelefono _PersonaTelefono = new Data.PersonaTelefono();
        public List<Models.PersonaTelefono> PersonaTelefono_Seleccionar_IdPersona(Models.Persona persona)
        {
            return _PersonaTelefono.PersonaTelefono_Seleccionar_IdPersona(persona);
        }
        public Models.PersonaTelefono PersonaTelefono_Agregar(Models.PersonaTelefono personaTelefono)
        {
            return _PersonaTelefono.PersonaTelefono_Agregar(personaTelefono);
        }
        public Models.PersonaTelefono PersonaTelefono_Eliminar(Models.PersonaTelefono personaTelefono)
        {
            return _PersonaTelefono.PersonaTelefono_Eliminar(personaTelefono);
        }

        public Models.PersonaTelefono PersonaTelefono_Actualizar(Models.PersonaTelefono personaTelefono)
        {
            return _PersonaTelefono.PersonaTelefono_Actualizar(personaTelefono);
        }
    }
}
