using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class Ciclo
    {
        public Ciclo()
        {
            ProductoCiclo = new HashSet<ProductoCiclo>();
        }

        public int Idciclo { get; set; }
        public int? Numero { get; set; }
        public int? Anio { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinal { get; set; }

        public virtual ICollection<ProductoCiclo> ProductoCiclo { get; set; }
    }
}
