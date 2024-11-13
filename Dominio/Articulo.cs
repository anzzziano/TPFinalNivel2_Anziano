using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {

        public int Id { get; set; }

        [DisplayName("Codigo de articulo")]
        public string CodigoArt { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Imagen { get; set; }

        public decimal Precio { get; set; }

        public Categoria Categoria { get; set; }

        public Marca Marca { get; set; }    




    }
}
