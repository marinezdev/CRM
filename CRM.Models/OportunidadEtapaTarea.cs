using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class OportunidadEtapaTarea
    {
        public int Id { get; set; }
        public Oportunidad Oportunidad { get; set; }
        public CatTareaEtapa CatTareaEtapa { get; set; }
        public int Estatus { get; set; }
        public Usuario Usuario { get; set; }
    }
}
