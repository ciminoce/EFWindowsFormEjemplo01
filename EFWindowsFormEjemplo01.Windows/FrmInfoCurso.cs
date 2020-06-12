using System;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;

namespace EFWindowsFormEjemplo01.Windows
{
    public partial class FrmInfoCurso : MetroFramework.Forms.MetroForm
    {
        public FrmInfoCurso()
        {
            InitializeComponent();
        }

        private void CerrarMetroButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private CursoMasInfoDto cursoDto;
        public void SetCurso(CursoMasInfoDto cursoMasInfoDto)
        {
            cursoDto = cursoMasInfoDto;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (cursoDto!=null)
            {
                NombreMetroTextBox.Text = cursoDto.Nombre;
                DescripcionMetroTextBox.Text = cursoDto.Descripcion;
                precioMetroTextBox.Text = cursoDto.PrecioTotal.ToString("C");
                vacantesMetroTextBox.Text = cursoDto.Vacantes.ToString();
                nivelMetroTextBox.Text = cursoDto.Nivel;
                profesorMetroTextBox.Text = cursoDto.Profesor;

            }
        }
    }
}
