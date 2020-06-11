using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.DTOs.Profesor;
using EFWindowsFormEjemplo01.Entities.Entities;

namespace EFWindowsFormEjemplo01.Context.Repositories.Facades
{
    public interface IRepositorioProfesor
    {
        List<ProfesorListDto> GetProfesores();
        ProfesorEditDto GetProfesorPorId(int id);
        void Guardar(ProfesorEditDto profesor);
        void Borrar(int id);
        bool Existe(ProfesorEditDto profesor);
        bool EstaRelacionado(Profesor profesor);

    }
}
