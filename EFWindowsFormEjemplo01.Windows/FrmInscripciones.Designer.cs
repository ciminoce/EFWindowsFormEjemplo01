namespace EFWindowsFormEjemplo01.Windows
{
    partial class FrmInscripciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mgDatos = new MetroFramework.Controls.MetroGrid();
            this.cmnCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.mbtNuevo = new MetroFramework.Controls.MetroButton();
            this.mbtCerrar = new MetroFramework.Controls.MetroButton();
            this.cmnBorrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mgDatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 560);
            this.panel1.TabIndex = 5;
            // 
            // mgDatos
            // 
            this.mgDatos.AllowUserToAddRows = false;
            this.mgDatos.AllowUserToDeleteRows = false;
            this.mgDatos.AllowUserToResizeRows = false;
            this.mgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnCurso,
            this.cmnAlumno,
            this.cmnFecha,
            this.cmnBorrar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgDatos.EnableHeadersVisualStyles = false;
            this.mgDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgDatos.Location = new System.Drawing.Point(0, 0);
            this.mgDatos.MultiSelect = false;
            this.mgDatos.Name = "mgDatos";
            this.mgDatos.ReadOnly = true;
            this.mgDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgDatos.RowHeadersVisible = false;
            this.mgDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mgDatos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.mgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgDatos.Size = new System.Drawing.Size(1133, 560);
            this.mgDatos.TabIndex = 0;
            // 
            // cmnCurso
            // 
            this.cmnCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnCurso.HeaderText = "Curso";
            this.cmnCurso.Name = "cmnCurso";
            this.cmnCurso.ReadOnly = true;
            // 
            // cmnAlumno
            // 
            this.cmnAlumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnAlumno.HeaderText = "Alumno";
            this.cmnAlumno.Name = "cmnAlumno";
            this.cmnAlumno.ReadOnly = true;
            // 
            // cmnFecha
            // 
            this.cmnFecha.HeaderText = "Fecha";
            this.cmnFecha.Name = "cmnFecha";
            this.cmnFecha.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Borrar";
            this.dataGridViewImageColumn1.Image = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_edit_delete_23231;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // mbtNuevo
            // 
            this.mbtNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtNuevo.BackgroundImage = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_plus_1646001;
            this.mbtNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mbtNuevo.Location = new System.Drawing.Point(1014, 13);
            this.mbtNuevo.Name = "mbtNuevo";
            this.mbtNuevo.Size = new System.Drawing.Size(64, 48);
            this.mbtNuevo.TabIndex = 7;
            this.mbtNuevo.UseSelectable = true;
            this.mbtNuevo.Click += new System.EventHandler(this.mbtNuevo_Click);
            // 
            // mbtCerrar
            // 
            this.mbtCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtCerrar.BackgroundImage = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_Close_Box_Red_34217;
            this.mbtCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mbtCerrar.Location = new System.Drawing.Point(1089, 13);
            this.mbtCerrar.Name = "mbtCerrar";
            this.mbtCerrar.Size = new System.Drawing.Size(64, 48);
            this.mbtCerrar.TabIndex = 6;
            this.mbtCerrar.UseSelectable = true;
            this.mbtCerrar.Click += new System.EventHandler(this.mbtCerrar_Click);
            // 
            // cmnBorrar
            // 
            this.cmnBorrar.HeaderText = "Borrar";
            this.cmnBorrar.Image = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_edit_delete_23231;
            this.cmnBorrar.Name = "cmnBorrar";
            this.cmnBorrar.ReadOnly = true;
            // 
            // FrmInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 640);
            this.ControlBox = false;
            this.Controls.Add(this.mbtNuevo);
            this.Controls.Add(this.mbtCerrar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInscripciones";
            this.Text = "FrmInscripciones";
            this.Load += new System.EventHandler(this.FrmInscripciones_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbtNuevo;
        private MetroFramework.Controls.MetroButton mbtCerrar;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroGrid mgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnFecha;
        private System.Windows.Forms.DataGridViewImageColumn cmnBorrar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}