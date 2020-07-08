using System;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Service.Services.Facades;
using MetroFramework;

namespace EFWindowsFormEjemplo01.Windows
{
    public partial class FrmAlumnoAE : MetroFramework.Forms.MetroForm
    {
        public FrmAlumnoAE(IServicioAlumno servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private void CancelarMetroButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        //private ServicioAlumnos servicio = new ServicioAlumnos();
        private IServicioAlumno servicio;

        private AlumnoEditDto alumnoEditDto;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (alumnoEditDto != null)
            {
                NombreMetroTextBox.Text = alumnoEditDto.Nombre;
                ApellidoMetroTextBox.Text = alumnoEditDto.Apellido;
            }
        }

        public void SetAlumno(AlumnoEditDto alumnoEditVm)
        {
            this.alumnoEditDto = alumnoEditVm;
        }

        private void GuardarMetroButton_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                if (alumnoEditDto == null)
                {
                    alumnoEditDto = new AlumnoEditDto();
                }

                alumnoEditDto.Nombre = NombreMetroTextBox.Text;
                alumnoEditDto.Apellido = ApellidoMetroTextBox.Text;
                if (!servicio.Existe(alumnoEditDto))
                {
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    MetroMessageBox.Show(this, "Alumno repetido", "Error", MessageBoxButtons.OK,
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


        public AlumnoEditDto GetAlumno()
        {
            return alumnoEditDto;
        }
    }
}
