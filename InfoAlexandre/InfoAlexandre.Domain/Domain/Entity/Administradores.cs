using System;

namespace InfoAlexandre.Domain.Domain.Entity
{
    public class Administradores
    {
        #region Atributos

        public virtual byte IdAdministrador { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Sobrenome { get; set; }
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual DateTime DataAlteracao { get; set; }
        public virtual string Descricao { get; set; }

        #endregion
    }
}