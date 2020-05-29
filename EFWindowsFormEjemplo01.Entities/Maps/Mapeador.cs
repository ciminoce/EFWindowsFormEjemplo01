using AutoMapper;

namespace EFWindowsFormEjemplo01.Entities.Maps
{
    public class Mapeador
    {
        private static Mapper _mapper;
        static readonly MapperConfiguration Config = new MapperConfiguration(cfg =>
            cfg.AddProfile<MappingProfile>());

        public static Mapper CrearMapper()
        {
            _mapper = new Mapper(Config);
            return _mapper;
        }

    }
}
