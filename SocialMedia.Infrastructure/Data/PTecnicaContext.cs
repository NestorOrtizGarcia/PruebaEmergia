using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infrastructure.Data
{
    public partial class PTecnicaContext : DbContext
    {
        public PTecnicaContext()
        {
        }

        public PTecnicaContext(DbContextOptions<PTecnicaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Ciclo> Ciclo { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Detalle> Detalle { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoCiclo> ProductoCiclo { get; set; }
        public virtual DbSet<Vendedor> Vendedor { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.Idcategoria)
                    .HasName("PK__categori__140587C74CB1DE5D");

                entity.ToTable("categoria");

                entity.Property(e => e.Idcategoria)
                    .HasColumnName("idcategoria")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoriaPadre).HasColumnName("categoria_padre");

                entity.Property(e => e.Detalle)
                    .HasColumnName("detalle")
                    .HasColumnType("text");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("text");

                entity.HasOne(d => d.CategoriaPadreNavigation)
                    .WithMany(p => p.InverseCategoriaPadreNavigation)
                    .HasForeignKey(d => d.CategoriaPadre)
                    .HasConstraintName("FK_categoria_categoria_padre");
            });

            modelBuilder.Entity<Ciclo>(entity =>
            {
                entity.HasKey(e => e.Idciclo)
                    .HasName("PK__ciclo__945B52219F76D9D9");

                entity.ToTable("ciclo");

                entity.Property(e => e.Idciclo)
                    .HasColumnName("idciclo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.FechaFinal)
                    .HasColumnName("fecha_final")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fecha_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.Numero).HasColumnName("numero");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__885457EE7DF1D5B7");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("idCliente")
                    .ValueGeneratedNever();

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasColumnType("text");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("text");

                entity.Property(e => e.Facebook)
                    .HasColumnName("facebook")
                    .HasColumnType("text");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasColumnType("text");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("text");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasColumnType("text");

                entity.Property(e => e.Twiter)
                    .HasColumnName("twiter")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Detalle>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PK__Detalle__49CAE2FB91A50BD1");

                entity.Property(e => e.IdDetalle)
                    .HasColumnName("idDetalle")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.NumFactura).HasColumnName("num_factura");

                entity.Property(e => e.NumProductoCiclo).HasColumnName("num_producto_ciclo");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.HasOne(d => d.NumFacturaNavigation)
                    .WithMany(p => p.Detalle)
                    .HasForeignKey(d => d.NumFactura)
                    .HasConstraintName("FK__Detalle__num_fac__45F365D3");

                entity.HasOne(d => d.NumProductoCicloNavigation)
                    .WithMany(p => p.Detalle)
                    .HasForeignKey(d => d.NumProductoCiclo)
                    .HasConstraintName("FK__Detalle__num_pro__44FF419A");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.Idfactura)
                    .HasName("PK__factura__40FF55D85125F94D");

                entity.ToTable("factura");

                entity.Property(e => e.Idfactura)
                    .HasColumnName("idfactura")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumCliente).HasColumnName("num_cliente");

                entity.Property(e => e.NumVendedor).HasColumnName("num_vendedor");

                entity.HasOne(d => d.NumClienteNavigation)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.NumCliente)
                    .HasConstraintName("FK__factura__num_cli__4222D4EF");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Idproducto)
                    .HasName("PK__producto__DC53BE3CD0AFFA00");

                entity.ToTable("producto");

                entity.Property(e => e.Idproducto)
                    .HasColumnName("idproducto")
                    .ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasColumnType("text");

                entity.Property(e => e.Detalle)
                    .HasColumnName("detalle")
                    .HasColumnType("text");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasColumnType("text");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("text");

                entity.Property(e => e.NumeroCategoria).HasColumnName("numero_categoria");

                entity.HasOne(d => d.NumeroCategoriaNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.NumeroCategoria)
                    .HasConstraintName("FK__producto__numero__35BCFE0A");
            });

            modelBuilder.Entity<ProductoCiclo>(entity =>
            {
                entity.HasKey(e => e.IdproductoCiclo)
                    .HasName("PK__producto__BB5538B3B3147EA8");

                entity.ToTable("producto_ciclo");

                entity.Property(e => e.IdproductoCiclo)
                    .HasColumnName("idproducto_ciclo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cannon).HasColumnName("cannon");

                entity.Property(e => e.ComisionVendedor).HasColumnName("comision_vendedor");

                entity.Property(e => e.NumCiclo).HasColumnName("num_ciclo");

                entity.Property(e => e.NumProducto).HasColumnName("num_producto");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.PrecioPromocional).HasColumnName("precio_promocional");

                entity.HasOne(d => d.NumCicloNavigation)
                    .WithMany(p => p.ProductoCiclo)
                    .HasForeignKey(d => d.NumCiclo)
                    .HasConstraintName("FK__producto___num_c__38996AB5");

                entity.HasOne(d => d.NumProductoNavigation)
                    .WithMany(p => p.ProductoCiclo)
                    .HasForeignKey(d => d.NumProducto)
                    .HasConstraintName("FK__producto___num_p__398D8EEE");
            });

            modelBuilder.Entity<Vendedor>(entity =>
            {
                entity.HasKey(e => e.IdVendedor)
                    .HasName("PK__Vendedor__0093030820AB56F9");

                entity.Property(e => e.IdVendedor)
                    .HasColumnName("id_vendedor")
                    .ValueGeneratedNever();

                entity.Property(e => e.Condicion).HasColumnName("condicion");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasColumnType("text");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("text");

                entity.Property(e => e.Facebook)
                    .HasColumnName("facebook")
                    .HasColumnType("text");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasColumnType("text");

                entity.Property(e => e.Instagram)
                    .HasColumnName("instagram")
                    .HasColumnType("text");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasColumnType("text");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasColumnType("text");

                entity.Property(e => e.Twitter)
                    .HasColumnName("twitter")
                    .HasColumnType("text");

                entity.Property(e => e.UsuarioContra)
                    .HasColumnName("usuario_contra")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioNombre)
                    .HasColumnName("usuario_nombre")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

        }

    }
}
