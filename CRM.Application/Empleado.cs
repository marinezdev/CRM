using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class Empleado
    {
        Data.Empleado _Empleado = new Data.Empleado();
        public Models.Empleado Empleado_Agregar(Models.Empleado empleado)
        {
            return _Empleado.Empleado_Agregar(empleado);
        }
        public Models.Empleado Empleado_Eliminar(Models.Empleado empleado)
        {
            return _Empleado.Empleado_Eliminar(empleado);
        }
        public Models.Empleado Empleado_Actualizar(Models.Empleado empleado)
        {
            return _Empleado.Empleado_Actualizar(empleado);
        }
        public Models.Empleado Empleado_Seleccionar_Id(Models.Empleado empleado)
        {
            return _Empleado.Empleado_Seleccionar_Id(empleado);
        }
        public List<Models.Empleado> Empleado_Seleccionar_IdPersona(Models.Empleado empleado)
        {
            return _Empleado.Empleado_Seleccionar_IdPersona(empleado);
        }
        public List<Models.Empleado> Empleado_Seleccionar_IdEmpresa(Models.Empresa empresa)
        {
            return _Empleado.Empleado_Seleccionar_IdEmpresa(empresa);
        }
    }
}
