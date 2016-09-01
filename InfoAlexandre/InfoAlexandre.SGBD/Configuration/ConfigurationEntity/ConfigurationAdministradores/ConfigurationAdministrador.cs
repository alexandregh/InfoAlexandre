using InfoAlexandre.Domain.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InfoAlexandre.SGBD.Configuration.ConfigurationEntity.ConfigurationAdministradores
{
    public class ConfigurationAdministrador : EntityTypeConfiguration<Administradores>
    {
        public ConfigurationAdministrador()
        {
            ToTable("TBAdministrador");

            HasKey(administrador => administrador.IdAdministrador);

            Property(administrador => administrador.IdAdministrador).HasColumnName("IdAdministrador").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(administrador => administrador.Nome).HasColumnName("Nome").HasMaxLength(20).IsRequired();
            Property(administrador => administrador.Sobrenome).HasColumnName("Sobrenome").HasMaxLength(30).IsRequired();
            Property(administrador => administrador.Login).HasColumnName("Login").HasMaxLength(30).IsRequired();
            Property(administrador => administrador.Senha).HasColumnName("Senha").IsRequired();
            Property(administrador => administrador.DataCadastro).HasColumnName("DataCadastro").IsRequired();
            Property(administrador => administrador.DataAlteracao).HasColumnName("DataAlteracao");
            Property(administrador => administrador.Descricao).HasColumnName("Descricao");
        }
    }
}