using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            Factura = new HashSet<Factura>();
        }

        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twiter { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<Factura> Factura { get; set; }
    }
}
