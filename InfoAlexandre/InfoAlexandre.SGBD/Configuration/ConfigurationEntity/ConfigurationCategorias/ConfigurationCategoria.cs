using InfoAlexandre.Domain.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InfoAlexandre.SGBD.Configuration.ConfigurationEntity.ConfigurationCategorias
{
    public class ConfigurationCategoria : EntityTypeConfiguration<Categorias>
    {
        public ConfigurationCategoria()
        {
            ToTable("TBCategoria");

            HasKey(categoria => categoria.IdCategoria);

            Property(categoria => categoria.IdCategoria).HasColumnName("IdCategoria").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(categoria => categoria.Nome).HasColumnName("Nome").HasMaxLength(50).IsRequired();
            Property(categoria => categoria.Descricao).HasColumnName("Descricao");
        }
    }
}