using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatEstatusMarketing
    {
        Data.CatEstatusMarketing _CatEstatusMarketing = new Data.CatEstatusMarketing();
        public List<Models.CatEstatusMarketing> CatEstatusMarketing_Seleccionar()
        {
            return _CatEstatusMarketing.CatEstatusMarketing_Seleccionar();
        }
    }
}
