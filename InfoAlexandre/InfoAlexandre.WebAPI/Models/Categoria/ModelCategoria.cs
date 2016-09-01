using System;
using System.ComponentModel.DataAnnotations;

namespace InfoAlexandre.WebAPI.Models.Categoria
{
    public class ModelCategoriaCadastro
    {
        
    }

    public class ModelCategoriaAtualizacao
    {

    }

    public class ModelCategoriaExclusao
    {

    }

    public class ModelPesquisarCategoriaPorNome
    {
        [Required(ErrorMessage = "Campo Nome da Categoria é obrigatório.")]
        [MinLength(3, ErrorMessage = "Campo Nome da Categoria com no mínimo 3 caracteres.")]
        [MaxLength(50, ErrorMessage = "Campo Nome da Categoria com no máximo 50 caracteres.")]
        public string Nome { get; set; }
    }
}