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

        public RepositorioCursos(CursosDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //public RepositorioCursos()
        //{
        //    _dbContext=new CursosDbContext();
        //}
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
            var curso = _dbContext.Cursos.Include(c => c.Profesor).SingleOrDefault(c => c.CursoId == id);
            return Mapeador.CrearMapper().Map<Curso, CursoEditDto>(curso);
        }

        public void Guardar(Curso curso)
        {
            if (curso.CursoId==0)
            {
                _dbContext.Cursos.Add(curso);
            }
            else
            {
                var cursoInDb = _dbContext.Cursos.SingleOrDefault(c => c.CursoId == curso.CursoId);
                if (cursoInDb != null)
                {
                    cursoInDb.Nombre = curso.Nombre;
                    cursoInDb.Descripcion = curso.Descripcion;
                    cursoInDb.Vacantes = curso.Vacantes;
                    cursoInDb.PrecioTotal = curso.PrecioTotal;
                    cursoInDb.ProfesorId = curso.ProfesorId;
                    cursoInDb.Nivel = curso.Nivel;
                    _dbContext.Entry(cursoInDb).State = EntityState.Modified;
                }
            }

            //_dbContext.SaveChanges();
        }

        public void Borrar(int id)
        {
            var cursoInDb = _dbContext.Cursos.SingleOrDefault(c => c.CursoId == id);
            if (cursoInDb!=null)
            {
                _dbContext.Entry(cursoInDb).State = EntityState.Deleted;
                //_dbContext.SaveChanges();
            }
        }

        public bool Existe(CursoEditDto curso)
        {
            if (curso.CursoId==0)
            {
                return _dbContext.Cursos.Any(c => c.Nombre == curso.Nombre);
            }

            return _dbContext.Cursos.Any(c => c.Nombre == curso.Nombre && c.CursoId != curso.CursoId);
        }

        public bool EstaRelacionado(CursoListDto curso)
        {
            return _dbContext.Inscripciones.Any(i=>i.CursoId==curso.CursoId);
        }
    }
}
