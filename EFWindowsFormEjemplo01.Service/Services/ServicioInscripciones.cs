using System.Collections.Generic;
using EFWindowsFormEjemplo01.Context;
using EFWindowsFormEjemplo01.Context.Repositories;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;
using EFWindowsFormEjemplo01.Service.Services.Facades;

namespace EFWindowsFormEjemplo01.Service.Services
{
    public class ServicioInscripciones:IServicioInscripcion
    {
        private readonly IRepositorioInscripcion _repositorio;
        private IUnitOfWork _unitOfWork;


        public ServicioInscripciones()
        {
            var dbContext=new CursosDbContext();
            _repositorio = new RepositorioInscripciones(dbContext);
            _unitOfWork=new UnitofWork(dbContext);
        }
        public List<InscripcionListDto> GetInscripciones(CursoListDto curso)
        {
            return _repositorio.GetInscripciones(curso);
        }

        public bool Existe(InscripcionEditDto inscripcionDto)
        {
            return _repositorio.Existe(inscripcionDto);
        }

        public void Guardar(InscripcionEditDto inscripcionEditDto)
        {
            _repositorio.Guardar(inscripcionEditDto);
        }

        public void Borrar(int inscripcionId)
        {
            _repositorio.Borrar(inscripcionId);
        }
    }
}
