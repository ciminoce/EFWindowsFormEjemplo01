using System;
using System.Collections.Generic;
using System.Transactions;
using EFWindowsFormEjemplo01.Context;
using EFWindowsFormEjemplo01.Context.Repositories;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;
using EFWindowsFormEjemplo01.Entities.Entities;
using EFWindowsFormEjemplo01.Entities.Maps;
using EFWindowsFormEjemplo01.Service.Services.Facades;

namespace EFWindowsFormEjemplo01.Service.Services
{
    public class ServicioInscripciones:IServicioInscripcion
    {
        private readonly IRepositorioInscripcion _repositorio;
        private readonly IRepositorioCurso _repositorioCursos;
        private IUnitOfWork _unitOfWork;


        public ServicioInscripciones()
        {
            var dbContext=new CursosDbContext();
            _repositorio = new RepositorioInscripciones(dbContext);
            _repositorioCursos=new RepositorioCursos(dbContext);
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
            var inscripcion = Mapeador.CrearMapper().Map<InscripcionEditDto, Inscripcion>(inscripcionEditDto);

            try
            {
                using (var scope = new TransactionScope(TransactionScopeOption.Required))
                {
                    _repositorio.Guardar(inscripcion);
                    _unitOfWork.SaveChanges();
                    var cursoDto = _repositorioCursos.GetCursoPorId(inscripcion.CursoId);
                    var curso = Mapeador.CrearMapper().Map<CursoEditDto, Curso>(cursoDto);
                    //Curso curso = null;
                    if (curso!=null)
                    {
                        curso.Vacantes--;
                        _repositorioCursos.Guardar(curso);
                        _unitOfWork.SaveChanges();
                        inscripcionEditDto.InscripcionId = inscripcion.InscripcionId;
                        scope.Complete();
                        
                    }
                    else
                    {
                        throw new Exception("Joder algo anduvo mal");
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void Borrar(int inscripcionId)
        {
            var inscripcion = _repositorio.GetInscripcionPorId(inscripcionId);
            using (var scope = new TransactionScope(TransactionScopeOption.Required))
            {

                _repositorio.Borrar(inscripcionId);
                var cursoDto = _repositorioCursos.GetCursoPorId(inscripcion.CursoListDto.CursoId);
                var curso = Mapeador.CrearMapper().Map<CursoEditDto, Curso>(cursoDto);
                curso.Vacantes++;
                _repositorioCursos.Guardar(curso);
                _unitOfWork.SaveChanges();
                scope.Complete();
            }
        }
    }
}
