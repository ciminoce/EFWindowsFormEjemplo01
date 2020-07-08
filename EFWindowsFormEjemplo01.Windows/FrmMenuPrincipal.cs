using System;
using System.Windows.Forms;
using EFWindowsFormEjemplo01.Windows.Ninject;

namespace EFWindowsFormEjemplo01.Windows
{
    public partial class FrmMenuPrincipal : MetroFramework.Forms.MetroForm
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmAlumnos frm=FrmAlumnos.GetInstancia();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void mtSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mtAlumnos_Click(object sender, EventArgs e)
        {
            FrmAlumnos frm = DI.Create<FrmAlumnos>();
            frm.ShowDialog(this);

        }

        private void mtProfesores_Click(object sender, EventArgs e)
        {
            FrmProfesores frm=FrmProfesores.GetInstancia();
            frm.ShowDialog(this);
        }

        private void mtCursos_Click(object sender, EventArgs e)
        {
            FrmCursos frm=FrmCursos.GetInstancia();
            frm.ShowDialog(this);
        }

        private void mtInscripciones_Click(object sender, EventArgs e)
        {
            FrmInscripciones frm=new FrmInscripciones();
            frm.ShowDialog(this);
        }
    }
}
