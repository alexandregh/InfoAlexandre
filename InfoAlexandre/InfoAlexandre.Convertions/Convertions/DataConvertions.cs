using InfoAlexandre.Domain.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoAlexandre.Convertions.Convertions
{
    public class DataConvertions<TEntity> where TEntity : class
    {
        #region Implementação dos Métodos

        public static Administradores AdministradorDataAllConvertion(Administradores administrador)
        {
            if (administrador != null)
            {
                administrador.Nome = administrador.Nome.Trim().ToLower();
                administrador.Sobrenome = administrador.Sobrenome.Trim().ToLower();
                administrador.Login = administrador.Login.Trim().ToLower();                
                return administrador;
            }
            return null;
        }

        public static Formacoes FormacaoDataAllConvertion(Formacoes formacao)
        {
            if(formacao != null)
            {
                formacao.Nome = formacao.Nome.Trim().ToLower();
                formacao.Instituicao = formacao.Instituicao.Trim().ToLower();
                formacao.Link = formacao.Link.Trim().ToLower();
                formacao.Categoria.Nome = formacao.Categoria.Nome.Trim().ToLower();
                formacao.Categoria.Descricao = formacao.Categoria.Descricao.Trim().ToLower();
                return formacao;
            }
            return null;
        }

        #endregion
    }
}