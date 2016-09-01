using AutoMapper;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.WebAPI.Models.Administrador;

namespace InfoAlexandre.AutoMapper.AutoMapper.EntityToModelMappers
{
    public class EntityToModelMapper : Profile
    {
        protected override void Configure()
        {
            #region Administrador

            Mapper.CreateMap<Administradores, ModelAdministradorCadastro>();
            Mapper.CreateMap<Administradores, ModelAdministradorAtualizacao>();
            Mapper.CreateMap<Administradores, ModelAdministradorExclusao>();

            #endregion

            #region Categoria



            #endregion

            #region Curso



            #endregion

            #region Evento



            #endregion

            #region Formação



            #endregion

            #region Grupo



            #endregion
        }
    }
}