using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.Entities;
using EFWindowsFormEjemplo01.Entities.Maps;

namespace EFWindowsFormEjemplo01.Context.Repositories
{
    public class RepositorioCursos:IRepositorioCurso
    {
        private readonly CursosDbContext _dbContext;

        public RepositorioCursos()
        {
            _dbContext=new CursosDbContext();
        }
        public List<CursoListDto> GetCursos()
        {
            //var listaCursos = _dbContext.Cursos.Include(c => c.Profesor).ToList();
            //var listaListDto = Mapeador.CrearMapper().Map<List<Curso>, List<CursoListDto>>(listaCursos);
            //return listaListDto;
            return  _dbContext.Cursos
                .Select(c => new CursoListDto
                {
                    CursoId = c.CursoId,
                    Nombre = c.Nombre,
                    PrecioTotal = c.PrecioTotal,
                    Vacantes = c.Vacantes,
                }).ToList();
        }

        public CursoMasInfoDto GetMasDatos(int id)
        {
            var curso = _dbContext.Cursos
                .Include(c => c.Profesor)
                .SingleOrDefault(c => c.CursoId == id);
            return Mapeador.CrearMapper().Map<Curso, CursoMasInfoDto>(curso);

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
            var cursoInDb = _dbContext.Cursos.SingleOrDefault(c => c.CursoId == id);
            if (cursoInDb!=null)
            {
                _dbContext.Entry(cursoInDb).State = EntityState.Deleted;
                _dbContext.SaveChanges();
            }
        }

        public bool Existe(CursoEditDto curso)
        {
            throw new System.NotImplementedException();
        }

        public bool EstaRelacionado(CursoEditDto curso)
        {
            return false;
        }
    }
}
