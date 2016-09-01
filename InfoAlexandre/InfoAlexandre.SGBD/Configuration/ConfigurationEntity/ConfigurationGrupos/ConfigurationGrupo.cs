using InfoAlexandre.Domain.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InfoAlexandre.SGBD.Configuration.ConfigurationEntity.ConfigurationGrupos
{
    public class ConfigurationGrupo : EntityTypeConfiguration<Grupos>
    {
        public ConfigurationGrupo()
        {
            ToTable("TBGrupo");

            HasKey(grupo => grupo.IdGrupo);

            Property(grupo => grupo.IdGrupo).HasColumnName("IdGrupo").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(grupo => grupo.Nome).HasColumnName("Nome").HasMaxLength(50).IsRequired();
            Property(grupo => grupo.Descricao).HasColumnName("Descricao");
        }
    }
}