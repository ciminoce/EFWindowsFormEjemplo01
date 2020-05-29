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

        public Alumno GetAlumnoPorId(int id)
        {
            return repositorio.GetAlumnoPorId(id);
        }

        public void Guardar(Alumno alumno)
        {
            throw new System.NotImplementedException();
        }

        public void Borrar(Alumno alumno)
        {
            throw new System.NotImplementedException();
        }

        public bool Existe(Alumno alumno)
        {
            throw new System.NotImplementedException();
        }

        public bool EstaRelacionado(Alumno alumno)
        {
            throw new System.NotImplementedException();
        }
    }
}
