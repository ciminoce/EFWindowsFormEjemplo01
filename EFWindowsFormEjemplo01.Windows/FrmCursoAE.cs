using System;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.DTOs.Profesor;
using EFWindowsFormEjemplo01.Entities.Entities.Emun;
using EFWindowsFormEjemplo01.Service.Services;
using EFWindowsFormEjemplo01.Service.Services.Facades;
using EFWindowsFormEjemplo01.Windows.Helpers;
using MetroFramework;

namespace EFWindowsFormEjemplo01.Windows
{
    public partial class FrmCursoAE : MetroFramework.Forms.MetroForm
    {
        public FrmCursoAE()
        {
            InitializeComponent();
        }

        private IServicioCurso servicio= new ServicioCursos();
        private CursoEditDto cursoDto;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Helper.CargarDatosComboProfesores(ref profesorMetroComboBox);
            if (cursoDto!=null)
            {
                NombreMetroTextBox.Text = cursoDto.Nombre;
                DescripcionMetroTextBox.Text = cursoDto.Descripcion;
                vacantesMetroTextBox.Text = cursoDto.Vacantes.ToString();
                precioMetroTextBox.Text = cursoDto.PrecioTotal.ToString();
                switch (cursoDto.Nivel)
                {
                    case Nivel.Principiante:
                        principianteMetroRadioButton.Checked = true;
                        break;
                    case Nivel.Medio:
                        medioMetroRadioButton.Checked = true;
                        break;
                    case Nivel.Avanzado:
                        avanzadoMetroRadioButton.Checked = true;
                        break;
                }

                profesorMetroComboBox.SelectedValue = cursoDto.ProfesorListDto.ProfesorId;
            }
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
                cursoDto.ProfesorListDto = (ProfesorListDto)profesorMetroComboBox.SelectedItem;
                cursoDto.Vacantes = int.Parse(vacantesMetroTextBox.Text);
                cursoDto.PrecioTotal = decimal.Parse(precioMetroTextBox.Text);
                if (!servicio.Existe(cursoDto))
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MetroMessageBox.Show(this, "Curso repetido", "Error", MessageBoxButtons.OK,
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

        public CursoEditDto GetCurso()
        {
            return cursoDto;
        }

        public void SetCurso(CursoEditDto cursoEdit)
        {
            cursoDto = cursoEdit;
        }
    }
}
