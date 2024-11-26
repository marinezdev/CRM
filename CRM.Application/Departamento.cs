using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Departamento
    {
        Data.Departamento _Departamento = new Data.Departamento();
        public List<Models.Departamento> Departamento_Seleccionar_IdEmpresa(Models.Empresa empresa)
        {
            return _Departamento.Departamento_Seleccionar_IdEmpresa(empresa);
        }
        public Models.Departamento Departamento_Agregar(Models.Departamento departamento)
        {
            return _Departamento.Departamento_Agregar(departamento);
        }
    }
}
