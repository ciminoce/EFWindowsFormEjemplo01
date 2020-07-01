using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.DTOs.Inscripcion;
using EFWindowsFormEjemplo01.Entities.Maps;
using EFWindowsFormEjemplo01.Service.Services;
using EFWindowsFormEjemplo01.Service.Services.Facades;
using EFWindowsFormEjemplo01.Windows.Helpers;
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
            Helper.CargarDatosComboCursos(ref cursoMetroComboBox);
            MostrarListaInicial();
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
                    Helper.MostrarMensaje(this, "Registro Agregado",Tipo.Success);

                }
                catch (Exception ex)
                {
                    Helper.MostrarMensaje(this,ex.Message,Tipo.Error);

                }
            }
        }
        private void mgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==3)
            {
                DataGridViewRow r = mgDatos.SelectedRows[0];
                InscripcionListDto inscripcionListDto = (InscripcionListDto) r.Tag;
                DialogResult dr = Helper.MostrarMensaje(this, "¿Desea dar de baja el registro seleccionado?");
                if (dr==DialogResult.Yes)
                {
                    try
                    {
                        servicio.Borrar(inscripcionListDto.InscripcionId);
                        QuitarFila(r);
                        Helper.MostrarMensaje(this, "Registro borrado con éxito", Tipo.Success);
                    }
                    catch (Exception exception)
                    {
                        Helper.MostrarMensaje(this, exception.Message, Tipo.Error);
                    }
                }
            }
        }

        private void QuitarFila(DataGridViewRow r)
        {
            mgDatos.Rows.Remove(r);
        }

        private void cursoMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cursoMetroComboBox.SelectedIndex>0)
            {
                CursoListDto curso = (CursoListDto) cursoMetroComboBox.SelectedItem;
                lista = servicio.GetInscripciones(curso);
                MostrarDatosEnGrilla();
            }
        }

        private void actualizarMetroButton_Click(object sender, EventArgs e)
        {
            cursoMetroComboBox.SelectedIndex = 0;
            MostrarListaInicial();
        }

        private void MostrarListaInicial()
        {
            try
            {
                lista = servicio.GetInscripciones(null);
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
