using AutoMapper;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.DTOs.Profesor;
using EFWindowsFormEjemplo01.Entities.Entities;
using EFWindowsFormEjemplo01.Entities.ViewModels.Alumno;
using EFWindowsFormEjemplo01.Entities.ViewModels.Profesor;

namespace EFWindowsFormEjemplo01.Entities.Maps
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            LoadMappingAlumnos();
            LoadMappingProfesores();
        }

        public void LoadMappingAlumnos()
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

        public void LoadMappingProfesores()
        {
            CreateMap<Profesor, ProfesorListDto>()
                .ForMember(dest => dest.NombreCompleto, act => act.MapFrom(src => $"{src.Nombre} {src.Apellido}"));

            CreateMap<Profesor, ProfesorEditDto>();
            CreateMap<ProfesorEditDto, Profesor>();

            CreateMap<ProfesorEditDto, ProfesorListDto>()
                .ForMember(dest => dest.NombreCompleto, act => act.MapFrom(src => $"{src.Nombre} {src.Apellido}"));

            CreateMap<ProfesorEditDto, ProfesorEditVm>();
            CreateMap<ProfesorEditVm, ProfesorEditDto>();

        }

    }
}
