using System;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;

namespace EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion
{
    public class InscripcionListDto
    {
        public int InscripcionId { get; set; }
        public CursoListDto CursoListDto { get; set; }
        public AlumnoListDto AlumnoListDto { get; set; }
        public DateTime FechaInscripcion { get; set; }
    }
}
