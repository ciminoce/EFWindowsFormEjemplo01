using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.Entities;
using EFWindowsFormEjemplo01.Entities.Maps;

namespace EFWindowsFormEjemplo01.Context.Repositories
{
    public class RepositorioAlumnos:IRepositorioAlumno
    {
        private readonly CursosDbContext _dbContext;

        public RepositorioAlumnos()
        {
            _dbContext=new CursosDbContext();
        }

        public List<AlumnoListDto> GetAlumnos()
        {
            var listaAlumnos= _dbContext.Alumnos.ToList();
            var listaDto = Mapeador.CrearMapper().Map<List<Alumno>, List<AlumnoListDto>>(listaAlumnos);
            return listaDto;
        }

        public AlumnoEditDto GetAlumnoPorId(int id)
        {
            var alumno= _dbContext.Alumnos.SingleOrDefault(a => a.AlumnoId == id);
            return Mapeador.CrearMapper().Map<Alumno, AlumnoEditDto>(alumno);

        }

        public void Guardar(AlumnoEditDto alumnoEditDto)
        {
            var alumno = Mapeador.CrearMapper().Map<AlumnoEditDto, Alumno>(alumnoEditDto);
            if (alumno.AlumnoId==0)
            {
                _dbContext.Alumnos.Add(alumno);
            }
            else
            {
                var alumnoInDb = _dbContext.Alumnos.SingleOrDefault(a => a.AlumnoId == alumno.AlumnoId);
                if (alumnoInDb != null)
                {
                    alumnoInDb.Nombre = alumno.Nombre;
                    alumnoInDb.Apellido = alumno.Apellido;
                    _dbContext.Entry(alumnoInDb).State = EntityState.Modified;
                }
            }

            _dbContext.SaveChanges();
            alumnoEditDto.AlumnoId = alumno.AlumnoId;
        }

        public void Borrar(int id)
        {
            var alumnoInDb = _dbContext.Alumnos.SingleOrDefault(a => a.AlumnoId == id);
            if (alumnoInDb!=null)
            {
                _dbContext.Entry(alumnoInDb).State = EntityState.Deleted;
                _dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("Alumno inexistente");
            }
        }

        public bool Existe(AlumnoEditDto alumnoEditDto)
        {
            var alumno = Mapeador.CrearMapper().Map<AlumnoEditDto, Alumno>(alumnoEditDto);

            if (alumno.AlumnoId>0)
            {
                //fue editado
                return _dbContext.Alumnos.Any(a =>
                    a.Nombre == alumno.Nombre && a.Apellido == alumno.Apellido
                                              && a.AlumnoId != alumno.AlumnoId);
            }
            //fue agregado
            return _dbContext.Alumnos.Any(a => a.Nombre == alumno.Nombre 
                                               && a.Apellido == alumno.Apellido);
        }

        public bool EstaRelacionado(Alumno alumno)
        {
            //TODO:Desarrollar cuando se haya hecho la parte de inscripciones
            return false;
        }
    }
}
