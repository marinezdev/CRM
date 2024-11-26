using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class TareaEntidad
    {
        public int Id { get; set; }
        //public Tarea Tarea { get; set; }
        public CatEntidad CatEntidad { get; set; }
        public int IdValorEntidad { get; set; }

    }
}
