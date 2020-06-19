using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Curso;
using EFWindowsFormEjemplo01.Entities.Maps;
using EFWindowsFormEjemplo01.Service.Services;
using EFWindowsFormEjemplo01.Service.Services.Facades;
using MetroFramework;

namespace EFWindowsFormEjemplo01.Windows
{
    public partial class FrmCursos : MetroFramework.Forms.MetroForm
    {
        private FrmCursos()
        {
            InitializeComponent();
        }
        private static FrmCursos _instancia = null;

        public static FrmCursos GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmCursos();
                _instancia.FormClosed += form_Close;
            }

            return _instancia;
        }

        private static void form_Close(object sender, FormClosedEventArgs e)
        {
            _instancia = null;
        }

        private void mbtCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IServicioCurso servicio;
        private List<CursoListDto> lista;

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            servicio=new ServicioCursos();
            try
            {
                lista = servicio.GetCursos();
                MostrarDatosGrilla();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void MostrarDatosGrilla()
        {
            mgDatos.Rows.Clear();
            foreach (var cursoListDto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, cursoListDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            mgDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, CursoListDto cursoDto)
        {
            r.Cells[cmnCurso.Index].Value = cursoDto.Nombre;
            r.Cells[cmnCosto.Index].Value = cursoDto.PrecioTotal.ToString("C");

            if (cursoDto.Vacantes==0)
            {
                r.DefaultCellStyle.BackColor = Color.Red;
            }

            r.Tag = cursoDto;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r=new DataGridViewRow();
            r.CreateCells(mgDatos);
            return r;
        }

        private void mgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==2)
            {
                //Ver info del curso
                DataGridViewRow r = mgDatos.SelectedRows[0];
                CursoListDto cursoDto = (CursoListDto) r.Tag;
                try
                {
                    CursoMasInfoDto cursoMasInfoDto = servicio.GetMasDatos(cursoDto.CursoId);
                    FrmInfoCurso frm=new FrmInfoCurso();
                    frm.SetCurso(cursoMasInfoDto);
                    frm.ShowDialog(this);

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }

            if (e.ColumnIndex==3)
            {
                DataGridViewRow r = mgDatos.SelectedRows[0];
                CursoListDto cursoDto = (CursoListDto) r.Tag;
                try
                {
                    DialogResult dr = MetroMessageBox.Show(this, $"¿Desea dar de baja el curso {cursoDto.Nombre}?",
                        "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2);
                    if (dr==DialogResult.Yes)
                    {
                        CursoEditDto cursoEditDto = Mapeador.CrearMapper().Map<CursoListDto, CursoEditDto>(cursoDto);
                        if (!servicio.EstaRelacionado(cursoEditDto))
                        {
                            servicio.Borrar(cursoEditDto.CursoId);
                            MetroMessageBox.Show(this, "Registro Borrado", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            mgDatos.Rows.Remove(r);
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Curso relacionado",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception exception)
                {
                    MetroMessageBox.Show(this, exception.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void mbtNuevo_Click(object sender, EventArgs e)
        {
            FrmCursoAE frm=new FrmCursoAE();
            frm.Text = "Nuevo Curso...";
            DialogResult dr = frm.ShowDialog(this);
            //TODO:Completar el alta de un nuevo curso.
        }
    }
}
