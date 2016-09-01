using InfoAlexandre.Domain.Domain.Enum;

namespace InfoAlexandre.Domain.Domain.Entity
{
    public class Formacoes : Educacao
    {
        #region Atributos

        public virtual byte IdFormacao { get; set; }
        public virtual TipoEnsino TipoEnsino { get; set; }
        public virtual Status Status { get; set; }

        // FK...
        public virtual byte IdCategoria { get; set; }

        #endregion

        #region Associações

        public virtual Categorias Categoria { get; set; }

        #endregion
    }
}