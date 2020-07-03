using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;

namespace EFWindowsFormEjemplo01.Service.Services.Facades
{
    public interface IServicioCurso
    {
        List<CursoListDto> GetCursos();
        CursoMasInfoDto GetMasDatos(int id);
        CursoEditDto GetCursoPorId(int id);
        void Guardar(CursoEditDto curso);
        void Borrar(int id);
        bool Existe(CursoEditDto curso);
        bool EstaRelacionado(CursoListDto curso);

    }
}
