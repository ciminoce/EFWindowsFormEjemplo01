using System;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Profesor;
using EFWindowsFormEjemplo01.Entities.Maps;
using EFWindowsFormEjemplo01.Entities.ViewModels.Profesor;
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
        private ProfesorEditVm profesorEditVm;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (profesorEditVm != null)
            {
                NombreMetroTextBox.Text = profesorEditVm.Nombre;
                ApellidoMetroTextBox.Text = profesorEditVm.Apellido;
            }
        }

        public void SetProfesor(ProfesorEditVm profesorEditVm)
        {
            this.profesorEditVm = profesorEditVm;
        }

        private void GuardarMetroButton_Click(object sender, EventArgs e)
        {
            if (profesorEditVm == null)
            {
                profesorEditVm = new ProfesorEditVm();
            }

            profesorEditVm.Nombre = NombreMetroTextBox.Text;
            profesorEditVm.Apellido = ApellidoMetroTextBox.Text;
            bool valido = new Helpers.DataValidator(profesorEditVm).Validate();
            if (valido)
            {
                ProfesorEditDto profesorEditDto = Mapeador.CrearMapper().Map<ProfesorEditDto>(profesorEditVm);
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
            else
            {
                NombreMetroTextBox.Focus();
            }
        }


        public ProfesorEditVm GetProfesor()
        {
            return profesorEditVm;
        }

    }
}
