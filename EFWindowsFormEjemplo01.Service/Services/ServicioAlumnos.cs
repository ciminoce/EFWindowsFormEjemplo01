using System.Collections.Generic;
using EFWindowsFormEjemplo01.Context.Repositories;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.Entities;
using EFWindowsFormEjemplo01.Entities.Maps;
using EFWindowsFormEjemplo01.Service.Services.Facades;

namespace EFWindowsFormEjemplo01.Service.Services
{
    public class ServicioAlumnos:IServicioAlumno
    {
        private readonly IRepositorioAlumno repositorio;

        public ServicioAlumnos()
        {
            repositorio=new RepositorioAlumnos();
        }
        public List<AlumnoListDto> GetAlumnos()
        {
            var listaAlumnos=repositorio.GetAlumnos();
            //var listaDto=new List<AlumnoListDto>();
            //foreach (var alumno in listaAlumnos)
            //{
            //    var alumnoDto = new AlumnoListDto
            //    {
            //        AlumnoId = alumno.AlumnoId,
            //        NombreCompleto = $"{alumno.Nombre} {alumno.Apellido}"
            //    };
            //    listaDto.Add(alumnoDto);
            //}
            var listaDto = Mapeador.CrearMapper()
                .Map<List<Alumno>, List<AlumnoListDto>>(listaAlumnos);

            return listaDto;
        }

        public AlumnoEditDto GetAlumnoPorId(int id)
        {
            var alumno= repositorio.GetAlumnoPorId(id);
            var alumnoEditDto = Mapeador.CrearMapper().Map<AlumnoEditDto>(alumno);
            return alumnoEditDto;
        }

        public void Guardar(AlumnoEditDto alumnoEditDto)
        {
            var alumno = Mapeador.CrearMapper().Map<Alumno>(alumnoEditDto);
            repositorio.Guardar(alumno);
        }

        public void Borrar(int id)
        {
            repositorio.Borrar(id);
        }

        public bool Existe(AlumnoEditDto alumnoEditDto)
        {
            Alumno alumno = Mapeador.CrearMapper().Map<Alumno>(alumnoEditDto);
            return repositorio.Existe(alumno);
        }

        public bool EstaRelacionado(AlumnoListDto alumnoListDto)
        {
            Alumno alumno = Mapeador.CrearMapper().Map<Alumno>(alumnoListDto);
            return repositorio.EstaRelacionado(alumno);
        }
    }
}
