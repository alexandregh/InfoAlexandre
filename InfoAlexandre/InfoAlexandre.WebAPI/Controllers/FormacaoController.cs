using AutoMapper;
using InfoAlexandre.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesFormacoes;
using InfoAlexandre.Convertions.Convertions;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.WebAPI.Models.Formacao;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InfoAlexandre.WebAPI.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("infoalexandre/formacao")]
    public class FormacaoController : ApiController
    {
        #region Atributo

        private IContractsAppServicesFormacao appServicesFormacao;

        #endregion

        #region Construtor

        public FormacaoController()
        {

        }

        public FormacaoController(IContractsAppServicesFormacao appServicesFormacao)
        {
            this.appServicesFormacao = appServicesFormacao;
        }

        #endregion

        #region Implementação dos Métodos

        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Post(ModelFormacaoCadastro modelFormacaoCadastro)
        {
            if (ModelState.IsValid)
            {
                Formacoes formacao = Mapper.Map<ModelFormacaoCadastro, Formacoes>(modelFormacaoCadastro);
                //Categorias formacao. categoria = Mapper.Map<ModelFormacaoCadastro, Categorias>(modelFormacaoCadastro);
                formacao.Categoria = new Categorias();
                formacao.Categoria.Nome = modelFormacaoCadastro.NomeCategoria;
                formacao.Categoria.Descricao = modelFormacaoCadastro.DescricaoCategoria;
                formacao = DataConvertions<Formacoes>.FormacaoDataAllConvertion(formacao);
                appServicesFormacao.InserirApp(formacao);
                return Request.CreateResponse(HttpStatusCode.OK, "Formação " + modelFormacaoCadastro.Nome + " cadastrada com sucesso.");
            }
            else
            {
                var listagemErros = new List<string>();
                foreach (var state in ModelState)
                {
                    foreach (var e in state.Value.Errors)
                    {
                        listagemErros.Add(e.ErrorMessage);
                    }
                }
                return Request.CreateResponse(HttpStatusCode.Forbidden, listagemErros);
            }
        }

        [HttpPut]
        [Route("atualizar")]
        public HttpResponseMessage Put(ModelFormacaoAtualizacao modelFormacaoAtualizacao)
        {
            if (ModelState.IsValid)
            {
                Formacoes formacao = appServicesFormacao.PesquisarFormacaoPorNomeApp(modelFormacaoAtualizacao.NomeAtual.ToLower());
                if (formacao != null)
                {
                    formacao.Categoria = new Categorias();
                    formacao.Nome = modelFormacaoAtualizacao.Nome;
                    formacao.Instituicao = modelFormacaoAtualizacao.Instituicao;
                    formacao.CargaHoraria = modelFormacaoAtualizacao.CargaHoraria;
                    formacao.Link = modelFormacaoAtualizacao.Link;
                    formacao.TipoAula = modelFormacaoAtualizacao.TipoAula;
                    formacao.TipoEnsino = modelFormacaoAtualizacao.TipoEnsino;
                    formacao.Certificado = modelFormacaoAtualizacao.Certificado;
                    formacao.Status = modelFormacaoAtualizacao.Status;
                    formacao.Descricao = modelFormacaoAtualizacao.Descricao;
                    formacao.Categoria.Nome = modelFormacaoAtualizacao.NomeCategoria;
                    formacao.Categoria.Descricao = modelFormacaoAtualizacao.DescricaoCategoria;
                    formacao = DataConvertions<Formacoes>.FormacaoDataAllConvertion(formacao);
                    appServicesFormacao.AtualizarApp(formacao);
                    return Request.CreateResponse(HttpStatusCode.OK, "Formação " + modelFormacaoAtualizacao.Nome + " atualizada com sucesso.");
                }
                return null;
            }
            else
            {
                var listagemErros = new List<string>();
                foreach (var state in ModelState)
                {
                    foreach (var e in state.Value.Errors)
                    {
                        listagemErros.Add(e.ErrorMessage);
                    }
                }
                return Request.CreateResponse(HttpStatusCode.Forbidden, listagemErros);
            }
        }

        [HttpDelete]
        [Route("excluir")]
        public HttpResponseMessage Delete(MModelFormacaoExclusao modelFormacaoExclusao)
        {
            if (ModelState.IsValid)
            {
                Formacoes formacao = appServicesFormacao.PesquisarFormacaoPorNomeApp(modelFormacaoExclusao.Nome.ToLower());
                if (formacao != null)
                {
                    appServicesFormacao.ExcluirApp(formacao);
                    return Request.CreateResponse(HttpStatusCode.OK, "Formação " + modelFormacaoExclusao.Nome + " excluida com sucesso.");
                }
                return null;
            }
            else
            {
                var listagemErros = new List<string>();
                foreach (var state in ModelState)
                {
                    foreach (var e in state.Value.Errors)
                    {
                        listagemErros.Add(e.ErrorMessage);
                    }
                }
                return Request.CreateResponse(HttpStatusCode.Forbidden, listagemErros);
            }
        }

        [HttpGet]
        [Route("retornarpornome")]
        public HttpResponseMessage GetValueByNome(string nome)
        {
            if (!String.IsNullOrEmpty(nome))
            {
                ModelPesquisaFormacoesPorNome modelPesquisaFormacoesPorNome = new ModelPesquisaFormacoesPorNome();
                modelPesquisaFormacoesPorNome.Nome = nome;
                if (ModelState.IsValid)
                {
                    Formacoes formacao = appServicesFormacao.PesquisarFormacaoPorNomeApp(modelPesquisaFormacoesPorNome.Nome.ToLower());
                    if (formacao != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, formacao);
                    }
                    return null;
                }
                return null;
            }
            else
            {
                var listagemErros = new List<string>();
                foreach (var state in ModelState)
                {
                    foreach (var e in state.Value.Errors)
                    {
                        listagemErros.Add(e.ErrorMessage);
                    }
                }
                return Request.CreateResponse(HttpStatusCode.Forbidden, listagemErros);
            }
        }

        //[HttpGet]
        //[Route("retornarporsobrenome")]
        //public HttpResponseMessage GetValueBySobrenome(string sobrenome)
        //{
        //    //if (!String.IsNullOrEmpty(sobrenome))
        //    //{
        //    //    ModelPesquisaAdministradorPorSobrenome modelPesquisaAdministradorPorSobrenome = new ModelPesquisaAdministradorPorSobrenome();
        //    //    modelPesquisaAdministradorPorSobrenome.Sobrenome = sobrenome;
        //    //    if (ModelState.IsValid)
        //    //    {
        //    //        Administradores administrador = appServicesAdministrador.PesquisaAdministradorPorSobrenomeApp(modelPesquisaAdministradorPorSobrenome.Sobrenome.ToLower());
        //    //        if (administrador != null)
        //    //        {
        //    //            return Request.CreateResponse(HttpStatusCode.OK, administrador);
        //    //        }
        //    //        return null;
        //    //    }
        //    //    return null;
        //    //}
        //    //else
        //    //{
        //    //    var listagemErros = new List<string>();
        //    //    foreach (var state in ModelState)
        //    //    {
        //    //        foreach (var e in state.Value.Errors)
        //    //        {
        //    //            listagemErros.Add(e.ErrorMessage);
        //    //        }
        //    //    }
        //    //    return Request.CreateResponse(HttpStatusCode.Forbidden, listagemErros);
        //    //}
        //}

        //[HttpGet]
        //[Route("retornarporloginsenha")]
        //public HttpResponseMessage GetValueByLoginSenha(string login, string senha)
        //{
        //    if (!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(senha))
        //    {
        //        ModelPesquisaAdministradorPorLoginSenha modelPesquisaAdministradorPorLoginSenha = new ModelPesquisaAdministradorPorLoginSenha();
        //        modelPesquisaAdministradorPorLoginSenha.Login = login;
        //        modelPesquisaAdministradorPorLoginSenha.Senha = CriptographyPassword.CriptografarSenha(senha);
        //        if (ModelState.IsValid)
        //        {
        //            Administradores administrador = appServicesAdministrador.PesquisaAdministradorPorLoginSenhaApp(modelPesquisaAdministradorPorLoginSenha.Login.ToLower(), modelPesquisaAdministradorPorLoginSenha.Senha);
        //            if (administrador != null)
        //            {
        //                return Request.CreateResponse(HttpStatusCode.OK, administrador);
        //            }
        //            return null;
        //        }
        //        return null;
        //    }
        //    else
        //    {
        //        var listagemErros = new List<string>();
        //        foreach (var state in ModelState)
        //        {
        //            foreach (var e in state.Value.Errors)
        //            {
        //                listagemErros.Add(e.ErrorMessage);
        //            }
        //        }
        //        return Request.CreateResponse(HttpStatusCode.Forbidden, listagemErros);
        //    }
        //}

        #endregion
    }
}