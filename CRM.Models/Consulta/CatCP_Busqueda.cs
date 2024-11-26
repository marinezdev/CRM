using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models.Consulta
{
    public class CatCP_Busqueda
    {
        public CatEstados CatEstados { get; set; }
        public CatPoblaciones CatPoblaciones { get; set; }
        public CatColonias CatColonias { get; set; }
        public CatCp CatCp { get; set; }
    }
}
