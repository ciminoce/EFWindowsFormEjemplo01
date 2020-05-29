using System.Collections.Generic;
using EFWindowsFormEjemplo01.Entities.Entities.Emun;

namespace EFWindowsFormEjemplo01.Entities.Entities
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioTotal { get; set; }
        public Nivel Nivel { get; set; }
        public int Vacantes { get; set; }
        public int ProfesorId { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual ICollection<Inscripcion> Inscripciones { get; set; }=new HashSet<Inscripcion>();

    }
}
