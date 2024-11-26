using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class EmpresaTelefono
    {
        Data.EmpresaTelefono _EmpresaTelefono = new Data.EmpresaTelefono();
        public List<Models.EmpresaTelefono> EmpresaTelefono_Seleccionar_IdEmpresa(Models.Empresa empresa)
        {
            return _EmpresaTelefono.EmpresaTelefono_Seleccionar_IdEmpresa(empresa);
        }

        public Models.EmpresaTelefono EmpresaTelefono_Eliminar(Models.EmpresaTelefono empresaTelefono)
        {
            return _EmpresaTelefono.EmpresaTelefono_Eliminar(empresaTelefono);
        }

        public Models.EmpresaTelefono EmpresaTelefono_Actualizar(Models.EmpresaTelefono empresaTelefono)
        {
            return _EmpresaTelefono.EmpresaTelefono_Actualizar(empresaTelefono);
        }
        

        public Models.EmpresaTelefono EmpresaTelefono_Agregar(Models.EmpresaTelefono empresaTelefono)
        {
            return _EmpresaTelefono.EmpresaTelefono_Agregar(empresaTelefono);
        }
    }
}
