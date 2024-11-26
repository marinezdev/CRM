using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Reunion
    {
        Data.Reunion _Reunion = new Data.Reunion();
        public Models.Reunion Reunion_Agregar(Models.Consulta.NuevaReunion nuevaReunion)
        {
            return _Reunion.Reunion_Agregar(nuevaReunion);
        }
        public List<Models.Consulta.NuevaReunion> Reunion_Seleccionar_Entidad_Valor(Models.ReunionEntidad reunionEntidad)
        {
            return _Reunion.Reunion_Seleccionar_Entidad_Valor(reunionEntidad);
        }
    }
}
