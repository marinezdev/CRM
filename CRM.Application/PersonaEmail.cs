using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class PersonaEmail
    {
        Data.PersonaEmail _PersonaEmail = new Data.PersonaEmail();
        public List<Models.PersonaEmail> PersonaEmail_Selecionar_Email(Models.Email email)
        {
            return _PersonaEmail.PersonaEmail_Selecionar_Email(email);
        }
        public List<Models.PersonaEmail> PersonaEmail_Seleccionar_IdPersona(Models.Persona persona)
        {
            return _PersonaEmail.PersonaEmail_Seleccionar_IdPersona(persona);
        }
        public Models.PersonaEmail PersonaEmail_Agregar(Models.PersonaEmail personaEmail)
        {
            return _PersonaEmail.PersonaEmail_Agregar(personaEmail);
        }
    }
}
