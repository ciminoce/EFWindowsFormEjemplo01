using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.Entities;

namespace EFWindowsFormEjemplo01.Context.Repositories.Facades
{
    public interface IRepositorioCurso
    {
        List<CursoListDto> GetCursos();

        CursoMasInfoDto GetMasDatos(int id);
        CursoEditDto GetCursoPorId(int id);
        void Guardar(Curso curso);
        void Borrar(int id);
        bool Existe(CursoEditDto curso);
        bool EstaRelacionado(CursoListDto curso);

    }
}
