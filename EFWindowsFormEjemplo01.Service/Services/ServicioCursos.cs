using System.Collections.Generic;
using EFWindowsFormEjemplo01.Context.Repositories;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Service.Services.Facades;

namespace EFWindowsFormEjemplo01.Service.Services
{
    public class ServicioCursos:IServicioCurso
    {
        private readonly IRepositorioCurso _repositorio;

        public ServicioCursos()
        {
            _repositorio=new RepositorioCursos();
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
            throw new System.NotImplementedException();
        }

        public void Guardar(CursoEditDto curso)
        {
            throw new System.NotImplementedException();
        }

        public void Borrar(int id)
        {
            _repositorio.Borrar(id);
        }

        public bool Existe(CursoEditDto curso)
        {
            throw new System.NotImplementedException();
        }

        public bool EstaRelacionado(CursoEditDto curso)
        {
            return _repositorio.EstaRelacionado(curso);
        }
    }
}
