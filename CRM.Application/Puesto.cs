using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Puesto
    {
        Data.Puesto _Puesto = new Data.Puesto();
        public List<Models.Puesto> Puesto_Seleccionar_IdDepartamento(Models.Departamento departamento)
        {
            return _Puesto.Puesto_Seleccionar_IdDepartamento(departamento);
        }

        public Models.Puesto Puesto_Agregar(Models.Puesto puesto)
        {
            return _Puesto.Puesto_Agregar(puesto);
        }
    }
}
