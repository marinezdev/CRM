using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatDireccionLlamada
    {
        Data.CatDireccionLlamada _CatDireccionLlamada = new Data.CatDireccionLlamada();
        public List<Models.CatDireccionLlamada> CatDireccionLlamada_Seleccionar()
        {
            return _CatDireccionLlamada.CatDireccionLlamada_Seleccionar();
        }
    }
}
