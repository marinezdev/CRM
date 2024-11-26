using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Mensaje
    {
        Data.Mensaje _Mensaje = new Data.Mensaje();
        public Models.Mensaje Mensaje_Agregar(Models.Consulta.NuevoMensaje nuevoMensaje)
        {
            return _Mensaje.Mensaje_Agregar(nuevoMensaje);
        }
        public List<Models.Consulta.NuevoMensaje> Mensaje_Seleccionar_Entidad_Valor(Models.MensajeEntidad mensajeEntidad)
        {
            return _Mensaje.Mensaje_Seleccionar_Entidad_Valor(mensajeEntidad);
        }
    }
}
