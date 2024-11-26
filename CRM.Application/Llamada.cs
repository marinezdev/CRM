using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Llamada
    {
        Data.Llamada _Llamada = new Data.Llamada();
        public Models.Llamada Llamada_Agregar(Models.Consulta.NuevaLlamada nuevaLlamada)
        {
            return _Llamada.Llamada_Agregar(nuevaLlamada);
        }
        public List<Models.Consulta.NuevaLlamada> Llamada_Seleccionar_Entidad_Valor(Models.LlamadaEntidad llamadaEntidad)
        {
            return _Llamada.Llamada_Seleccionar_Entidad_Valor(llamadaEntidad);
        }
    }
}
