using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class CatColonias
    {
        public int Id { get; set; }
        public string Colonia { get; set; } 
        public CatCp CatCp { get; set; }
    }
}
