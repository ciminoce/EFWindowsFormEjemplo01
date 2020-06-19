using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;

namespace EFWindowsFormEjemplo01.Service.Services.Facades
{
    public interface IServicioInscripcion
    {
        List<InscripcionListDto> GetInscripciones();
        bool Existe(InscripcionEditDto inscripcionDto);
        void Guardar(InscripcionEditDto inscripcionEditDto);
    }
}
