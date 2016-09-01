using AutoMapper;
using InfoAlexandre.Domain.Domain.Entity;
using InfoAlexandre.WebAPI.Models.Administrador;

namespace InfoAlexandre.AutoMapper.AutoMapper.ModelToEntityMappers
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