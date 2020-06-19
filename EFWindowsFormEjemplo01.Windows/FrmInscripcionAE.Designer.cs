namespace EFWindowsFormEjemplo01.Windows
{
    partial class FrmInscripcionAE
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
            this.components = new System.ComponentModel.Container();
            this.alumnoMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cursoMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.fechaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelarMetroButton = new MetroFramework.Controls.MetroButton();
            this.GuardarMetroButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // alumnoMetroComboBox
            // 
            this.alumnoMetroComboBox.FormattingEnabled = true;
            this.alumnoMetroComboBox.ItemHeight = 23;
            this.alumnoMetroComboBox.Location = new System.Drawing.Point(126, 150);
            this.alumnoMetroComboBox.Name = "alumnoMetroComboBox";
            this.alumnoMetroComboBox.Size = new System.Drawing.Size(634, 29);
            this.alumnoMetroComboBox.TabIndex = 22;
            this.alumnoMetroComboBox.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(41, 153);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Alumno:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Curso:";
            // 
            // cursoMetroComboBox
            // 
            this.cursoMetroComboBox.FormattingEnabled = true;
            this.cursoMetroComboBox.ItemHeight = 23;
            this.cursoMetroComboBox.Location = new System.Drawing.Point(126, 102);
            this.cursoMetroComboBox.Name = "cursoMetroComboBox";
            this.cursoMetroComboBox.Size = new System.Drawing.Size(634, 29);
            this.cursoMetroComboBox.TabIndex = 22;
            this.cursoMetroComboBox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 213);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Fecha:";
            // 
            // fechaTimePicker
            // 
            this.fechaTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaTimePicker.Location = new System.Drawing.Point(126, 211);
            this.fechaTimePicker.Name = "fechaTimePicker";
            this.fechaTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaTimePicker.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CancelarMetroButton
            // 
            this.CancelarMetroButton.BackColor = System.Drawing.Color.Red;
            this.CancelarMetroButton.BackgroundImage = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.cancel_36px;
            this.CancelarMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelarMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CancelarMetroButton.Location = new System.Drawing.Point(447, 299);
            this.CancelarMetroButton.Name = "CancelarMetroButton";
            this.CancelarMetroButton.Size = new System.Drawing.Size(167, 71);
            this.CancelarMetroButton.TabIndex = 24;
            this.CancelarMetroButton.Text = "Cancelar";
            this.CancelarMetroButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelarMetroButton.UseCustomBackColor = true;
            this.CancelarMetroButton.UseSelectable = true;
            this.CancelarMetroButton.Click += new System.EventHandler(this.CancelarMetroButton_Click);
            // 
            // GuardarMetroButton
            // 
            this.GuardarMetroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GuardarMetroButton.BackgroundImage = global::EFWindowsFormEjemplo01.Windows.Properties.Resources.save_as_36px;
            this.GuardarMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GuardarMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.GuardarMetroButton.Location = new System.Drawing.Point(209, 299);
            this.GuardarMetroButton.Name = "GuardarMetroButton";
            this.GuardarMetroButton.Size = new System.Drawing.Size(167, 71);
            this.GuardarMetroButton.TabIndex = 23;
            this.GuardarMetroButton.Text = "Guardar";
            this.GuardarMetroButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarMetroButton.UseCustomBackColor = true;
            this.GuardarMetroButton.UseSelectable = true;
            this.GuardarMetroButton.Click += new System.EventHandler(this.GuardarMetroButton_Click);
            // 
            // FrmInscripcionAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.fechaTimePicker);
            this.Controls.Add(this.CancelarMetroButton);
            this.Controls.Add(this.GuardarMetroButton);
            this.Controls.Add(this.cursoMetroComboBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.alumnoMetroComboBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel6);
            this.Name = "FrmInscripcionAE";
            this.Text = "FrmInscripcionAE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton CancelarMetroButton;
        private MetroFramework.Controls.MetroButton GuardarMetroButton;
        private MetroFramework.Controls.MetroComboBox alumnoMetroComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cursoMetroComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker fechaTimePicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}