using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;
using EFWindowsFormEjemplo01.Entities.Entities;
using EFWindowsFormEjemplo01.Entities.Maps;

namespace EFWindowsFormEjemplo01.Context.Repositories
{
    public class RepositorioInscripciones : IRepositorioInscripcion
    {
        private readonly CursosDbContext _dbContext;

        public RepositorioInscripciones(CursosDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //public RepositorioInscripciones()
        //{
        //    _dbContext = new CursosDbContext();
        //}
        public List<InscripcionListDto> GetInscripciones(CursoListDto curso=null)
        {
            try
            {
                IQueryable<Inscripcion> query= _dbContext.Inscripciones
                    .Include(i => i.Curso)
                    .Include(i => i.Alumno);
                if (curso!=null)
                {
                    query = query.Where(i => i.CursoId == curso.CursoId);
                }
                return Mapeador.CrearMapper()
                    .Map<List<Inscripcion>, List<InscripcionListDto>>(query.ToList());

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public bool Existe(InscripcionEditDto inscripcionDto)
        {
            if (inscripcionDto.InscripcionId == 0)
            {
                return _dbContext.Inscripciones.Any(i => i.CursoId == inscripcionDto.CursoListDto.CursoId &&
                                                         i.AlumnoId == inscripcionDto.AlumnoListDto.AlumnoId);
            }
            return _dbContext.Inscripciones.Any(i => i.CursoId == inscripcionDto.CursoListDto.CursoId &&
                                                     i.AlumnoId == inscripcionDto.AlumnoListDto.AlumnoId
                                                     && i.InscripcionId != inscripcionDto.InscripcionId);
        }

        public void Guardar(Inscripcion inscripcion)
        {
            _dbContext.Inscripciones.Add(inscripcion);
        }

        public void Borrar(int inscripcionId)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var inscripcionInDb = _dbContext
                        .Inscripciones
                        .SingleOrDefault(i => i.InscripcionId == inscripcionId);
                    if (inscripcionInDb != null)
                    {
                        _dbContext.Entry(inscripcionInDb).State = EntityState.Deleted;
                        var cursoInDb = _dbContext.Cursos
                            .SingleOrDefault(c => c.CursoId == inscripcionInDb.CursoId);
                        if (cursoInDb != null)
                        {
                            cursoInDb.Vacantes++;
                            _dbContext.Entry(cursoInDb).State = EntityState.Modified;
                            _dbContext.SaveChanges();
                        }
                        transaction.Commit();
                    }

                }
                catch (Exception ex)
                {

                    transaction.Rollback();
                    throw new Exception(ex.Message);
                }

            }
        }

        public InscripcionEditDto GetInscripcionPorId(int id)
        {
            var inscripcion= _dbContext.Inscripciones.SingleOrDefault(i => i.InscripcionId == id);
            return Mapeador.CrearMapper().Map<Inscripcion,InscripcionEditDto>(inscripcion);
        }
    }
}
