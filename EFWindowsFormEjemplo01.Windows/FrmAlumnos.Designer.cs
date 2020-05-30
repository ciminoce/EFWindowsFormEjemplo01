namespace EFWindowsFormEjemplo01.Windows
{
    partial class FrmAlumnos
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
            this.cmnAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.mbtCerrar = new MetroFramework.Controls.MetroButton();
            this.cmnBorrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmnEditar = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.panel1.Size = new System.Drawing.Size(839, 578);
            this.panel1.TabIndex = 0;
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
            this.cmnAlumno,
            this.cmnBorrar,
            this.cmnEditar});
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
            this.mgDatos.Size = new System.Drawing.Size(839, 578);
            this.mgDatos.TabIndex = 0;
            this.mgDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgDatos_CellContentClick);
            // 
            // cmnAlumno
            // 
            this.cmnAlumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnAlumno.HeaderText = "Alumnos";
            this.cmnAlumno.Name = "cmnAlumno";
            this.cmnAlumno.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Borrar";
            this.dataGridViewImageColumn1.Image = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_edit_delete_23231;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_website___pencil_3440848;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.BackgroundImage = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_plus_1646001;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(736, 6);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(64, 48);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.UseSelectable = true;
            // 
            // mbtCerrar
            // 
            this.mbtCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtCerrar.BackgroundImage = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_Close_Box_Red_34217;
            this.mbtCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mbtCerrar.Location = new System.Drawing.Point(795, 6);
            this.mbtCerrar.Name = "mbtCerrar";
            this.mbtCerrar.Size = new System.Drawing.Size(64, 48);
            this.mbtCerrar.TabIndex = 1;
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
            // cmnEditar
            // 
            this.cmnEditar.HeaderText = "Editar";
            this.cmnEditar.Image = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.iconfinder_website___pencil_3440848;
            this.cmnEditar.Name = "cmnEditar";
            this.cmnEditar.ReadOnly = true;
            // 
            // FrmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 658);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mbtCerrar);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(686, 583);
            this.Name = "FrmAlumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.FrmAlumnos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton mbtCerrar;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid mgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnAlumno;
        private System.Windows.Forms.DataGridViewImageColumn cmnBorrar;
        private System.Windows.Forms.DataGridViewImageColumn cmnEditar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}