using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;

namespace EFWindowsFormEjemplo01.Windows.Helpers
{
    public class DataValidator
    {
        private ValidationContext _context;//Que objeto voy a validar
        private List<ValidationResult> results;//lista de los errores
        private bool valido;//es para chequear si el objeto es válido o no
        private StringBuilder mensaje;// ver un mensaje con los errores

        public DataValidator(object instancia)
        {
            _context=new ValidationContext(instancia);
            results=new List<ValidationResult>();
            valido = Validator.TryValidateObject(instancia, _context, results, true);
        }

        public bool Validate()
        {
            if (!valido)
            {
                mensaje=new StringBuilder();
                foreach (var validationResult in results)
                {
                    mensaje.AppendLine(validationResult.ToString());
                }

                MessageBox.Show(mensaje.ToString(), "Errores",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            return valido;
        }
    }
}
