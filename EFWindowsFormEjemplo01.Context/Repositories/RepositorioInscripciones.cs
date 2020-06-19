using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;
using EFWindowsFormEjemplo01.Entities.Entities;
using EFWindowsFormEjemplo01.Entities.Maps;

namespace EFWindowsFormEjemplo01.Context.Repositories
{
    public class RepositorioInscripciones:IRepositorioInscripcion
    {
        private readonly CursosDbContext _dbContext;

        public RepositorioInscripciones()
        {
            _dbContext = new CursosDbContext();
        }
        public List<InscripcionListDto> GetInscripciones()
        {
            try
            {
                var lista = _dbContext.Inscripciones
            .Include(i => i.Curso)
            .Include(i => i.Alumno).ToList();
                return Mapeador.CrearMapper()
                    .Map<List<Inscripcion>, List<InscripcionListDto>>(lista);

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
                                                     && i.InscripcionId!=inscripcionDto.InscripcionId);
        }

        public void Guardar(InscripcionEditDto inscripcionEditDto)
        {
            var inscripcion = Mapeador.CrearMapper().Map<InscripcionEditDto, Inscripcion>(inscripcionEditDto);
            using (var transancion = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    _dbContext.Inscripciones.Add(inscripcion);

                    var curso = _dbContext.Cursos.SingleOrDefault(c => c.CursoId == inscripcion.CursoId);
                    if (curso != null)
                    {
                        curso.Vacantes--;
                        _dbContext.Entry(curso).State = EntityState.Modified;
                    }

                    _dbContext.SaveChanges();
                    transancion.Commit();

                }
                catch (Exception ex)
                {
                    transancion.Rollback();
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
