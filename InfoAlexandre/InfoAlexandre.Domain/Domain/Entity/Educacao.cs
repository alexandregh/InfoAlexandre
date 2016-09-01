using InfoAlexandre.Domain.Domain.Enum;
using System;

namespace InfoAlexandre.Domain.Domain.Entity
{
    public abstract class Educacao
    {
        #region Atributos

        public virtual string Nome { get; set; }
        public virtual string Instituicao { get; set; }
        public virtual int CargaHoraria { get; set; }
        public virtual string Link { get; set; }
        public virtual TipoAula TipoAula { get; set; }
        public virtual bool Certificado { get; set; }
        public virtual string Descricao { get; set; }

        #endregion
    }
}