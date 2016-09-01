using InfoAlexandre.Domain.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace InfoAlexandre.WebAPI.Models.Evento
{
    public class ModelEventoCadastro
    {
        [Required(ErrorMessage = "Campo Nome do Evento é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Evento com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Evento com no máximo 50 caracteres.")]
        public string Nome { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Intituição do Evento é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Intituição do Evento com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Intituição do Evento com no máximo 100 caracteres.")]
        public string Instituicao { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Carga Horária do Evento é obrigatório.")]
        [MinLength(1, ErrorMessage = "Campo Carga Horária do Evento com no mínimo 1 caracteres.")]
        [MaxLength(5, ErrorMessage = "Campo Carga Horária do Evento com no máximo 5 caracteres.")]
        public Int16 CargaHoraria { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Link do Evento é obrigatório.")]
        [MaxLength(250, ErrorMessage = "Campo Link do Evento com no máximo 250 caracteres.")]
        public string Link { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Tipo da Aula do Evento é obrigatório.")]
        public TipoAula TipoAula { get; set; }

        //_____________________

        public DateTime Data { get; set; }

        //_____________________

        public bool Certificado { get; set; }

        //_____________________

        [MinLength(3, ErrorMessage = "Campo Descrição do Evento com no mínimo 3 caracteres.")]
        [MaxLength(500, ErrorMessage = "Campo Descrição do Evento com no máximo 500 caracteres.")]
        public string Descricao { get; set; }
    }

    public class ModelEventoAtualizacao
    {
        [Required(ErrorMessage = "Campo Nome do Evento é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Evento com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Evento com no máximo 50 caracteres.")]
        public string Nome { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Intituição do Evento é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Intituição do Evento com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Intituição do Evento com no máximo 100 caracteres.")]
        public string Instituicao { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Carga Horária do Evento é obrigatório.")]
        [MinLength(1, ErrorMessage = "Campo Carga Horária do Evento com no mínimo 1 caracteres.")]
        [MaxLength(5, ErrorMessage = "Campo Carga Horária do Evento com no máximo 5 caracteres.")]
        public Int16 CargaHoraria { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Link do Evento é obrigatório.")]
        [MaxLength(250, ErrorMessage = "Campo Link do Evento com no máximo 250 caracteres.")]
        public string Link { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Tipo da Aula do Evento é obrigatório.")]
        public TipoAula TipoAula { get; set; }

        //_____________________

        public DateTime Data { get; set; }

        //_____________________

        public bool Certificado { get; set; }

        //_____________________

        [MinLength(3, ErrorMessage = "Campo Descrição do Evento com no mínimo 3 caracteres.")]
        [MaxLength(500, ErrorMessage = "Campo Descrição do Evento com no máximo 500 caracteres.")]
        public string Descricao { get; set; }
    }

    public class ModelEventoExclusao
    {
        [Required(ErrorMessage = "Campo Nome do Evento é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Evento com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Evento com no máximo 50 caracteres.")]
        public string Nome { get; set; }
    }

    public class ModelPesquisaEventoPorNome
    {
        [Required(ErrorMessage = "Campo Nome do Evento é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Evento com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Evento com no máximo 50 caracteres.")]
        public string Nome { get; set; }
    }

    public class ModelPesquisaEventoPorInstituicao
    {
        [Required(ErrorMessage = "Campo Intituição do Evento é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Intituição do Evento com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Intituição do Evento com no máximo 100 caracteres.")]
        public string Instituicao { get; set; }
    }

    public class ModelPesquisaEventoPorCargaHoraria
    {
        [Required(ErrorMessage = "Campo Carga Horária do Evento é obrigatório.")]
        [MinLength(1, ErrorMessage = "Campo Carga Horária do Evento com no mínimo 1 caracteres.")]
        [MaxLength(5, ErrorMessage = "Campo Carga Horária do Evento com no máximo 5 caracteres.")]
        public Int16 CargaHoraria { get; set; }
    }

    public class ModelPesquisaEventoPorTipoAula
    {
        [Required(ErrorMessage = "Campo Tipo da Aula do Evento é obrigatório.")]
        public TipoAula TipoAula { get; set; }
    }

    public class ModelPesquisaEventoPorCertificado
    {
        [Required(ErrorMessage = "Campo Certificado do Evento é obrigatório.")]
        public bool Certificado { get; set; }
    }

    public class ModelPesquisaEventoPorStatus
    {
        [Required(ErrorMessage = "Campo Status do Evento é obrigatório.")]
        public Status Status { get; set; }
    }
}