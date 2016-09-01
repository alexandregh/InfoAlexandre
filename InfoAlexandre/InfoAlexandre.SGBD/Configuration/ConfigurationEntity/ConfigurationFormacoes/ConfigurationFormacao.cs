using InfoAlexandre.Domain.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InfoAlexandre.SGBD.Configuration.ConfigurationEntity.ConfigurationFormacoes
{
    public class ConfigurationFormacao : EntityTypeConfiguration<Formacoes>
    {
        public ConfigurationFormacao()
        {
            ToTable("TBFormacao");

            HasKey(formacao => formacao.IdFormacao);

            Property(formacao => formacao.IdFormacao).HasColumnName("IdFormacao").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(formacao => formacao.Nome).HasColumnName("Nome").HasMaxLength(50).IsRequired();
            Property(formacao => formacao.Instituicao).HasColumnName("Instituicao").HasMaxLength(100).IsRequired();
            Property(formacao => formacao.CargaHoraria).HasColumnName("CargaHoraria").IsRequired();
            Property(formacao => formacao.Link).HasColumnName("Link").HasMaxLength(250);
            Property(formacao => formacao.TipoAula).HasColumnName("TipoAula").IsRequired();
            Property(formacao => formacao.Certificado).HasColumnName("Certificado");
            Property(formacao => formacao.TipoEnsino).HasColumnName("TipoEnsino").IsRequired();
            Property(formacao => formacao.Status).HasColumnName("Status").IsRequired();
            Property(formacao => formacao.Descricao).HasColumnName("Descricao");

            #region Associações

            HasRequired(formacao => formacao.Categoria) // Formação tem 1 Categoria...
            .WithMany(categoria => categoria.Formacoes) // Categoria tem Muitas Formações...
            .HasForeignKey(formacao => formacao.IdCategoria); // Formação tem a FK de Categoria...

            #endregion
        }
    }
}