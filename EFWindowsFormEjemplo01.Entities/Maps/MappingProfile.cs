using AutoMapper;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.Entities;

namespace EFWindowsFormEjemplo01.Entities.Maps
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Alumno, AlumnoListDto>()
                .ForMember(dest => dest.NombreCompleto, act => act.MapFrom(src => $"{src.Nombre} {src.Apellido}"));

        }

    }
}
