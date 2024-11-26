using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class OportunidadEmpresa
    {
        Data.OportunidadEmpresa _OportunidadEmpresa = new Data.OportunidadEmpresa();
        public Models.OportunidadEmpresa OportunidadEmpresa_Agregar(Models.OportunidadEmpresa oportunidadEmpresa)
        {
            return _OportunidadEmpresa.OportunidadEmpresa_Agregar(oportunidadEmpresa);
        }
        public Models.OportunidadEmpresa OportunidadEmpresa_Eliminar(Models.OportunidadEmpresa oportunidadEmpresa)
        {
            return _OportunidadEmpresa.OportunidadEmpresa_Eliminar(oportunidadEmpresa);
        }
        public List<Models.OportunidadEmpresa> OportunidadEmpresa_Seleccionar_IdEmpresa(Models.Empresa empresa)
        {
            return _OportunidadEmpresa.OportunidadEmpresa_Seleccionar_IdEmpresa(empresa);
        }

        public List<Models.OportunidadEmpresa> OportunidadEmpresa_Seleccionar_IdEmpresa_Year(Models.Empresa empresa)
        {
            return _OportunidadEmpresa.OportunidadEmpresa_Seleccionar_IdEmpresa_Year(empresa);
        }
        public List<Models.OportunidadEmpresa> OportunidadEmpresa_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad)
        {
            return _OportunidadEmpresa.OportunidadEmpresa_Seleccionar_IdOportunidad(oportunidad);
        }
    }
}
