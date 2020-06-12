using System.ComponentModel.DataAnnotations;
using EFWindowsFormEjemplo01.Entities.Entities.Emun;

namespace EFWindowsFormEjemplo01.Entities.ViewModels.Curso
{
    public class CursoEditVm
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(120, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres", MinimumLength = 3)]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El campo {0} debe contener únicamente caracteres alfabéticos")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(200, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres", MinimumLength = 3)]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El campo {0} debe contener únicamente caracteres alfabéticos")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} debe contener un valor mayor a cero")]
        [RegularExpression("(^[0-9]{1,5}$|^[0-9]{1,5}\\,[0-9]{2}$)", ErrorMessage = "El campo {0} debe contener un número")]
        public decimal PrecioTotal { get; set; }

        [Required]
        public Nivel Nivel { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [RegularExpression("^[0-9]{2}$", ErrorMessage = "El campo {0} debe contener solo números")]
        [Range(10, 20, ErrorMessage = "El campo {0} debe contener números entre 10 y 20")]
        public int Vacantes { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un profesor")]
        public int ProfesorId { get; set; }

    }
}
