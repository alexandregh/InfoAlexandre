using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.SGBD.Configuration.ConfigurationEntity.ConfigurationAdministradores;
using InfoAlexandre.SGBD.Configuration.ConfigurationEntity.ConfigurationCategorias;
using InfoAlexandre.SGBD.Configuration.ConfigurationEntity.ConfigurationCursos;
using InfoAlexandre.SGBD.Configuration.ConfigurationEntity.ConfigurationEventos;
using InfoAlexandre.SGBD.Configuration.ConfigurationEntity.ConfigurationFormacoes;
using InfoAlexandre.SGBD.Configuration.ConfigurationEntity.ConfigurationGrupos;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace InfoAlexandre.SGBD.Context
{
    public class DataContext : DbContext
    {
        #region Construtor

        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["dbInfoAlexandre"].ConnectionString)
        {

        }

        #endregion

        #region DBSet

        public DbSet<Administradores> Administrador { get; set; }
        public DbSet<Categorias> Categoria { get; set; }
        public DbSet<Cursos> Curso { get; set; }
        public DbSet<Eventos> Evento { get; set; }
        public DbSet<Formacoes> Formacao { get; set; }
        public DbSet<Grupos> Grupo { get; set; }

        #endregion

        #region OnModelCreating

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configurações Gerais...
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //__________________________________________

            // Configurações Data Type...
            modelBuilder.Properties<string>().Configure(entity => entity.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(entity => entity.HasMaxLength(500));

            //__________________________________________

            // Configurações Fluent...
            modelBuilder.Configurations.Add(new ConfigurationAdministrador());
            modelBuilder.Configurations.Add(new ConfigurationCategoria());
            modelBuilder.Configurations.Add(new ConfigurationCurso());
            modelBuilder.Configurations.Add(new ConfigurationEvento());
            modelBuilder.Configurations.Add(new ConfigurationFormacao());
            modelBuilder.Configurations.Add(new ConfigurationGrupo());
        }

        #endregion
    }
}