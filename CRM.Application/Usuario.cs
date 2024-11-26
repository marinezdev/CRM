using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Usuario
    {
        Data.Usuario _usuario = new Data.Usuario();
        public Models.Usuario Iniciar(Models.Usuario usuario)
        {
            return _usuario.Usuario_autentificar(usuario);
        }

        public List<Models.Usuario> Usuario_Propietario_Seleccionar()
        {
            return _usuario.Usuario_Propietario_Seleccionar();
        }
    }
}
