using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.Entities;

namespace EFWindowsFormEjemplo01.Context.Repositories.Facades
{
    public interface IRepositorioAlumno
    {
        List<AlumnoListDto> GetAlumnos();
        AlumnoEditDto GetAlumnoPorId(int id);
        void Guardar(Alumno alumno);
        void Borrar(int id);
        bool Existe(AlumnoEditDto alumno);
        bool EstaRelacionado(AlumnoListDto alumno);

    }
}
