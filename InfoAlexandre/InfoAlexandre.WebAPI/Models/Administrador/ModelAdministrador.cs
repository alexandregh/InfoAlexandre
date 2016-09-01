using System;
using System.ComponentModel.DataAnnotations;

namespace InfoAlexandre.WebAPI.Models.Administrador
{
    public class ModelAdministradorCadastro
    {
        [Required(ErrorMessage ="Campo Nome do Administrador é obrigatório.")]
        [MinLength(3,ErrorMessage = "Campo Nome do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(20, ErrorMessage = "Campo Nome do Administrador com no máximo 20 caracteres.")]
        public string Nome { get; set; }
        
        //______________________

        [Required(ErrorMessage = "Campo Sobrenome do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Sobrenome do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Campo Sobrenome do Administrador com no máximo 30 caracteres.")]
        public string Sobrenome { get; set; }

        //______________________

        [Required(ErrorMessage = "Campo Login do Administrador é obrigatório.")]
        [MinLength(5, ErrorMessage = "Campo Login do Administrador com no mínimo 5 caracteres.")]
        [MaxLength(20, ErrorMessage = "Campo Login do Administrador com no máximo 20 caracteres.")]
        public string Login { get; set; }

        //______________________

        [Required(ErrorMessage = "Campo Senha do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Senha do Administrador com no mínimo 6 caracteres.")]
        [MaxLength(20, ErrorMessage = "Campo Senha do Administrador com no máximo 20 caracteres.")]
        public string Senha { get; set; }

        //______________________

        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }

        //______________________

        [DataType(DataType.DateTime)]
        public DateTime DataAlteracao { get; set; }

        //______________________

        [MinLength(3, ErrorMessage = "Campo Descrição do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(500, ErrorMessage = "Campo Descrição do Administrador com no máximo 500 caracteres.")]
        public string Descricao { get; set; }
    }

    public class ModelAdministradorAtualizacao
    {
        [Required(ErrorMessage = "Campo Nome do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(20, ErrorMessage = "Campo Nome do Administrador com no máximo 20 caracteres.")]
        public string Nome { get; set; }

        //______________________

        [Required(ErrorMessage = "Campo Sobrenome do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Sobrenome do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Campo Sobrenome do Administrador com no máximo 30 caracteres.")]
        public string Sobrenome { get; set; }

        //______________________

        [Required(ErrorMessage = "Campo Login do Administrador é obrigatório.")]
        [MinLength(5, ErrorMessage = "Campo Login do Administrador com no mínimo 5 caracteres.")]
        [MaxLength(20, ErrorMessage = "Campo Login do Administrador com no máximo 20 caracteres.")]
        public string Login { get; set; }

        //______________________

        [Required(ErrorMessage = "Campo Senha do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Senha do Administrador com no mínimo 6 caracteres.")]
        [MaxLength(20, ErrorMessage = "Campo Senha do Administrador com no máximo 20 caracteres.")]
        public string Senha { get; set; }

        //______________________

        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }

        //______________________

        [DataType(DataType.DateTime)]
        public DateTime DataAlteracao { get; set; }

        //______________________

        [MinLength(3, ErrorMessage = "Campo Descrição do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(500, ErrorMessage = "Campo Descrição do Administrador com no máximo 500 caracteres.")]
        public string Descricao { get; set; }
    }

    public class ModelAdministradorModificacao
    {
        public string Nome { get; set; }

        //______________________

        [Required(ErrorMessage = "Campo Login do Administrador é obrigatório.")]
        public string Login { get; set; }

        //______________________

        [Required(ErrorMessage = "Campo Senha do Administrador é obrigatório.")]
        public string Senha { get; set; }

        //______________________

        [Required(ErrorMessage = "Campo Novo Login do Administrador é obrigatório.")]
        public string LoginNovo { get; set; }

        //______________________

        [Required(ErrorMessage = "Campo Nova Senha do Administrador é obrigatório.")]
        public string SenhaNova { get; set; }
    }

    public class ModelAdministradorExclusao
    {
        public string Nome { get; set; }

        //______________________

        [Required(ErrorMessage = "Campo Login do Administrador é obrigatório.")]
        public string Login { get; set; }

        //______________________

        [Required(ErrorMessage = "Campo Senha do Administrador é obrigatório.")]
        public string Senha { get; set; }
    }

    public class ModelPesquisaAdministradorPorNome
    {
        [Required(ErrorMessage = "Campo Nome do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(20, ErrorMessage = "Campo Nome do Administrador com no máximo 20 caracteres.")]
        public string Nome { get; set; }
    }

    public class ModelPesquisaAdministradorPorSobrenome
    {
        [Required(ErrorMessage = "Campo Sobrenome do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Sobrenome do Administrador com no mínimo 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Campo Sobrenome do Administrador com no máximo 30 caracteres.")]
        public string Sobrenome { get; set; }
    }

    public class ModelPesquisaAdministradorPorLoginSenha
    {
        [Required(ErrorMessage = "Campo Login do Administrador é obrigatório.")]
        [MinLength(5, ErrorMessage = "Campo Login do Administrador com no mínimo 5 caracteres.")]
        [MaxLength(20, ErrorMessage = "Campo Login do Administrador com no máximo 20 caracteres.")]
        public string Login { get; set; }

        //______________________

        [Required(ErrorMessage = "Campo Senha do Administrador é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Senha do Administrador com no mínimo 6 caracteres.")]
        [MaxLength(20, ErrorMessage = "Campo Senha do Administrador com no máximo 20 caracteres.")]
        public string Senha { get; set; }
    }
}