using System;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.DTOs.Profesor;
using EFWindowsFormEjemplo01.Entities.Entities.Emun;
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

        private CursoEditDto cursoDto;
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
            if (ValidarDatos())
            {
                if (cursoDto == null)
                {
                    cursoDto = new CursoEditDto();
                }

                cursoDto.Nombre = NombreMetroTextBox.Text;
                cursoDto.Descripcion = DescripcionMetroTextBox.Text;
                cursoDto.Nivel = principianteMetroRadioButton.Checked ? Nivel.Principiante :
                    medioMetroRadioButton.Checked ? Nivel.Medio : Nivel.Avanzado;
                cursoDto.ProfesorId = (int)profesorMetroComboBox.SelectedValue;
                cursoDto.Vacantes = int.Parse(vacantesMetroTextBox.Text);
                cursoDto.PrecioTotal = decimal.Parse(precioMetroTextBox.Text);
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
            if (string.IsNullOrEmpty(DescripcionMetroTextBox.Text.Trim())
                && string.IsNullOrWhiteSpace(DescripcionMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(DescripcionMetroTextBox, "L descripción es requerida");
            }

            if (profesorMetroComboBox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(profesorMetroComboBox,"Debe seleccionar un profesor");
            }

            if (!decimal.TryParse(precioMetroTextBox.Text,out decimal precio))
            {
                valido = false;
                errorProvider1.SetError(precioMetroTextBox,"Costo del curso mal ingresado");
            }else if (precio<=0 || precio>decimal.MaxValue)
            {
                valido = false;
                errorProvider1.SetError(precioMetroTextBox, "Costo del curso mal fuera del rango permitido");

            }
            if (!int.TryParse(vacantesMetroTextBox.Text, out int vacantes))
            {
                valido = false;
                errorProvider1.SetError(vacantesMetroTextBox, "Vacantes mal ingresado");
            }
            else if (vacantes <= 0 || vacantes > 20)
            {
                valido = false;
                errorProvider1.SetError(vacantesMetroTextBox, "Vacantes fuera del rango permitido");

            }

            return valido;

        }
    }
}
