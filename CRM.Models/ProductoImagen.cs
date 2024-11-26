using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class ProductoImagen
    {
        public int Id { get; set; }
        public ControlArchivo ControlArchivo { get; set; }
        public CatProducto CatProducto { get; set; }
        public string NmArchivo { get; set; }
        public string NmOriginal { get; set; }
        public string ImagenURL { get; set; }
    }
}
