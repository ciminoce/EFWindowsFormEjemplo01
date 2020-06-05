using System;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.ViewModels.Alumno;

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

        private AlumnoEditVm alumnoEditVm;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (alumnoEditVm!=null)
            {
                NombreMetroTextBox.Text = alumnoEditVm.Nombre;
                ApellidoMetroTextBox.Text = alumnoEditVm.Apellido;
            }
        }

        public void SetAlumno(AlumnoEditVm alumnoEditVm)
        {
            this.alumnoEditVm = alumnoEditVm;
        }

        private void GuardarMetroButton_Click(object sender, EventArgs e)
        {
            if (alumnoEditVm==null)
            {
                alumnoEditVm=new AlumnoEditVm();
            }

            alumnoEditVm.Nombre = NombreMetroTextBox.Text;
            alumnoEditVm.Apellido = ApellidoMetroTextBox.Text;
            bool valido=new Helpers.DataValidator(alumnoEditVm).Validate();
            if (valido)
            {
                DialogResult = DialogResult.OK;
            }
        }


        public AlumnoEditVm GetAlumno()
        {
            return alumnoEditVm;
        }
    }
}
