﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Entities.DTOs.Alumno;
using EFWindowsFormEjemplo01.Entities.Maps;
using EFWindowsFormEjemplo01.Service.Services;
using EFWindowsFormEjemplo01.Service.Services.Facades;
using EFWindowsFormEjemplo01.Windows.Helpers;
using EFWindowsFormEjemplo01.Windows.Ninject;
using MetroFramework;

namespace EFWindowsFormEjemplo01.Windows
{
    public partial class FrmAlumnos : MetroFramework.Forms.MetroForm
    {
        //private static FrmAlumnos _instancia = null;

        //public static FrmAlumnos GetInstancia()
        //{
        //    if (_instancia==null)
        //    {
        //        _instancia=new FrmAlumnos();
        //        _instancia.FormClosed += form_Close;
        //    }

        //    return _instancia;
        //}

        //private static void form_Close(object sender, FormClosedEventArgs e)
        //{
        //    _instancia = null;
        //}

        public FrmAlumnos(IServicioAlumno servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private readonly IServicioAlumno servicio;
        private List<AlumnoListDto> lista;
        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            //servicio=new ServicioAlumnos();
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
            mgDatos.Rows.Clear();
            foreach (var alumnoDto in lista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, alumnoDto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            mgDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, AlumnoListDto alumno)
        {
            r.Cells[cmnAlumno.Index].Value = alumno.NombreCompleto;

            r.Tag = alumno;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r=new DataGridViewRow();
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
            AlumnoListDto alumnoListDto = (AlumnoListDto) r.Tag;
            if (e.ColumnIndex==1)
            {
                DialogResult dr = MetroMessageBox.Show(this,
                    $"¿Desea dar de baja al alumno {alumnoListDto.NombreCompleto}?",
                    "Confirmar Baja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr==DialogResult.Yes)
                {
                    try
                    {
                        if (!servicio.EstaRelacionado(alumnoListDto))
                        {

                            servicio.Borrar(alumnoListDto.AlumnoId);
                            mgDatos.Rows.Remove(r);
                            MetroMessageBox.Show(this, "Registro borrado",
                                "Mensaje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                        }
                        else
                        {
                            Helper.MostrarMensaje(this, "Registro relacionado", Tipo.Error);
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
            }else if (e.ColumnIndex==2)
            {
                AlumnoEditDto alumnoEditDto = servicio.GetAlumnoPorId(alumnoListDto.AlumnoId);
                FrmAlumnoAE frm=DI.Create<FrmAlumnoAE>();
                frm.Text = "Editar Alumno";
                frm.SetAlumno(alumnoEditDto);
                DialogResult dr = frm.ShowDialog(this);
                if (dr==DialogResult.OK)
                {
                    try
                    {
                        alumnoEditDto = frm.GetAlumno();

                        if (!servicio.Existe(alumnoEditDto))
                        {
                            servicio.Guardar(alumnoEditDto);
                            alumnoListDto = Mapeador.CrearMapper().Map<AlumnoListDto>(alumnoEditDto);
                            SetearFila(r, alumnoListDto);
                            MetroMessageBox.Show(this, "Registro Editado", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            Helper.MostrarMensaje(this, "Registro repetido", Tipo.Error);

                        }
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
            FrmAlumnoAE frm=DI.Create<FrmAlumnoAE>();
            frm.Text = "Nuevo alumno...";
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                try
                {
                    AlumnoEditDto alumnoEditDto = frm.GetAlumno();

                    servicio.Guardar(alumnoEditDto);
                    DataGridViewRow r = ConstruirFila();
                    AlumnoListDto alumnoListDto = Mapeador.CrearMapper().Map<AlumnoListDto>(alumnoEditDto);
                    SetearFila(r,alumnoListDto);
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
