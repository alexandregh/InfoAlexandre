using InfoAlexandre.Domain.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace InfoAlexandre.SGBD.Configuration.ConfigurationEntity.ConfigurationCursos
{
    public class ConfigurationCurso : EntityTypeConfiguration<Cursos>
    {
        public ConfigurationCurso()
        {
            ToTable("TBCurso");

            HasKey(curso => curso.IdCurso);

            Property(curso => curso.IdCurso).HasColumnName("IdCurso").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(curso => curso.Nome).HasColumnName("Nome").HasMaxLength(50).IsRequired();
            Property(curso => curso.Instituicao).HasColumnName("Instituicao").HasMaxLength(100).IsRequired();
            Property(curso => curso.CargaHoraria).HasColumnName("CargaHoraria").IsRequired();
            Property(curso => curso.Link).HasColumnName("Link").HasMaxLength(250);
            Property(curso => curso.TipoAula).HasColumnName("TipoAula").IsRequired();
            Property(curso => curso.Certificado).HasColumnName("Certificado");
            Property(curso => curso.Status).HasColumnName("Status").IsRequired();
            Property(curso => curso.Descricao).HasColumnName("Descricao");

            #region Associações

            HasRequired(curso => curso.Categoria) // Curso tem 1 Categoria...
            .WithMany(categoria => categoria.Cursos) // Categoria tem Muitos Cursos...
            .HasForeignKey(curso => curso.IdCategoria); // Curso tem a FK de Categoria...

            HasRequired(curso => curso.Grupo) // Curso tem 1 Grupo...
            .WithMany(grupo => grupo.Cursos) // Grupo tem Muitos Cursos...
            .HasForeignKey(curso => curso.IdGrupo); // Curso tem a FK de Grupo...

            #endregion
        }
    }
}