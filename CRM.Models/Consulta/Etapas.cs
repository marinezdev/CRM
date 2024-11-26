using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models.Consulta
{
    public class Etapas
    {
        public CatEtapaOportunidad CatEtapaOportunidad { get; set; }
        public OportunidadEtapaTarea OportunidadEtapaTarea { get; set; }
        public CatTareaEtapa CatTareaEtapa { get; set; }
        public int Fin { get; set; }
        public float Progreso { get; set; }
    }
}
