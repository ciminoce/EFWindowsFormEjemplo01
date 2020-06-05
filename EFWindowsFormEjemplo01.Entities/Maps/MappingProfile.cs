using AutoMapper;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.Entities;
using EFWindowsFormEjemplo01.Entities.ViewModels.Alumno;

namespace EFWindowsFormEjemplo01.Entities.Maps
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Alumno, AlumnoListDto>()
                .ForMember(dest => dest.NombreCompleto, act => act.MapFrom(src => $"{src.Nombre} {src.Apellido}"));

            CreateMap<Alumno, AlumnoEditDto>();
            CreateMap<AlumnoEditDto, Alumno>();

            CreateMap<AlumnoEditDto, AlumnoListDto>()
                .ForMember(dest => dest.NombreCompleto, act => act.MapFrom(src => $"{src.Nombre} {src.Apellido}"));

            CreateMap<AlumnoEditDto, AlumnoEditVm>();
            CreateMap<AlumnoEditVm, AlumnoEditDto>();

        }

    }
}
