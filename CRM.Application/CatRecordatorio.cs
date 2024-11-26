using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatRecordatorio
    {
        Data.CatRecordatorio _CatRecordatorio = new Data.CatRecordatorio();
        public List<Models.CatRecordatorio> CatRecordatorio_Seleccionar()
        {
            return _CatRecordatorio.CatRecordatorio_Seleccionar();
        }
    }
}
