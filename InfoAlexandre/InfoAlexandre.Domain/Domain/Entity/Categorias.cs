using System.Collections.Generic;

namespace InfoAlexandre.Domain.Domain.Entity
{
    public class Categorias
    {
        #region Atributos

        public virtual byte IdCategoria { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }

        #endregion

        #region Associações

        public virtual ICollection<Formacoes> Formacoes { get; set; }
        public virtual ICollection<Cursos> Cursos { get; set; }
        public virtual ICollection<Eventos> Eventos { get; set; }

        #endregion
    }
}