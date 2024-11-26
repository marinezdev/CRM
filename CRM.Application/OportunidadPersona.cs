using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class OportunidadPersona
    {
        Data.OportunidadPersona _OportunidadPersona = new Data.OportunidadPersona();

        public Models.OportunidadPersona OportunidadPersona_Agregar(Models.OportunidadPersona oportunidadPersona)
        {
            return _OportunidadPersona.OportunidadPersona_Agregar(oportunidadPersona);
        }
        public Models.OportunidadPersona OportunidadPersona_Editar(Models.OportunidadPersona oportunidadPersona)
        {
            return _OportunidadPersona.OportunidadPersona_Editar(oportunidadPersona);
        }
        public Models.OportunidadPersona OportunidadPersona_Eliminar(Models.OportunidadPersona oportunidadPersona)
        {
            return _OportunidadPersona.OportunidadPersona_Eliminar(oportunidadPersona);
        }
        public Models.OportunidadPersona OportunidadPersona_Seleccionar_Id(Models.OportunidadPersona oportunidadPersona)
        {
            return _OportunidadPersona.OportunidadPersona_Seleccionar_Id(oportunidadPersona);
        }
        public List<Models.OportunidadPersona> OportunidadPersona_Seleccionar_IdOportunidad(Models.Oportunidad oportunidad)
        {
            return _OportunidadPersona.OportunidadPersona_Seleccionar_IdOportunidad(oportunidad);
        }
        public List<Models.OportunidadPersona> OportunidadPersona_Seleccionar_IdPersona(Models.Persona persona)
        {
            return _OportunidadPersona.OportunidadPersona_Seleccionar_IdPersona(persona);
        }
    }
}
