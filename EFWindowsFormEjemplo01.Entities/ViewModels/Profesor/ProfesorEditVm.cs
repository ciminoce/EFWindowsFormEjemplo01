using System.ComponentModel.DataAnnotations;

namespace EFWindowsFormEjemplo01.Entities.ViewModels.Profesor
{
    public class ProfesorEditVm
    {
        public int ProfesorId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres", MinimumLength = 3)]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El campo {0} debe contener únicamente caracteres alfabéticos")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracteres", MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El campo {0} debe contener únicamente caracteres alfabéticos")]
        public string Apellido { get; set; }

    }
}
