using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class OportunidadBitacora
    {
        Data.OportunidadBitacora _OportunidadBitacora = new Data.OportunidadBitacora();
        public Models.OportunidadBitacora OportunidadBitacora_Agregar(Models.OportunidadBitacora oportunidadBitacora)
        {
            return _OportunidadBitacora.OportunidadBitacora_Agregar(oportunidadBitacora);
        }
        public List<Models.OportunidadBitacora> OportunidadBitacora_Seleccionar(Models.Oportunidad oportunidad)
        {
            return _OportunidadBitacora.OportunidadBitacora_Seleccionar(oportunidad);
        }
    }
}
