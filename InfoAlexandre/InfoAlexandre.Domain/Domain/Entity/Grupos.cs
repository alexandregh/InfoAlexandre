using System.Collections.Generic;

namespace InfoAlexandre.Domain.Domain.Entity
{
    public class Grupos
    {
        #region Atributos

        public virtual byte IdGrupo { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Descricao { get; set; }

        #endregion

        #region Associações

        public virtual ICollection<Cursos> Cursos { get; set; }

        #endregion
    }
}