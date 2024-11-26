using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application
{
    public class CatCP
    {
        Data.CatCP _CatCP = new Data.CatCP();
        public List<Models.Consulta.CatCP_Busqueda> CatCP_Busqueda(Models.CatCp catCp)
        {
            return _CatCP.CatCP_Busqueda(catCp);
        }

        public List<Models.CatCp> CatCP_Seleccionar_IdColonia(Models.CatColonias catColonias)
        {
            return _CatCP.CatCP_Seleccionar_IdColonia(catColonias);
        }
    }
}
