using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;
using EFWindowsFormEjemplo01.Entities.Maps;
using EFWindowsFormEjemplo01.Service.Services;
using EFWindowsFormEjemplo01.Service.Services.Facades;
using MetroFramework;

namespace EFWindowsFormEjemplo01.Windows
{
    public partial class FrmInscripciones : MetroFramework.Forms.MetroForm
    {
        public FrmInscripciones()
        {
            InitializeComponent();
        }

        private void mbtCerrar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private IServicioInscripcion servicio;
        private List<InscripcionListDto> lista;
        private void FrmInscripciones_Load(object sender, System.EventArgs e)
        {
            servicio=new ServicioInscripciones();
            try
            {
                lista = servicio.GetInscripciones();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            mgDatos.Rows.Clear();
            foreach (var inscripcionDto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, inscripcionDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            mgDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, InscripcionListDto inscripcionDto)
        {
            r.Cells[cmnAlumno.Index].Value = inscripcionDto.AlumnoListDto.NombreCompleto;
            r.Cells[cmnCurso.Index].Value = inscripcionDto.CursoListDto.Nombre;
            r.Cells[cmnFecha.Index].Value = inscripcionDto.FechaInscripcion.ToShortDateString();

            r.Tag = inscripcionDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(mgDatos);
            return r;
        }

        private void mbtNuevo_Click(object sender, EventArgs e)
        {
            FrmInscripcionAE frm=new FrmInscripcionAE();
            frm.Text = "Nueva Inscripcion";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    InscripcionEditDto inscripcionEditDto = frm.GetInscripcion();
                    servicio.Guardar(inscripcionEditDto);
                    InscripcionListDto inscripcionListDto = Mapeador.CrearMapper()
                        .Map<InscripcionEditDto, InscripcionListDto>(inscripcionEditDto);
                    DataGridViewRow r = ConstruirFila();
                    SetearFila(r, inscripcionListDto);
                    AgregarFila(r);
                    MetroMessageBox.Show(this, "Registro Agregado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
