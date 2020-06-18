using AutoMapper;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.DTOs.Profesor;
using EFWindowsFormEjemplo01.Entities.Entities;
using EFWindowsFormEjemplo01.Entities.Entities.Emun;

namespace EFWindowsFormEjemplo01.Entities.Maps
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            LoadMappingAlumnos();
            LoadMappingProfesores();
            LoadMappingCursos();
        }

        public void LoadMappingAlumnos()
        {
            CreateMap<Alumno, AlumnoListDto>()
                .ForMember(dest => dest.NombreCompleto, act => act.MapFrom(src => $"{src.Nombre} {src.Apellido}"));

            CreateMap<Alumno, AlumnoEditDto>();
            CreateMap<AlumnoEditDto, Alumno>();

            CreateMap<AlumnoEditDto, AlumnoListDto>()
                .ForMember(dest => dest.NombreCompleto, act => act.MapFrom(src => $"{src.Nombre} {src.Apellido}"));


        }

        public void LoadMappingProfesores()
        {
            CreateMap<Profesor, ProfesorListDto>()
                .ForMember(dest => dest.NombreCompleto, act => act.MapFrom(src => $"{src.Nombre} {src.Apellido}"));

            CreateMap<Profesor, ProfesorEditDto>();
            CreateMap<ProfesorEditDto, Profesor>();

            CreateMap<ProfesorEditDto, ProfesorListDto>()
                .ForMember(dest => dest.NombreCompleto, act => act.MapFrom(src => $"{src.Nombre} {src.Apellido}"));


        }

        public void LoadMappingCursos()
        {
            CreateMap<Curso, CursoListDto>()
                .ForMember(dest => dest.Profesor,
                    act => act.MapFrom(src => $"{src.Profesor.Nombre} {src.Profesor.Apellido}"));

            CreateMap<Curso, CursoMasInfoDto>()
                .ForMember(dest => dest.Profesor,
                    act => act.MapFrom(src => $"{src.Profesor.Nombre} {src.Profesor.Apellido}"))
                .ForMember(dest => dest.Nivel,
                    act => act.MapFrom(src =>
                        src.Nivel == Nivel.Principiante ? "Principiante" :
                        src.Nivel == Nivel.Medio ? "Medio" : "Avanzado"));

            CreateMap<CursoListDto, CursoEditDto>();
        }

    }
}
