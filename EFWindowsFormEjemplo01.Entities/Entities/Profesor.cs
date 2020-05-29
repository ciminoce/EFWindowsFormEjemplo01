using System.Collections.Generic;
using System.Security.AccessControl;

namespace EFWindowsFormEjemplo01.Entities.Entities
{
    public class Profesor
    {
        public int ProfesorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }=new HashSet<Curso>();
    }
}
