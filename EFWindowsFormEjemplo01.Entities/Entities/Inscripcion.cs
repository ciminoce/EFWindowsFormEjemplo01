using System;

namespace EFWindowsFormEjemplo01.Entities.Entities
{
    public class Inscripcion
    {
        public int InscripcionId { get; set; }
        public int CursoId { get; set; }
        public int AlumnoId { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual  Alumno Alumno { get; set; }
    }
}
