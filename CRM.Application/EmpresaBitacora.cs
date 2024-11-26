using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class EmpresaBitacora
    {
        Data.EmpresaBitacora _EmpresaBitacora = new Data.EmpresaBitacora();
        public List<Models.EmpresaBitacora> PersonaBitacora_Seleccionar(Models.Empresa empresa)
        {
            return _EmpresaBitacora.PersonaBitacora_Seleccionar(empresa);
        }
    }
}
