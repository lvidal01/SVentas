using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SVentas.web.Models
{
    public partial class dbsvContext : DbContext
    {
        public dbsvContext()
        {
        }

        public dbsvContext(DbContextOptions<dbsvContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<ClasificacionDeClientes> ClasificacionDeClientes { get; set; }
        public virtual DbSet<ClasificacionesArticulos> ClasificacionesArticulos { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Estatus> Estatus { get; set; }
        public virtual DbSet<FormasDeEnvio> FormasDeEnvio { get; set; }
        public virtual DbSet<FormasDePago> FormasDePago { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Monedas> Monedas { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<PuestosDeTrabajo> PuestosDeTrabajo { get; set; }
        public virtual DbSet<Suplidores> Suplidores { get; set; }
        public virtual DbSet<TiposDeDocumentos> TiposDeDocumentos { get; set; }
        public virtual DbSet<Ubicaciones> Ubicaciones { get; set; }
        public virtual DbSet<UnidadesDeMedida> UnidadesDeMedida { get; set; }
        public virtual DbSet<Vendedores> Vendedores { get; set; }

        // Unable to generate entity type for table 'dbo.Tasas de Cambio'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Clasificacion Suplidores'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Usuario'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-MTQ7GTQ\\SQLEXPRESS;Database=dbsv;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulos>(entity =>
            {
                entity.HasKey(e => e.Idarticulos);

                entity.HasIndex(e => e.Codmarcas)
                    .HasName("FK");

                entity.Property(e => e.Idarticulos)
                    .HasColumnName("idarticulos")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(25);

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasKey(e => e.Idciudades);

                entity.HasIndex(e => new { e.Nombre, e.Idempresas })
                    .HasName("FK");

                entity.Property(e => e.Idciudades)
                    .HasColumnName("idciudades")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idempresas).HasColumnName("idempresas");

                entity.Property(e => e.Idpaises).HasColumnName("idpaises");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<ClasificacionDeClientes>(entity =>
            {
                entity.HasKey(e => e.Idclientes);

                entity.ToTable("Clasificacion de Clientes");

                entity.HasIndex(e => e.Categoria)
                    .HasName("FK");

                entity.Property(e => e.Idclientes)
                    .HasColumnName("idclientes")
                    .ValueGeneratedNever();

                entity.Property(e => e.Categoria).HasColumnName("categoria");
            });

            modelBuilder.Entity<ClasificacionesArticulos>(entity =>
            {
                entity.HasKey(e => e.CodCarticulos);

                entity.ToTable("Clasificaciones Articulos");

                entity.HasIndex(e => e.Idarticulos)
                    .HasName("FK");

                entity.Property(e => e.CodCarticulos).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(256);

                entity.Property(e => e.Idarticulos).HasColumnName("idarticulos");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.Idclientes);

                entity.HasIndex(e => e.Idempresas)
                    .HasName("FK");

                entity.Property(e => e.Idclientes)
                    .HasColumnName("idclientes")
                    .ValueGeneratedNever();

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(25);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(256);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.FechaDnacimiento)
                    .HasColumnName("fecha_dnacimiento")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idempresas).HasColumnName("idempresas");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasKey(e => e.Idempleados);

                entity.HasIndex(e => e.Idempresas)
                    .HasName("FK");

                entity.Property(e => e.Idempleados)
                    .HasColumnName("idempleados")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idempresas).HasColumnName("idempresas");
            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.HasKey(e => e.Idempresas);

                entity.HasIndex(e => new { e.Telefono, e.Email })
                    .HasName("Clave");

                entity.Property(e => e.Idempresas)
                    .HasColumnName("idempresas")
                    .ValueGeneratedNever();

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });

            modelBuilder.Entity<Estatus>(entity =>
            {
                entity.HasKey(e => e.Idestatus);

                entity.HasIndex(e => e.Idempresas)
                    .HasName("FK");

                entity.Property(e => e.Idestatus)
                    .HasColumnName("idestatus")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idempresas).HasColumnName("idempresas");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<FormasDeEnvio>(entity =>
            {
                entity.HasKey(e => e.Idenvio);

                entity.ToTable("Formas de Envio");

                entity.HasIndex(e => e.Idubicaciones)
                    .HasName("FK");

                entity.Property(e => e.Idenvio)
                    .HasColumnName("idenvio")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idubicaciones).HasColumnName("idubicaciones");
            });

            modelBuilder.Entity<FormasDePago>(entity =>
            {
                entity.HasKey(e => e.Idpago);

                entity.ToTable("Formas de Pago");

                entity.HasIndex(e => e.Nombre)
                    .HasName("FK");

                entity.Property(e => e.Idpago)
                    .HasColumnName("idpago")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(256);

                entity.Property(e => e.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<Marcas>(entity =>
            {
                entity.HasKey(e => e.Codmarcas);

                entity.HasIndex(e => e.Idsuplidores)
                    .HasName("FK");

                entity.Property(e => e.Codmarcas).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(25);

                entity.Property(e => e.Idsuplidores).HasColumnName("idsuplidores");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Monedas>(entity =>
            {
                entity.HasKey(e => e.Idmonedas);

                entity.HasIndex(e => new { e.Tipo, e.Idpago })
                    .HasName("FK");

                entity.Property(e => e.Idmonedas)
                    .HasColumnName("idmonedas")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idpago).HasColumnName("idpago");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Tipo).HasColumnName("tipo");
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasKey(e => e.Idpaises);

                entity.HasIndex(e => e.Idempresas)
                    .HasName("FK");

                entity.Property(e => e.Idpaises)
                    .HasColumnName("idpaises")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idempresas).HasColumnName("idempresas");

                entity.Property(e => e.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<PuestosDeTrabajo>(entity =>
            {
                entity.HasKey(e => e.Idpuestotrabajo);

                entity.ToTable("Puestos de Trabajo");

                entity.HasIndex(e => e.Idempleados)
                    .HasName("FK");

                entity.Property(e => e.Idpuestotrabajo)
                    .HasColumnName("idpuestotrabajo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idempleados).HasColumnName("idempleados");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Suplidores>(entity =>
            {
                entity.HasKey(e => e.Idsuplidores);

                entity.HasIndex(e => e.Idempresas)
                    .HasName("FK");

                entity.Property(e => e.Idsuplidores)
                    .HasColumnName("idsuplidores")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idempresas).HasColumnName("idempresas");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<TiposDeDocumentos>(entity =>
            {
                entity.HasKey(e => e.Iddocumento);

                entity.ToTable("Tipos de Documentos");

                entity.HasIndex(e => e.Tipodocumento)
                    .HasName("FK");

                entity.Property(e => e.Iddocumento)
                    .HasColumnName("iddocumento")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Tipodocumento).HasColumnName("tipodocumento");
            });

            modelBuilder.Entity<Ubicaciones>(entity =>
            {
                entity.HasKey(e => e.Idubicaciones);

                entity.HasIndex(e => new { e.Idpaises, e.Idciudades })
                    .HasName("FK");

                entity.Property(e => e.Idubicaciones)
                    .HasColumnName("idubicaciones")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idciudades).HasColumnName("idciudades");

                entity.Property(e => e.Idpaises).HasColumnName("idpaises");
            });

            modelBuilder.Entity<UnidadesDeMedida>(entity =>
            {
                entity.HasKey(e => e.Idunidadmedida);

                entity.ToTable("Unidades de Medida");

                entity.HasIndex(e => e.CodCarticulos)
                    .HasName("FK");

                entity.Property(e => e.Idunidadmedida)
                    .HasColumnName("idunidadmedida")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Vendedores>(entity =>
            {
                entity.HasKey(e => e.Idvendedores);

                entity.HasIndex(e => new { e.CodCarticulos, e.Idempleados, e.Idpuestotrabajo })
                    .HasName("FK");

                entity.Property(e => e.Idvendedores)
                    .HasColumnName("idvendedores")
                    .ValueGeneratedNever();

                entity.Property(e => e.Idempleados).HasColumnName("idempleados");

                entity.Property(e => e.Idpuestotrabajo).HasColumnName("idpuestotrabajo");
            });
        }
    }
}
