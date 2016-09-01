using InfoAlexandre.Domain.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InfoAlexandre.SGBD.Configuration.ConfigurationEntity.ConfigurationEventos
{
    public class ConfigurationEvento : EntityTypeConfiguration<Eventos>
    {
        public ConfigurationEvento()
        {
            ToTable("TBEvento");

            HasKey(evento => evento.IdEvento);

            Property(evento => evento.IdEvento).HasColumnName("IdEvento").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(evento => evento.Nome).HasColumnName("Nome").HasMaxLength(50).IsRequired();
            Property(evento => evento.Instituicao).HasColumnName("Instituicao").HasMaxLength(100).IsRequired();
            Property(evento => evento.CargaHoraria).HasColumnName("CargaHoraria").IsRequired();
            Property(evento => evento.Link).HasColumnName("Link").HasMaxLength(250);
            Property(evento => evento.TipoAula).HasColumnName("TipoAula").IsRequired();
            Property(evento => evento.Certificado).HasColumnName("Certificado");
            Property(evento => evento.Data).HasColumnName("Data");
            Property(evento => evento.Descricao).HasColumnName("Descricao");

            #region Associações

            HasRequired(evento => evento.Categoria) // Evento tem 1 Categoria...
            .WithMany(categoria => categoria.Eventos) // Categoria tem Muitos Eventos...
            .HasForeignKey(evento => evento.IdCategoria); // Evento tem a FK de Categoria...

            #endregion
        }
    }
}