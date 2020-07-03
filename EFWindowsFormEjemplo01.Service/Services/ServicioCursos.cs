using System.Collections.Generic;
using EFWindowsFormEjemplo01.Context;
using EFWindowsFormEjemplo01.Context.Repositories;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.Entities;
using EFWindowsFormEjemplo01.Entities.Maps;
using EFWindowsFormEjemplo01.Service.Services.Facades;

namespace EFWindowsFormEjemplo01.Service.Services
{
    public class ServicioCursos:IServicioCurso
    {
        private readonly IRepositorioCurso _repositorio;
        private readonly IUnitOfWork _unitOfWork;
        public ServicioCursos()
        {
            var dbContext=new CursosDbContext();
            _repositorio=new RepositorioCursos(dbContext);
            _unitOfWork=new UnitofWork(dbContext);
        }
        public List<CursoListDto> GetCursos()
        {
            return _repositorio.GetCursos();
        }

        public CursoMasInfoDto GetMasDatos(int id)
        {
            return _repositorio.GetMasDatos(id);
        }

        public CursoEditDto GetCursoPorId(int id)
        {
            return _repositorio.GetCursoPorId(id);
        }

        public void Guardar(CursoEditDto cursoDto)
        {
            var curso = Mapeador.CrearMapper().Map<CursoEditDto, Curso>(cursoDto);

            _repositorio.Guardar(curso);
            _unitOfWork.SaveChanges();
            cursoDto.CursoId = curso.CursoId;
        }

        public void Borrar(int id)
        {
            _repositorio.Borrar(id);
            _unitOfWork.SaveChanges();
        }

        public bool Existe(CursoEditDto curso)
        {
            return _repositorio.Existe(curso);
        }


        public bool EstaRelacionado(CursoListDto curso)
        {
            return _repositorio.EstaRelacionado(curso);
        }
    }
}
