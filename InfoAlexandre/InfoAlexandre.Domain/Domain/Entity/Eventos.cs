using System;

namespace InfoAlexandre.Domain.Domain.Entity
{
    public class Eventos : Educacao
    {
        #region Atributos

        public virtual int IdEvento { get; set; }
        public virtual DateTime Data { get; set; }

        // FK...
        public virtual byte IdCategoria { get; set; }

        #endregion

        #region Associações

        public virtual Categorias Categoria { get; set; }

        #endregion
    }
}