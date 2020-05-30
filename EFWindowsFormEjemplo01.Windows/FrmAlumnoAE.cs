using System;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;

namespace EFWindowsFormEjemplo01.Windows
{
    public partial class FrmAlumnoAE : MetroFramework.Forms.MetroForm
    {
        public FrmAlumnoAE()
        {
            InitializeComponent();
        }
        
        private void CancelarMetroButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private AlumnoEditDto alumnoEditDto;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (alumnoEditDto!=null)
            {
                NombreMetroTextBox.Text = alumnoEditDto.Nombre;
                ApellidoMetroTextBox.Text = alumnoEditDto.Apellido;
            }
        }

        public void SetAlumno(AlumnoEditDto alumnoEditDto)
        {
            this.alumnoEditDto = alumnoEditDto;
        }

        private void GuardarMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (alumnoEditDto==null)
                {
                    alumnoEditDto=new AlumnoEditDto();
                }

                alumnoEditDto.Nombre = NombreMetroTextBox.Text;
                alumnoEditDto.Apellido = ApellidoMetroTextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            return true;
        }

        public AlumnoEditDto GetAlumno()
        {
            return alumnoEditDto;
        }
    }
}
