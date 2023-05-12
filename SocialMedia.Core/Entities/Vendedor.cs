using System;
using System.Collections.Generic;

namespace SocialMedia.Core.Entities
{
    public partial class Vendedor
    {
        public int IdVendedor { get; set; }
        public string UsuarioNombre { get; set; }
        public string UsuarioContra { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Imagen { get; set; }
        public int? Condicion { get; set; }
    }
}
