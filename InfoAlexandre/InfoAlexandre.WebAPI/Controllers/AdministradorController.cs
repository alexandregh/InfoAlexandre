using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InfoAlexandre.WebAPI.Models.Administrador;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.App.IContractsAppServices.IContractsAppServicesEntity.IContractsAppServicesAdministradores;
using InfoAlexandre.Security.CriptographyPasswords;
using InfoAlexandre.Convertions.Convertions;
using AutoMapper;

namespace InfoAlexandre.WebAPI.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("infoalexandre/administrador")]
    public class AdministradorController : ApiController
    {
        #region Atributo

        private IContractsAppServicesAdministrador appServicesAdministrador;

        #endregion

        #region Construtor

        public AdministradorController()
        {

        }

        public AdministradorController(IContractsAppServicesAdministrador appServicesAdministrador)
        {
            this.appServicesAdministrador = appServicesAdministrador;
        }

        #endregion

        #region Implementação dos Métodos

        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Post(ModelAdministradorCadastro modelAdministradorCadastro)
        {
            if(ModelState.IsValid)
            {
                Administradores administrador = Mapper.Map<ModelAdministradorCadastro, Administradores>(modelAdministradorCadastro);
                administrador.DataCadastro = DateTime.Now;
                administrador.DataAlteracao = DateTime.Now;
                administrador.Senha = CriptographyPassword.CriptografarSenha(administrador.Senha);
                administrador = DataConvertions<Administradores>.AdministradorDataAllConvertion(administrador);
                appServicesAdministrador.InserirApp(administrador);
                return Request.CreateResponse(HttpStatusCode.OK, "Administrador " + modelAdministradorCadastro.Nome + " cadastrado com sucesso.");
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
        public HttpResponseMessage Put(ModelAdministradorAtualizacao modelAdministradorAtualizacao)
        {            
            if (ModelState.IsValid)
            {
                Administradores administrador = appServicesAdministrador.PesquisaAdministradorPorLoginSenhaApp(modelAdministradorAtualizacao.Login, CriptographyPassword.CriptografarSenha(modelAdministradorAtualizacao.Senha));
                if(administrador != null)
                {
                    administrador.Nome = modelAdministradorAtualizacao.Nome;
                    administrador.Sobrenome = modelAdministradorAtualizacao.Sobrenome;
                    administrador.Descricao = modelAdministradorAtualizacao.Descricao;
                    administrador.DataAlteracao = DateTime.Now;
                    administrador = DataConvertions<Administradores>.AdministradorDataAllConvertion(administrador);
                    appServicesAdministrador.AtualizarApp(administrador);
                    return Request.CreateResponse(HttpStatusCode.OK, "Administrador " + modelAdministradorAtualizacao.Nome + " atualizado com sucesso.");
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

        [HttpPut]
        [Route("modificar")]
        public HttpResponseMessage Put(ModelAdministradorModificacao modelAdministradorModificacao)
        {            
            if (ModelState.IsValid)
            {
                Administradores administrador = appServicesAdministrador.PesquisaAdministradorPorLoginSenhaApp(modelAdministradorModificacao.Login, CriptographyPassword.CriptografarSenha(modelAdministradorModificacao.Senha));
                if (administrador != null)
                {
                    administrador.Login = modelAdministradorModificacao.LoginNovo;
                    administrador.Senha = CriptographyPassword.CriptografarSenha(modelAdministradorModificacao.SenhaNova);
                    administrador.DataAlteracao = DateTime.Now;
                    appServicesAdministrador.AtualizarApp(administrador);
                    return Request.CreateResponse(HttpStatusCode.OK, "Login e/ou Senha do Administrador " + modelAdministradorModificacao.Nome + " atualizado(s) com sucesso.");
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
        public HttpResponseMessage Delete(ModelAdministradorExclusao modelAdministradorExclusao)
        {
            if (ModelState.IsValid)
            {
                Administradores administrador = appServicesAdministrador.PesquisaAdministradorPorLoginSenhaApp(modelAdministradorExclusao.Login, CriptographyPassword.CriptografarSenha(modelAdministradorExclusao.Senha));
                if(administrador != null)
                {
                    appServicesAdministrador.ExcluirApp(administrador);
                    return Request.CreateResponse(HttpStatusCode.OK, "Administrador " + modelAdministradorExclusao.Nome + " excluido com sucesso.");
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
            if(!String.IsNullOrEmpty(nome))
            {
                ModelPesquisaAdministradorPorNome modelPesquisaAdministradorPorNome = new ModelPesquisaAdministradorPorNome();
                modelPesquisaAdministradorPorNome.Nome = nome;
                if (ModelState.IsValid)
                {                    
                    Administradores administrador = appServicesAdministrador.PesquisarAdministradorPorNomeApp(modelPesquisaAdministradorPorNome.Nome.ToLower());
                    if (administrador != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, administrador);
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

        [HttpGet]
        [Route("retornarporsobrenome")]
        public HttpResponseMessage GetValueBySobrenome(string sobrenome)
        {
            if (!String.IsNullOrEmpty(sobrenome))
            {
                ModelPesquisaAdministradorPorSobrenome modelPesquisaAdministradorPorSobrenome = new ModelPesquisaAdministradorPorSobrenome();
                modelPesquisaAdministradorPorSobrenome.Sobrenome = sobrenome;
                if (ModelState.IsValid)
                {
                    Administradores administrador = appServicesAdministrador.PesquisaAdministradorPorSobrenomeApp(modelPesquisaAdministradorPorSobrenome.Sobrenome.ToLower());
                    if (administrador != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, administrador);
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

        [HttpGet]
        [Route("retornarporloginsenha")]
        public HttpResponseMessage GetValueByLoginSenha(string login, string senha)
        {
            if (!String.IsNullOrEmpty(login) && !String.IsNullOrEmpty(senha))
            {
                ModelPesquisaAdministradorPorLoginSenha modelPesquisaAdministradorPorLoginSenha = new ModelPesquisaAdministradorPorLoginSenha();
                modelPesquisaAdministradorPorLoginSenha.Login = login;
                modelPesquisaAdministradorPorLoginSenha.Senha = CriptographyPassword.CriptografarSenha(senha);
                if (ModelState.IsValid)
                {
                    Administradores administrador = appServicesAdministrador.PesquisaAdministradorPorLoginSenhaApp(modelPesquisaAdministradorPorLoginSenha.Login.ToLower(), modelPesquisaAdministradorPorLoginSenha.Senha);
                    if (administrador != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, administrador);
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

        #endregion
    }
}