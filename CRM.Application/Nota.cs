using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Nota
    {
        Data.Nota _Nota = new Data.Nota();
        public Models.Nota Nota_Agregar(Models.NotaEntidad notaEntidad)
        {
            return _Nota.Nota_Agregar(notaEntidad);
        }
        public List<Models.Nota> Nota_Seleccionar_Entidad_Valor(Models.NotaEntidad notaEntidad)
        {
            return _Nota.Nota_Seleccionar_Entidad_Valor(notaEntidad);
        }
    }
}
