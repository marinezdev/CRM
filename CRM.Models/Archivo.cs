using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Archivo
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public string Nombre { get; set; }
        public string NombreOrigianl { get; set; }
        public string NombreNuevo { get; set; }
        public string Descripcion { get; set; }
        public string Extencion { get; set; }
    }
}
