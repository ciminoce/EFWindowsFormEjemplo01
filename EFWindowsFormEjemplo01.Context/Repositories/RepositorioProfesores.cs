using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Entities.DTOs.Profesor;
using EFWindowsFormEjemplo01.Entities.Entities;
using EFWindowsFormEjemplo01.Entities.Maps;

namespace EFWindowsFormEjemplo01.Context.Repositories
{
    public class RepositorioProfesores:IRepositorioProfesor
    {
        private readonly CursosDbContext _dbContext;

        public RepositorioProfesores()
        {
            _dbContext = new CursosDbContext();
        }

        public List<ProfesorListDto> GetProfesores()
        {
            var listaProfesores = _dbContext.Profesores
                .OrderBy(p=>p.Apellido)
                .ThenBy(p=>p.Nombre)
                .ToList();
            var listaDto = Mapeador.CrearMapper().Map<List<Profesor>, List<ProfesorListDto>>(listaProfesores);
            return listaDto;
        }

        public ProfesorEditDto GetProfesorPorId(int id)
        {
            var profesor= _dbContext.Profesores.SingleOrDefault(a => a.ProfesorId == id);
            return Mapeador.CrearMapper().Map<Profesor, ProfesorEditDto>(profesor);

        }

        public void Guardar(ProfesorEditDto profesorDto)
        {
            var profesor = Mapeador.CrearMapper().Map<ProfesorEditDto, Profesor>(profesorDto);
            if (profesor.ProfesorId == 0)
            {
                _dbContext.Profesores.Add(profesor);
            }
            else
            {
                var profesorInDb = _dbContext.Profesores.SingleOrDefault(p=>p.ProfesorId==profesor.ProfesorId);
                if (profesorInDb != null)
                {
                    profesorInDb.Nombre = profesor.Nombre;
                    profesorInDb.Apellido = profesor.Apellido;
                    _dbContext.Entry(profesorInDb).State = EntityState.Modified;
                }
            }

            _dbContext.SaveChanges();
            profesorDto.ProfesorId = profesor.ProfesorId;
        }

        public void Borrar(int id)
        {
            var profesorInBd = _dbContext.Profesores.SingleOrDefault(a => a.ProfesorId == id);
            if (profesorInBd != null)
            {
                _dbContext.Entry(profesorInBd).State = EntityState.Deleted;
                _dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("Profesor inexistente");
            }
        }

        public bool Existe(ProfesorEditDto profesor)
        {
            if (profesor.ProfesorId > 0)
            {
                //fue editado
                return _dbContext.Profesores.Any(a =>
                    a.Nombre == profesor.Nombre && a.Apellido == profesor.Apellido
                                              && a.ProfesorId != profesor.ProfesorId);
            }
            //fue agregado
            return _dbContext.Profesores.Any(a => a.Nombre == profesor.Nombre
                                               && a.Apellido == profesor.Apellido);
        }

        public bool EstaRelacionado(Profesor profesor)
        {
            //TODO:Desarrollar cuando se haya hecho la parte de inscripciones
            return false;
        }
    }
}
