using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;

namespace EFWindowsFormEjemplo01.Context.Repositories.Facades
{
    public interface IRepositorioInscripcion
    {
        List<InscripcionListDto> GetInscripciones(CursoListDto curso);
        bool Existe(InscripcionEditDto inscripcionDto);
        void Guardar(InscripcionEditDto inscripcionEditDto);
        void Borrar(int inscripcionId);
    }
}
