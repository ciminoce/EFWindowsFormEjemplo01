using System;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Profesor;
using EFWindowsFormEjemplo01.Service.Services;
using MetroFramework;

namespace EFWindowsFormEjemplo01.Windows
{
    public partial class FrmProfesorAE : MetroFramework.Forms.MetroForm
    {
        public FrmProfesorAE()
        {
            InitializeComponent();
        }
        private void CancelarMetroButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private ServicioProfesores servicio = new ServicioProfesores();
        private ProfesorEditDto profesorEditDto;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (profesorEditDto != null)
            {
                NombreMetroTextBox.Text = profesorEditDto.Nombre;
                ApellidoMetroTextBox.Text = profesorEditDto.Apellido;
            }
        }

        public void SetProfesor(ProfesorEditDto profesorEditDto)
        {
            this.profesorEditDto = profesorEditDto;
        }

        private void GuardarMetroButton_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                if (profesorEditDto == null)
                {
                    profesorEditDto = new ProfesorEditDto();
                }

                profesorEditDto.Nombre = NombreMetroTextBox.Text;
                profesorEditDto.Apellido = ApellidoMetroTextBox.Text;
                if (!servicio.Existe(profesorEditDto))
                {
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    MetroMessageBox.Show(this, "Profesor repetido", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }

        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(NombreMetroTextBox.Text.Trim())
                && string.IsNullOrWhiteSpace(NombreMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(NombreMetroTextBox, "El nombre es requerido");
            }
            if (string.IsNullOrEmpty(ApellidoMetroTextBox.Text.Trim())
                && string.IsNullOrWhiteSpace(ApellidoMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(ApellidoMetroTextBox, "El apellido es requerido");
            }

            return valido;
        }


        public ProfesorEditDto GetProfesor()
        {
            return profesorEditDto;
        }

    }
}
