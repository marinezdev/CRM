using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class ObjetivoFacturaAcumulado
    {
        Data.ObjetivoFacturaAcumulado _ObjetivoFacturaAcumulado = new Data.ObjetivoFacturaAcumulado();
        public Models.ObjetivoFacturaAcumulado ObjetivoFacturaAcumulado_Mes_Agregar(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado)
        {
            return _ObjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Mes_Agregar(objetivoFacturaAcumulado);
        }

        public List<Models.ObjetivoFacturaAcumulado> ObjetivoFacturaAcumulado_Seleccionar_IdObjetivo(Models.ObjetivosResponsables  objetivosResponsables)
        {
            return _ObjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Seleccionar_IdObjetivo(objetivosResponsables);
        }
        
        public Models.ObjetivoFacturaAcumulado ObjetivoFacturaAcumulado_Agregar_Mes(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado)
        {
            return _ObjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Agregar_Mes(objetivoFacturaAcumulado);
        }
        public Models.ObjetivoFacturaAcumulado ObjetivoFacturaAcumulado_Eliminar_Mes(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado)
        {
            return _ObjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Eliminar_Mes(objetivoFacturaAcumulado);
        }
        public List<Models.ObjetivoFacturaAcumulado> ObjetivoFacturaAcumulado_IdUnidadNegocio(Models.CatUnidadNegocio catUnidadNegocio)
        {
            return _ObjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_IdUnidadNegocio(catUnidadNegocio);
        }



        public List<Models.ObjetivoFacturaAcumulado> ObjetivoFacturaAcumulado_Seleccionar_IdObjetivoYear(Models.ObjetivosResponsables objetivosResponsables)
        {
            return _ObjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Seleccionar_IdObjetivoYear(objetivosResponsables);
        }
        public Models.ObjetivoFacturaAcumulado ObjetivoFacturaAcumulado_Agregar_Mes_Year(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado)
        {
            return _ObjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Agregar_Mes_Year(objetivoFacturaAcumulado);
        }
        public Models.ObjetivoFacturaAcumulado ObjetivoFacturaAcumulado_Eliminar_Mes_Year(Models.ObjetivoFacturaAcumulado objetivoFacturaAcumulado)
        {
            return _ObjetivoFacturaAcumulado.ObjetivoFacturaAcumulado_Eliminar_Mes_Year(objetivoFacturaAcumulado);
        }
    }
}
