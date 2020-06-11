using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;

namespace EFWindowsFormEjemplo01.Service.Services.Facades
{
    public interface IServicioAlumno
    {
        List<AlumnoListDto> GetAlumnos();
        AlumnoEditDto GetAlumnoPorId(int id);
        void Guardar(AlumnoEditDto alumno);
        void Borrar(int id);
        bool Existe(AlumnoEditDto alumno);
        bool EstaRelacionado(AlumnoListDto alumno);

    }
}
