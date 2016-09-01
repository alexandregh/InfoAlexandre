using AutoMapper;
using InfoAlexandre.WebApi.AutoMapper.EntityToModelMappers;
using InfoAlexandre.WebApi.AutoMapper.ModelToEntityMappers;

namespace InfoAlexandre.WebApi.AutoMapper.AutoMapperConfigs
{
    public class AutoMapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(
                mapper => 
                {
                    mapper.AddProfile<ModelToEntityMapper>();
                    mapper.AddProfile<EntityToModelMapper>();
                }
            );
        }
    }
}