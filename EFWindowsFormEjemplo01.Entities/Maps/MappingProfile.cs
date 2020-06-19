using AutoMapper;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;
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
            LoadMappingInscripciones();
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
            CreateMap<Curso, CursoListDto>();

            CreateMap<Curso, CursoMasInfoDto>()
                .ForMember(dest => dest.Profesor,
                    act => act.MapFrom(src => $"{src.Profesor.Nombre} {src.Profesor.Apellido}"))
                .ForMember(dest => dest.Nivel,
                    act => act.MapFrom(src =>
                        src.Nivel == Nivel.Principiante ? "Principiante" :
                        src.Nivel == Nivel.Medio ? "Medio" : "Avanzado"));

            CreateMap<CursoEditDto, CursoListDto>();

            CreateMap<Curso, CursoEditDto>()
                .ForMember(dest=>dest.ProfesorListDto, act=>act.MapFrom(src=>src.Profesor));
            CreateMap<CursoEditDto, Curso>()
                .ForMember(dest => dest.ProfesorId, act => act.MapFrom(src => src.ProfesorListDto.ProfesorId));
        }

        public void LoadMappingInscripciones()
        {
            CreateMap<Inscripcion, InscripcionListDto>()
                .ForMember(dest => dest.CursoListDto, act => act.MapFrom(src => src.Curso))
                .ForMember(dest => dest.AlumnoListDto, act => act.MapFrom(src => src.Alumno));

            CreateMap<Inscripcion, InscripcionEditDto>()
                .ForMember(dest => dest.CursoListDto, act => act.MapFrom(src => src.Curso))
                .ForMember(dest => dest.AlumnoListDto, act => act.MapFrom(src => src.Alumno));

            CreateMap<InscripcionEditDto, Inscripcion>()
                .ForMember(dest => dest.CursoId, act => act.MapFrom(src => src.CursoListDto.CursoId))
                .ForMember(dest => dest.AlumnoId, act => act.MapFrom(src => src.AlumnoListDto.AlumnoId));

            CreateMap<InscripcionEditDto, InscripcionListDto>();
        }
    }
}
