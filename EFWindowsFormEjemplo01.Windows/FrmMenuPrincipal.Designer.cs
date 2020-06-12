namespace EFWindowsFormEjemplo01.Windows
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtCursos = new MetroFramework.Controls.MetroTile();
            this.mtProfesores = new MetroFramework.Controls.MetroTile();
            this.mtSalir = new MetroFramework.Controls.MetroTile();
            this.mtInscripciones = new MetroFramework.Controls.MetroTile();
            this.mtAlumnos = new MetroFramework.Controls.MetroTile();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.toolStripSeparator1,
            this.inscripcionesToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.inscripcionesToolStripMenuItem.Text = "Inscripciones";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mtCursos
            // 
            this.mtCursos.ActiveControl = null;
            this.mtCursos.BackColor = System.Drawing.Color.Blue;
            this.mtCursos.Location = new System.Drawing.Point(233, 309);
            this.mtCursos.Name = "mtCursos";
            this.mtCursos.Size = new System.Drawing.Size(162, 121);
            this.mtCursos.TabIndex = 2;
            this.mtCursos.Text = "Cursos";
            this.mtCursos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCursos.TileImage = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_Courses_85503;
            this.mtCursos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCursos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCursos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtCursos.UseCustomBackColor = true;
            this.mtCursos.UseSelectable = true;
            this.mtCursos.UseTileImage = true;
            this.mtCursos.Click += new System.EventHandler(this.mtCursos_Click);
            // 
            // mtProfesores
            // 
            this.mtProfesores.ActiveControl = null;
            this.mtProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mtProfesores.Location = new System.Drawing.Point(62, 309);
            this.mtProfesores.Name = "mtProfesores";
            this.mtProfesores.Size = new System.Drawing.Size(165, 121);
            this.mtProfesores.TabIndex = 2;
            this.mtProfesores.Text = "Profesores";
            this.mtProfesores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtProfesores.TileImage = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_Teachers_24_103847;
            this.mtProfesores.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtProfesores.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtProfesores.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtProfesores.UseCustomBackColor = true;
            this.mtProfesores.UseSelectable = true;
            this.mtProfesores.UseTileImage = true;
            this.mtProfesores.Click += new System.EventHandler(this.mtProfesores_Click);
            // 
            // mtSalir
            // 
            this.mtSalir.ActiveControl = null;
            this.mtSalir.BackColor = System.Drawing.Color.LightGray;
            this.mtSalir.Location = new System.Drawing.Point(696, 507);
            this.mtSalir.Name = "mtSalir";
            this.mtSalir.Size = new System.Drawing.Size(143, 102);
            this.mtSalir.TabIndex = 2;
            this.mtSalir.Text = "Salir";
            this.mtSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSalir.TileImage = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_logout_59379;
            this.mtSalir.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSalir.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSalir.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtSalir.UseCustomBackColor = true;
            this.mtSalir.UseSelectable = true;
            this.mtSalir.UseTileImage = true;
            this.mtSalir.Click += new System.EventHandler(this.mtSalir_Click);
            // 
            // mtInscripciones
            // 
            this.mtInscripciones.ActiveControl = null;
            this.mtInscripciones.BackColor = System.Drawing.Color.Red;
            this.mtInscripciones.Location = new System.Drawing.Point(413, 163);
            this.mtInscripciones.Name = "mtInscripciones";
            this.mtInscripciones.Size = new System.Drawing.Size(187, 267);
            this.mtInscripciones.TabIndex = 2;
            this.mtInscripciones.Text = "Inscripciones";
            this.mtInscripciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtInscripciones.TileImage = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_notepad_285631;
            this.mtInscripciones.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtInscripciones.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtInscripciones.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtInscripciones.UseCustomBackColor = true;
            this.mtInscripciones.UseSelectable = true;
            this.mtInscripciones.UseTileImage = true;
            // 
            // mtAlumnos
            // 
            this.mtAlumnos.ActiveControl = null;
            this.mtAlumnos.BackColor = System.Drawing.Color.Aqua;
            this.mtAlumnos.Location = new System.Drawing.Point(62, 163);
            this.mtAlumnos.Name = "mtAlumnos";
            this.mtAlumnos.Size = new System.Drawing.Size(333, 121);
            this.mtAlumnos.TabIndex = 2;
            this.mtAlumnos.Text = "Alumnos";
            this.mtAlumnos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAlumnos.TileImage = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_people_12_2716070;
            this.mtAlumnos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAlumnos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAlumnos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtAlumnos.UseCustomBackColor = true;
            this.mtAlumnos.UseSelectable = true;
            this.mtAlumnos.UseTileImage = true;
            this.mtAlumnos.Click += new System.EventHandler(this.mtAlumnos_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 635);
            this.ControlBox = false;
            this.Controls.Add(this.mtCursos);
            this.Controls.Add(this.mtProfesores);
            this.Controls.Add(this.mtSalir);
            this.Controls.Add(this.mtInscripciones);
            this.Controls.Add(this.mtAlumnos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(872, 635);
            this.MinimumSize = new System.Drawing.Size(872, 635);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menú Principal de Control de Cursos";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private MetroFramework.Controls.MetroTile mtAlumnos;
        private MetroFramework.Controls.MetroTile mtProfesores;
        private MetroFramework.Controls.MetroTile mtCursos;
        private MetroFramework.Controls.MetroTile mtInscripciones;
        private MetroFramework.Controls.MetroTile mtSalir;
    }
}

