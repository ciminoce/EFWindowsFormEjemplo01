using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;

namespace EFWindowsFormEjemplo01.Context.Repositories.Facades
{
    public interface IRepositorioInscripcion
    {
        List<InscripcionListDto> GetInscripciones();
        bool Existe(InscripcionEditDto inscripcionDto);
        void Guardar(InscripcionEditDto inscripcionEditDto);
    }
}
