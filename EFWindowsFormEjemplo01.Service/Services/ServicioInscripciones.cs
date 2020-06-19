using System.Collections.Generic;
using EFWindowsFormEjemplo01.Context.Repositories;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;
using EFWindowsFormEjemplo01.Service.Services.Facades;

namespace EFWindowsFormEjemplo01.Service.Services
{
    public class ServicioInscripciones:IServicioInscripcion
    {
        private readonly IRepositorioInscripcion _repositorio;

        public ServicioInscripciones()
        {
            _repositorio = new RepositorioInscripciones();
        }
        public List<InscripcionListDto> GetInscripciones()
        {
            return _repositorio.GetInscripciones();
        }

        public bool Existe(InscripcionEditDto inscripcionDto)
        {
            return _repositorio.Existe(inscripcionDto);
        }

        public void Guardar(InscripcionEditDto inscripcionEditDto)
        {
            _repositorio.Guardar(inscripcionEditDto);
        }
    }
}
