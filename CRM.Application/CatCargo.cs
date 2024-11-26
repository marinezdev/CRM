using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatCargo
    {
        Data.CatCargo _CatCargo = new Data.CatCargo();
        public List<Models.CatCargo> CatCargo_Seleccionar()
        {
            return _CatCargo.CatCargo_Seleccionar();
        }
        public Models.CatCargo CatCargo_Agregar(Models.CatCargo catCargo)
        {
            return _CatCargo.CatCargo_Agregar(catCargo);
        }
    }
}