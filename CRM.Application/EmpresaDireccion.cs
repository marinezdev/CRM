using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class EmpresaDireccion
    {
        Data.EmpresaDireccion _EmpresaDireccion = new Data.EmpresaDireccion();
        public Models.EmpresaDireccion EmpresaDireccion_Agregar(Models.EmpresaDireccion empresaDireccion)
        {
            return _EmpresaDireccion.EmpresaDireccion_Agregar(empresaDireccion);
        }
        public Models.EmpresaDireccion EmpresaDireccion_Eliminar(Models.EmpresaDireccion empresaDireccion)
        {
            return _EmpresaDireccion.EmpresaDireccion_Eliminar(empresaDireccion);
        }
        public List<Models.EmpresaDireccion> EmpresaDireccion_Seleccionar_IdEmpresa(Models.Empresa empresa)
        {
            return _EmpresaDireccion.EmpresaDireccion_Seleccionar_IdEmpresa(empresa);
        }
    }
}
