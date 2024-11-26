using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Correo
    {
        Data.Correo _Correo = new Data.Correo();

        public Models.Correo Correo_Agregar(Models.Consulta.NuevoCorreo nuevoCorreo)
        {
            return _Correo.Correo_Agregar(nuevoCorreo);
        }

        public List<Models.Consulta.NuevoCorreo> Correo_Seleccionar_Entidad_Valor(Models.CorreoEntidad correoEntidad)
        {
            return _Correo.Correo_Seleccionar_Entidad_Valor(correoEntidad);
        }
    }
}
