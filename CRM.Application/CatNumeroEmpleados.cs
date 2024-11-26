using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatNumeroEmpleados
    {
        Data.CatNumeroEmpleados _CatNumeroEmpleados = new Data.CatNumeroEmpleados();

        public List<Models.CatNumeroEmpleados> CatNumeroEmpleados_Seleccionar()
        {
            return _CatNumeroEmpleados.CatNumeroEmpleados_Seleccionar();
        }
    }
}
