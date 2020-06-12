using System;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.DTOs.Profesor;
using EFWindowsFormEjemplo01.Entities.Entities.Emun;
using EFWindowsFormEjemplo01.Entities.ViewModels.Curso;
using EFWindowsFormEjemplo01.Service.Services;
using EFWindowsFormEjemplo01.Service.Services.Facades;

namespace EFWindowsFormEjemplo01.Windows
{
    public partial class FrmCursoAE : MetroFramework.Forms.MetroForm
    {
        public FrmCursoAE()
        {
            InitializeComponent();
        }

        private CursoEditVm cursoVm;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            IServicioProfesor servicioProfesor=new ServicioProfesores();
            var listaProfesores = servicioProfesor.GetProfesores();
            ProfesorListDto profesorDto = new ProfesorListDto
            {
                ProfesorId = 0,
                NombreCompleto = "<Seleccione un Profesor>"
            };
            listaProfesores.Insert(0,profesorDto);
            profesorMetroComboBox.DataSource = listaProfesores;
            profesorMetroComboBox.DisplayMember = "NombreCompleto";
            profesorMetroComboBox.ValueMember = "ProfesorId";
            profesorMetroComboBox.SelectedIndex = 0;
        }

        private void CancelarMetroButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GuardarMetroButton_Click(object sender, EventArgs e)
        {
            if (cursoVm==null)
            {
                cursoVm=new CursoEditVm();
            }

            cursoVm.Nombre = NombreMetroTextBox.Text;
            cursoVm.Descripcion = DescripcionMetroTextBox.Text;
            cursoVm.Nivel = principianteMetroRadioButton.Checked ? Nivel.Principiante :
                medioMetroRadioButton.Checked ? Nivel.Medio : Nivel.Avanzado;
            cursoVm.ProfesorId =(int) profesorMetroComboBox.SelectedValue;
            if (int.TryParse(vacantesMetroTextBox.Text, out int vacantes))
            {
                cursoVm.Vacantes = vacantes;
            }

            if (decimal.TryParse(precioMetroTextBox.Text,out decimal precio))
            {
                cursoVm.PrecioTotal = precio;
            }
            bool valido = new Helpers.DataValidator(cursoVm).Validate();
            if (valido)
            {
                //TODO:Ver si el curso esta repetido
                //AlumnoEditDto alumnoEditDto = Mapeador.CrearMapper().Map<AlumnoEditDto>(alumnoEditVm);
                //if (!servicio.Existe(alumnoEditDto))
                //{
                //    DialogResult = DialogResult.OK;

                //}
                //else
                //{
                //    MetroMessageBox.Show(this, "Alumno repetido", "Error", MessageBoxButtons.OK,
                //        MessageBoxIcon.Error);
                //}
            }
            else
            {
                NombreMetroTextBox.Focus();
            }

        }
    }
}
