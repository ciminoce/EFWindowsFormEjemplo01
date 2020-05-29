using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.Entities;

namespace EFWindowsFormEjemplo01.Context.Repositories.Facades
{
    public interface IRepositorioAlumno
    {
        List<Alumno> GetAlumnos();
        Alumno GetAlumnoPorId(int id);
        void Guardar(Alumno alumno);
        void Borrar(Alumno alumno);
        bool Existe(Alumno alumno);
        bool EstaRelacionado(Alumno alumno);

    }
}
