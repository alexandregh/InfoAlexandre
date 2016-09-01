using InfoAlexandre.Domain.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace InfoAlexandre.WebAPI.Models.Curso
{
    public class ModelCursoCadastro
    {
        [Required(ErrorMessage = "Campo Nome do Curso é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Curso com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Curso com no máximo 50 caracteres.")]
        public string Nome { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Intituição do Curso é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Intituição do Curso com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Intituição do Curso com no máximo 100 caracteres.")]
        public string Instituicao { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Carga Horária do Curso é obrigatório.")]
        [MinLength(1, ErrorMessage = "Campo Carga Horária do Curso com no mínimo 1 caracteres.")]
        [MaxLength(5, ErrorMessage = "Campo Carga Horária do Curso com no máximo 5 caracteres.")]
        public Int16 CargaHoraria { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Link do Curso é obrigatório.")]
        [MaxLength(250, ErrorMessage = "Campo Link do Curso com no máximo 250 caracteres.")]
        public string Link { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Tipo da Aula do Curso é obrigatório.")]
        public TipoAula TipoAula { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Status do Curso é obrigatório.")]
        public Status Status { get; set; }

        //_____________________

        public bool Certificado { get; set; }

        //_____________________

        [MinLength(3, ErrorMessage = "Campo Descrição do Curso com no mínimo 3 caracteres.")]
        [MaxLength(500, ErrorMessage = "Campo Descrição do Curso com no máximo 500 caracteres.")]
        public string Descricao { get; set; }
    }

    public class ModelCursoAtualizacao
    {
        [Required(ErrorMessage = "Campo Nome do Curso é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Curso com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Curso com no máximo 50 caracteres.")]
        public string Nome { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Intituição do Curso é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Intituição do Curso com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Intituição do Curso com no máximo 100 caracteres.")]
        public string Instituicao { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Carga Horária do Curso é obrigatório.")]
        [MinLength(1, ErrorMessage = "Campo Carga Horária do Curso com no mínimo 1 caracteres.")]
        [MaxLength(5, ErrorMessage = "Campo Carga Horária do Curso com no máximo 5 caracteres.")]
        public Int16 CargaHoraria { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Link do Curso é obrigatório.")]
        [MaxLength(250, ErrorMessage = "Campo Link do Curso com no máximo 250 caracteres.")]
        public string Link { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Tipo da Aula do Curso é obrigatório.")]
        public TipoAula TipoAula { get; set; }

        //_____________________

        [Required(ErrorMessage = "Campo Status do Curso é obrigatório.")]
        public Status Status { get; set; }

        //_____________________

        public bool Certificado { get; set; }

        //_____________________

        [MinLength(3, ErrorMessage = "Campo Descrição do Curso com no mínimo 3 caracteres.")]
        [MaxLength(500, ErrorMessage = "Campo Descrição do Curso com no máximo 500 caracteres.")]
        public string Descricao { get; set; }
    }

    public class ModelCursoExclusao
    {
        [Required(ErrorMessage = "Campo Nome do Curso é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Curso com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Curso com no máximo 50 caracteres.")]
        public string Nome { get; set; }
    }

    public class ModelPesquisaCursoPorNome
    {
        [Required(ErrorMessage = "Campo Nome do Curso é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Curso com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome do Curso com no máximo 50 caracteres.")]
        public string Nome { get; set; }
    }

    public class ModelPesquisaCursoPorInstituicao
    {
        [Required(ErrorMessage = "Campo Intituição do Curso é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Intituição do Curso com no mínimo 3 caracteres.")]
        [MaxLength(100, ErrorMessage = "Campo Intituição do Curso com no máximo 100 caracteres.")]
        public string Instituicao { get; set; }
    }

    public class ModelPesquisaCursoPorCargaHoraria
    {
        [Required(ErrorMessage = "Campo Carga Horária do Curso é obrigatório.")]
        [MinLength(1, ErrorMessage = "Campo Carga Horária do Curso com no mínimo 1 caracteres.")]
        [MaxLength(5, ErrorMessage = "Campo Carga Horária do Curso com no máximo 5 caracteres.")]
        public Int16 CargaHoraria { get; set; }
    }

    public class ModelPesquisaCursoPorTipoAula
    {
        [Required(ErrorMessage = "Campo Tipo da Aula do Curso é obrigatório.")]
        public TipoAula TipoAula { get; set; }
    }

    public class ModelPesquisaCursoPorCertificado
    {
        [Required(ErrorMessage = "Campo Certificado do Curso é obrigatório.")]
        public bool Certificado { get; set; }
    }

    public class ModelPesquisaCursoPorStatus
    {
        [Required(ErrorMessage = "Campo Status do Curso é obrigatório.")]
        public Status Status { get; set; }
    }
}