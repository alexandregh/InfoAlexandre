using InfoAlexandre.Domain.Domain.Enum;

namespace InfoAlexandre.Domain.Domain.Entity
{
    public class Cursos : Educacao
    {
        #region Atributos

        public virtual int IdCurso { get; set; }
        public virtual Status Status { get; set; }

        // FK...
        public virtual byte IdCategoria { get; set; }
        public virtual byte IdGrupo { get; set; }

        #endregion

        #region Associações

        public virtual Categorias Categoria { get; set; }
        public virtual Grupos Grupo { get; set; }

        #endregion
    }
}