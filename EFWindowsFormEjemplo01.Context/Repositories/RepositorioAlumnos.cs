using System.Collections.Generic;
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
