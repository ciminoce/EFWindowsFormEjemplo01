using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.Entities;
using EFWindowsFormEjemplo01.Service.Services;
using EFWindowsFormEjemplo01.Service.Services.Facades;

namespace EFWindowsFormEjemplo01.Windows
{
    public partial class FrmAlumnos : Form
    {
        private static FrmAlumnos _instancia = null;

        public static FrmAlumnos GetInstancia()
        {
            if (_instancia==null)
            {
                _instancia=new FrmAlumnos();
                _instancia.FormClosed += form_Close;
            }

            return _instancia;
        }

        private static void form_Close(object sender, FormClosedEventArgs e)
        {
            _instancia = null;
        }

        private FrmAlumnos()
        {
            InitializeComponent();
        }

        private IServicioAlumno servicio;
        private List<AlumnoListDto> lista;
        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            servicio=new ServicioAlumnos();
            this.Dock = DockStyle.Fill;
            try
            {
                lista = servicio.GetAlumnos();
                MostrarDatosEnGrilla();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var alumnoDto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, alumnoDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, AlumnoListDto alumno)
        {
            r.Cells[cmnAlumno.Index].Value = alumno.NombreCompleto;

            r.Tag = alumno;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r=new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }
    }
}
