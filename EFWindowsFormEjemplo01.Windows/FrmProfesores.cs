using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Profesor;
using EFWindowsFormEjemplo01.Entities.Maps;
using EFWindowsFormEjemplo01.Service.Services;
using EFWindowsFormEjemplo01.Service.Services.Facades;
using MetroFramework;

namespace EFWindowsFormEjemplo01.Windows
{
    public partial class FrmProfesores : MetroFramework.Forms.MetroForm
    {
        private FrmProfesores()
        {
            InitializeComponent();
        }
        private static FrmProfesores _instancia = null;

        public static FrmProfesores GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmProfesores();
                _instancia.FormClosed += form_Close;
            }

            return _instancia;
        }

        private static void form_Close(object sender, FormClosedEventArgs e)
        {
            _instancia = null;
        }


        private IServicioProfesor servicio;
        private List<ProfesorListDto> lista;
        private void FrmProfesors_Load(object sender, EventArgs e)
        {
            servicio = new ServicioProfesores();
            this.Dock = DockStyle.Fill;
            try
            {
                lista = servicio.GetProfesores();
                MostrarDatosEnGrilla();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            mgDatos.Rows.Clear();
            foreach (var profesorDto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, profesorDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            mgDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, ProfesorListDto profesor)
        {
            r.Cells[cmnProfesor.Index].Value = profesor.NombreCompleto;

            r.Tag = profesor;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(mgDatos);
            return r;
        }

        private void mbtCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = mgDatos.SelectedRows[0];
            ProfesorListDto profesorListDto = (ProfesorListDto)r.Tag;
            if (e.ColumnIndex == 1)
            {
                DialogResult dr = MetroMessageBox.Show(this,
                    $"¿Desea dar de baja al profesor {profesorListDto.NombreCompleto}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (!servicio.EstaRelacionado(profesorListDto))
                        {

                            servicio.Borrar(profesorListDto.ProfesorId);
                            mgDatos.Rows.Remove(r);
                            MetroMessageBox.Show(this, "Registro borrado",
                                "Mensaje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception exception)
                    {
                        MetroMessageBox.Show(this, exception.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    }
                }
            }
            else if (e.ColumnIndex == 2)
            {
                ProfesorEditDto profesorEditDto = servicio.GetProfesorPorId(profesorListDto.ProfesorId);
                FrmProfesorAE frm = new FrmProfesorAE();
                frm.Text = "Editar Profesor";
                frm.SetProfesor(profesorEditDto);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        profesorEditDto = frm.GetProfesor();
                        servicio.Guardar(profesorEditDto);
                        profesorListDto = Mapeador.CrearMapper().Map<ProfesorListDto>(profesorEditDto);
                        SetearFila(r, profesorListDto);
                        MetroMessageBox.Show(this, "Registro Editado", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        MetroMessageBox.Show(this, exception.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void mbtNuevo_Click(object sender, EventArgs e)
        {
            FrmProfesorAE frm = new FrmProfesorAE();
            frm.Text = "Nuevo profesor...";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    ProfesorEditDto profesorEditDto = frm.GetProfesor();

                    servicio.Guardar(profesorEditDto);
                    DataGridViewRow r = ConstruirFila();
                    ProfesorListDto profesorListDto = Mapeador.CrearMapper().Map<ProfesorListDto>(profesorEditDto);
                    SetearFila(r, profesorListDto);
                    AgregarFila(r);
                    MetroMessageBox.Show(this, "Registro agregado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MetroMessageBox.Show(this, exception.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

    }
}
