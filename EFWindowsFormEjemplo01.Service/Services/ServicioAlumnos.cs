using System.Collections.Generic;
using EFWindowsFormEjemplo01.Context;
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
        private readonly IRepositorioAlumno _repositorio;
        private IUnitOfWork _unitOfWork;
       

        public ServicioAlumnos()
        {
            var dbContext=new CursosDbContext();

            _repositorio=new RepositorioAlumnos(dbContext);
            _unitOfWork=new UnitofWork(dbContext);
        }
        public List<AlumnoListDto> GetAlumnos()
        {
            return _repositorio.GetAlumnos();
        }

        public AlumnoEditDto GetAlumnoPorId(int id)
        {
            var alumno= _repositorio.GetAlumnoPorId(id);
            var alumnoEditDto = Mapeador.CrearMapper().Map<AlumnoEditDto>(alumno);
            return alumnoEditDto;
        }

        public void Guardar(AlumnoEditDto alumnoEditDto)
        {
            var alumno = Mapeador.CrearMapper().Map<AlumnoEditDto, Alumno>(alumnoEditDto);
            _repositorio.Guardar(alumno);
            _unitOfWork.SaveChanges();
            alumnoEditDto.AlumnoId = alumno.AlumnoId;
        }

        public void Borrar(int id)
        {

            _repositorio.Borrar(id);
            _unitOfWork.SaveChanges();
        }

        public bool Existe(AlumnoEditDto alumnoEditDto)
        {
            //Alumno alumno = Mapeador.CrearMapper().Map<Alumno>(alumnoEditDto);
            return _repositorio.Existe(alumnoEditDto);
        }

        public bool EstaRelacionado(AlumnoListDto alumnoListDto)
        {
            //Alumno alumno = Mapeador.CrearMapper().Map<Alumno>(alumnoListDto);
            return _repositorio.EstaRelacionado(alumnoListDto);
        }
    }
}
