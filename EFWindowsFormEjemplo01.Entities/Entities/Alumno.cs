using System.Collections.Generic;

namespace EFWindowsFormEjemplo01.Entities.Entities
{
    public class Alumno
    {
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public virtual ICollection<Inscripcion> Inscripciones { get; set; }=new HashSet<Inscripcion>();
    }
}
