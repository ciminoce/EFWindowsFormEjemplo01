using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;
using EFWindowsFormEjemplo01.Entities.Entities;

namespace EFWindowsFormEjemplo01.Context.Repositories.Facades
{
    public interface IRepositorioInscripcion
    {
        List<InscripcionListDto> GetInscripciones(CursoListDto curso);
        bool Existe(InscripcionEditDto inscripcionDto);
        void Guardar(Inscripcion inscripcion);
        void Borrar(int inscripcionId);
        InscripcionEditDto GetInscripcionPorId(int id);
    }
}
