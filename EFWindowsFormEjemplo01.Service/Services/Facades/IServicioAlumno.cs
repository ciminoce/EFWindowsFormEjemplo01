using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.Entities;

namespace EFWindowsFormEjemplo01.Service.Services.Facades
{
    public interface IServicioAlumno
    {
        List<AlumnoListDto> GetAlumnos();
        Alumno GetAlumnoPorId(int id);
        void Guardar(Alumno alumno);
        void Borrar(Alumno alumno);
        bool Existe(Alumno alumno);
        bool EstaRelacionado(Alumno alumno);

    }
}
