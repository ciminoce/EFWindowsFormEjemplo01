using System.Collections.Generic;
using EFWindowsFormEjemplo01.Context;
using EFWindowsFormEjemplo01.Context.Repositories;
using EFWindowsFormEjemplo01.Context.Repositories.Facades;
using EFWindowsFormEjemplo01.Entities.DTOs.Profesor;
using EFWindowsFormEjemplo01.Entities.Entities;
using EFWindowsFormEjemplo01.Entities.Maps;
using EFWindowsFormEjemplo01.Service.Services.Facades;

namespace EFWindowsFormEjemplo01.Service.Services
{
    public class ServicioProfesores:IServicioProfesor
    {
        private readonly IRepositorioProfesor _repositorio;
        private readonly IUnitOfWork _unitOfWork;
        public ServicioProfesores()
        {
            var dbContext=new CursosDbContext();
            _repositorio = new RepositorioProfesores(dbContext);
            _unitOfWork=new UnitofWork(dbContext);
        }
        public List<ProfesorListDto> GetProfesores()
        {
            return _repositorio.GetProfesores();
        }


        public ProfesorEditDto GetProfesorPorId(int id)
        {
            var profesor = _repositorio.GetProfesorPorId(id);
            var profesorEditDto = Mapeador.CrearMapper().Map<ProfesorEditDto>(profesor);
            return profesorEditDto;
        }

        public void Guardar(ProfesorEditDto profesorEditDto)
        {
            var profesor = Mapeador.CrearMapper().Map<ProfesorEditDto, Profesor>(profesorEditDto);
            _repositorio.Guardar(profesor);
            _unitOfWork.SaveChanges();
            profesorEditDto.ProfesorId = profesor.ProfesorId;
        }

        public void Borrar(int id)
        {
            _repositorio.Borrar(id);
        }

        public bool Existe(ProfesorEditDto profesorEditDto)
        {
            //Profesor profesor = Mapeador.CrearMapper().Map<Profesor>(profesorEditDto);
            return _repositorio.Existe(profesorEditDto);
        }

        public bool EstaRelacionado(ProfesorListDto alumnoListDto)
        {
            //Profesor alumno = Mapeador.CrearMapper().Map<Profesor>(alumnoListDto);
            //return _repositorio.EstaRelacionado(alumnoListDto);
            return false;
        }

    }
}
