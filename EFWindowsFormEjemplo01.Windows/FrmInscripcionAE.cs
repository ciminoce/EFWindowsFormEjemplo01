using System;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;
using EFWindowsFormEjemplo01.Service.Services;
using EFWindowsFormEjemplo01.Service.Services.Facades;
using EFWindowsFormEjemplo01.Windows.Helpers;
using MetroFramework;

namespace EFWindowsFormEjemplo01.Windows
{
    public partial class FrmInscripcionAE : MetroFramework.Forms.MetroForm
    {
        public FrmInscripcionAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarDatosComboCursos(ref cursoMetroComboBox);
            Helper.CargarDatosComboAlumnos(ref alumnoMetroComboBox);

        }

        private void CancelarMetroButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private InscripcionEditDto inscripcionDto;
        private IServicioInscripcion servicio=new ServicioInscripciones();
        private void GuardarMetroButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (inscripcionDto==null)
                {
                    inscripcionDto=new InscripcionEditDto();
                }

                inscripcionDto.CursoListDto = (CursoListDto) cursoMetroComboBox.SelectedItem;
                inscripcionDto.AlumnoListDto = (AlumnoListDto) alumnoMetroComboBox.SelectedItem;
                inscripcionDto.FechaInscripcion = fechaTimePicker.Value;
                if (!servicio.Existe(inscripcionDto))
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MetroMessageBox.Show(this, "Registro repetido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (alumnoMetroComboBox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(alumnoMetroComboBox,"Debe seleccionar un alumno");
            }

            if (cursoMetroComboBox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(cursoMetroComboBox,"Debe seleccionar un curso");

            }

            if (fechaTimePicker.Value.Date>DateTime.Now.Date)
            {
                valido = false;
                errorProvider1.SetError(fechaTimePicker,"Fecha no válida");
            }

            return valido;
        }

        public InscripcionEditDto GetInscripcion()
        {
            return inscripcionDto;
        }
    }
}
