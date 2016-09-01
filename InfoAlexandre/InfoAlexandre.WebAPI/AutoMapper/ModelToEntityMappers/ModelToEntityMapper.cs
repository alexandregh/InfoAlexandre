using AutoMapper;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.WebAPI.Models.Administrador;
using InfoAlexandre.WebAPI.Models.Categoria;
using InfoAlexandre.WebAPI.Models.Formacao;

namespace InfoAlexandre.WebApi.AutoMapper.ModelToEntityMappers
{
    public class ModelToEntityMapper : Profile
    {
        protected override void Configure()
        {
            #region Administrador

            Mapper.CreateMap<ModelAdministradorCadastro, Administradores>();
            Mapper.CreateMap<ModelAdministradorAtualizacao, Administradores>();
            Mapper.CreateMap<ModelAdministradorExclusao, Administradores>();

            #endregion

            #region Categoria

            Mapper.CreateMap<ModelCategoriaCadastro, Categorias>();
            Mapper.CreateMap<ModelCategoriaAtualizacao, Categorias>();
            Mapper.CreateMap<ModelCategoriaExclusao, Categorias>();

            #endregion

            #region Curso



            #endregion

            #region Evento



            #endregion

            #region Formação

            Mapper.CreateMap<ModelFormacaoCadastro, Formacoes>();
            Mapper.CreateMap<ModelFormacaoAtualizacao, Formacoes>();
            Mapper.CreateMap<MModelFormacaoExclusao, Formacoes>();

            #endregion

            #region Grupo



            #endregion
        }
    }
}