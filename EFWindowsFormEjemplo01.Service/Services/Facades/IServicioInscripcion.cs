using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;
using EFWindowsFormEjemplo01.Entities.Entities;

namespace EFWindowsFormEjemplo01.Service.Services.Facades
{
    public interface IServicioInscripcion
    {
        List<InscripcionListDto> GetInscripciones(CursoListDto curso);
        bool Existe(InscripcionEditDto inscripcionDto);
        void Guardar(InscripcionEditDto inscripcionDto);
        void Borrar(int inscripcionId);
    }
}
