using InfoAlexandre.Domain.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace InfoAlexandre.WebAPI.Models.Formacao
{
    public class ModelFormacaoCadastro
    {
        [Required(ErrorMessage = "Campo Nome da Formação é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome da Formação com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome da Formação com no máximo 50 caracteres.")]
        public string Nome { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Intituição da Formação é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Intituição da Formação com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Intituição da Formação com no máximo 100 caracteres.")]
        public string Instituicao { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Carga Horária da Formação é obrigatório.")]
        public int CargaHoraria { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Link da Formação é obrigatório.")]
        [MaxLength(250, ErrorMessage = "Campo Link da Formação com no máximo 250 caracteres.")]
        public string Link { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Tipo de Aula da Formação é obrigatório.")]
        public TipoAula TipoAula { get; set; }

        //_____________________

        public TipoEnsino TipoEnsino { get; set; }

        //_____________________

        public bool Certificado { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Status da Formação é obrigatório.")]
        public Status Status { get; set; }

        //_____________________

        [MinLength(3, ErrorMessage = "Campo Descrição da Formação com no mínimo 3 caracteres.")]
        [MaxLength(500, ErrorMessage = "Campo Descrição da Formação com no máximo 500 caracteres.")]
        public string Descricao { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Nome da Categoria da Formação é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome da Categoria da Formação com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome da Categoria da Formação com no máximo 50 caracteres.")]
        public string NomeCategoria { get; set; }

        //_____________________

        [MinLength(3, ErrorMessage = "Campo Descrição da Categoria da Formação com no mínimo 3 caracteres.")]
        [MaxLength(500, ErrorMessage = "Campo Descrição da Categoria da Formação com no máximo 500 caracteres.")]
        public string DescricaoCategoria { get; set; }
    }

    public class ModelFormacaoAtualizacao
    {
        [Required(ErrorMessage = "Campo Nome Atual da Formação é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome Atual da Formação com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome Atual da Formação com no máximo 50 caracteres.")]
        public string NomeAtual { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Nome da Formação é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome da Formação com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome da Formação com no máximo 50 caracteres.")]
        public string Nome { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Intituição da Formação é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Intituição da Formação com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Intituição da Formação com no máximo 100 caracteres.")]
        public string Instituicao { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Carga Horária da Formação é obrigatório.")]
        public int CargaHoraria { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Link da Formação é obrigatório.")]
        [MaxLength(250, ErrorMessage = "Campo Link da Formação com no máximo 250 caracteres.")]
        public string Link { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Tipo de Aula da Formação é obrigatório.")]
        public TipoAula TipoAula { get; set; }

        //_____________________

        public TipoEnsino TipoEnsino { get; set; }

        //_____________________

        public bool Certificado { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Status da Formação é obrigatório.")]
        public Status Status { get; set; }

        //_____________________

        [MinLength(3, ErrorMessage = "Campo Descrição da Formação com no mínimo 3 caracteres.")]
        [MaxLength(500, ErrorMessage = "Campo Descrição da Formação com no máximo 500 caracteres.")]
        public string Descricao { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Nome da Categoria da Formação é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome da Categoria da Formação com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome da Categoria da Formação com no máximo 50 caracteres.")]
        public string NomeCategoria { get; set; }

        //_____________________

        [MinLength(3, ErrorMessage = "Campo Descrição da Categoria da Formação com no mínimo 3 caracteres.")]
        [MaxLength(500, ErrorMessage = "Campo Descrição da Categoria da Formação com no máximo 500 caracteres.")]
        public string DescricaoCategoria { get; set; }
    }

    public class MModelFormacaoExclusao
    {
        [Required(ErrorMessage = "Campo Nome da Formação é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome da Formação com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome da Formação com no máximo 50 caracteres.")]
        public string Nome { get; set; }
    }

    public class ModelPesquisaFormacoesPorNome
    {
        [Required(ErrorMessage = "Campo Nome da Formação é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome da Formação com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome da Formação com no máximo 50 caracteres.")]
        public string Nome { get; set; }
    }

    public class ModelPesquisaFormacoesPorInstituicao
    {
        [Required(ErrorMessage = "Campo Intituição da Formação é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Intituição da Formação com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Intituição da Formação com no máximo 100 caracteres.")]
        public string Instituicao { get; set; }
    }

    public class ModelPesquisaFormacoesPorCargaHoraria
    {
        [Required(ErrorMessage = "Campo Carga Horária da Formação é obrigatório.")]
        [MinLength(1, ErrorMessage = "Campo Carga Horária da Formação com no mínimo 1 caracteres.")]
        [MaxLength(5, ErrorMessage = "Campo Carga Horária da Formação com no máximo 5 caracteres.")]
        public int CargaHoraria { get; set; }
    }

    public class ModelPesquisaFormacoesPorTipoAula
    {
        [Required(ErrorMessage = "Campo Tipo da Aula da Formação é obrigatório.")]
        public TipoAula TipoAula { get; set; }
    }

    public class ModelPesquisaFormacoesPorTipoEnsino
    {
        [Required(ErrorMessage = "Campo Tipo de Ensino da Formação é obrigatório.")]
        public TipoEnsino TipoEnsino { get; set; }
    }

    public class ModelPesquisaFormacoesPorCertificado
    {
        [Required(ErrorMessage = "Campo Certificado da Formação é obrigatório.")]
        public bool Certificado { get; set; }
    }

    public class ModelPesquisaFormacoesPorStatus
    {
        [Required(ErrorMessage = "Campo Status da Formação é obrigatório.")]
        public Status Status { get; set; }
    }
}