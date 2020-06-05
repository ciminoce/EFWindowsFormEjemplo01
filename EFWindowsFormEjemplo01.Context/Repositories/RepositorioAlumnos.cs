using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Entities.Entities;

namespace EFWindowsFormEjemplo01.Context.Repositories
{
    public class RepositorioAlumnos:IRepositorioAlumno
    {
        private readonly CursosDbContext _dbContext;

        public RepositorioAlumnos()
        {
            _dbContext=new CursosDbContext();
        }

        public List<Alumno> GetAlumnos()
        {
            return _dbContext.Alumnos.ToList();
        }

        public Alumno GetAlumnoPorId(int id)
        {
            return _dbContext.Alumnos.SingleOrDefault(a => a.AlumnoId == id);

        }

        public void Guardar(Alumno alumno)
        {
            if (alumno.AlumnoId==0)
            {
                _dbContext.Alumnos.Add(alumno);
            }
            else
            {
                var alumnoInDb = GetAlumnoPorId(alumno.AlumnoId);
                alumnoInDb.Nombre = alumno.Nombre;
                alumnoInDb.Apellido = alumno.Apellido;
                _dbContext.Entry(alumnoInDb).State = EntityState.Modified;
            }

            _dbContext.SaveChanges();
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

        public bool Existe(Alumno alumno)
        {
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
