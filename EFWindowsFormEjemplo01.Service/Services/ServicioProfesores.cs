using System.Collections.Generic;
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

        public ServicioProfesores()
        {
            _repositorio = new RepositorioProfesores();
        }
        public List<ProfesorListDto> GetProfesores()
        {
            return _repositorio.GetProfesores();
        }


        public ProfesorEditDto GetProfesorPorId(int id)
        {
            var alumno = _repositorio.GetProfesorPorId(id);
            var alumnoEditDto = Mapeador.CrearMapper().Map<ProfesorEditDto>(alumno);
            return alumnoEditDto;
        }

        public void Guardar(ProfesorEditDto profesorEditDto)
        {
            //var profesor = Mapeador.CrearMapper().Map<Profesor>(profesorEditDto);
            _repositorio.Guardar(profesorEditDto);
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
