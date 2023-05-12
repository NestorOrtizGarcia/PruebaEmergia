using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class Categoria
    {
        public Categoria()
        {
            InverseCategoriaPadreNavigation = new HashSet<Categoria>();
            Producto = new HashSet<Producto>();
        }

        public int Idcategoria { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public int? CategoriaPadre { get; set; }

        public virtual Categoria CategoriaPadreNavigation { get; set; }
        public virtual ICollection<Categoria> InverseCategoriaPadreNavigation { get; set; }
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
