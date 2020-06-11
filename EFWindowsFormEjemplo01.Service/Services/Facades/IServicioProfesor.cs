using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.DTOs.Profesor;

namespace EFWindowsFormEjemplo01.Service.Services.Facades
{
    public interface IServicioProfesor
    {
        List<ProfesorListDto> GetProfesores();
        ProfesorEditDto GetProfesorPorId(int id);
        void Guardar(ProfesorEditDto profesor);
        void Borrar(int id);
        bool Existe(ProfesorEditDto profesor);
        bool EstaRelacionado(ProfesorListDto alumno);

    }
}
