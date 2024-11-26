using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class CatSubcategoriaProducto
    {
        public CatCategoriasProducto CatCategoriasProducto { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
