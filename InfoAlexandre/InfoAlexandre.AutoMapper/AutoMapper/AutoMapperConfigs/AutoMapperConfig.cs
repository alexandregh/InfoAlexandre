using AutoMapper;
using InfoAlexandre.AutoMapper.AutoMapper.EntityToModelMappers;
using InfoAlexandre.AutoMapper.AutoMapper.ModelToEntityMappers;

namespace InfoAlexandre.AutoMapper.AutoMapper.AutoMapperConfigs
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
                    AutoMapperConfig.Register();
                }
            );
        }
    }
}