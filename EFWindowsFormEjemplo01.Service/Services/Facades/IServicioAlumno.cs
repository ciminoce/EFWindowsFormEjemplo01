using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.Entities;

namespace EFWindowsFormEjemplo01.Service.Services.Facades
{
    public interface IServicioAlumno
    {
        List<AlumnoListDto> GetAlumnos();
        AlumnoEditDto GetAlumnoPorId(int id);
        void Guardar(AlumnoEditDto alumno);
        void Borrar(int id);
        bool Existe(Alumno alumno);
        bool EstaRelacionado(Alumno alumno);

    }
}
