namespace EFWindowsFormEjemplo01.Windows
{
    partial class FrmAlumnoAE
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
            this.CancelarMetroButton = new MetroFramework.Controls.MetroButton();
            this.GuardarMetroButton = new MetroFramework.Controls.MetroButton();
            this.ApellidoMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.NombreMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // CancelarMetroButton
            // 
            this.CancelarMetroButton.BackColor = System.Drawing.Color.Red;
            this.CancelarMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelarMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.CancelarMetroButton.Location = new System.Drawing.Point(282, 168);
            this.CancelarMetroButton.Name = "CancelarMetroButton";
            this.CancelarMetroButton.Size = new System.Drawing.Size(167, 71);
            this.CancelarMetroButton.TabIndex = 7;
            this.CancelarMetroButton.Text = "Cancelar";
            this.CancelarMetroButton.UseCustomBackColor = true;
            this.CancelarMetroButton.UseSelectable = true;
            this.CancelarMetroButton.Click += new System.EventHandler(this.CancelarMetroButton_Click);
            // 
            // GuardarMetroButton
            // 
            this.GuardarMetroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GuardarMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GuardarMetroButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.GuardarMetroButton.Location = new System.Drawing.Point(44, 168);
            this.GuardarMetroButton.Name = "GuardarMetroButton";
            this.GuardarMetroButton.Size = new System.Drawing.Size(167, 71);
            this.GuardarMetroButton.TabIndex = 8;
            this.GuardarMetroButton.Text = "Guardar";
            this.GuardarMetroButton.UseCustomBackColor = true;
            this.GuardarMetroButton.UseSelectable = true;
            this.GuardarMetroButton.Click += new System.EventHandler(this.GuardarMetroButton_Click);
            // 
            // ApellidoMetroTextBox
            // 
            // 
            // 
            // 
            this.ApellidoMetroTextBox.CustomButton.Image = null;
            this.ApellidoMetroTextBox.CustomButton.Location = new System.Drawing.Point(315, 1);
            this.ApellidoMetroTextBox.CustomButton.Name = "";
            this.ApellidoMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ApellidoMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ApellidoMetroTextBox.CustomButton.TabIndex = 1;
            this.ApellidoMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ApellidoMetroTextBox.CustomButton.UseSelectable = true;
            this.ApellidoMetroTextBox.CustomButton.Visible = false;
            this.ApellidoMetroTextBox.Lines = new string[0];
            this.ApellidoMetroTextBox.Location = new System.Drawing.Point(112, 113);
            this.ApellidoMetroTextBox.MaxLength = 32767;
            this.ApellidoMetroTextBox.Name = "ApellidoMetroTextBox";
            this.ApellidoMetroTextBox.PasswordChar = '\0';
            this.ApellidoMetroTextBox.PromptText = "Ingrese el apellido";
            this.ApellidoMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ApellidoMetroTextBox.SelectedText = "";
            this.ApellidoMetroTextBox.SelectionLength = 0;
            this.ApellidoMetroTextBox.SelectionStart = 0;
            this.ApellidoMetroTextBox.ShortcutsEnabled = true;
            this.ApellidoMetroTextBox.Size = new System.Drawing.Size(337, 23);
            this.ApellidoMetroTextBox.TabIndex = 5;
            this.ApellidoMetroTextBox.UseSelectable = true;
            this.ApellidoMetroTextBox.WaterMark = "Ingrese el apellido";
            this.ApellidoMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ApellidoMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(44, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Apellido:";
            // 
            // NombreMetroTextBox
            // 
            // 
            // 
            // 
            this.NombreMetroTextBox.CustomButton.Image = null;
            this.NombreMetroTextBox.CustomButton.Location = new System.Drawing.Point(315, 1);
            this.NombreMetroTextBox.CustomButton.Name = "";
            this.NombreMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NombreMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NombreMetroTextBox.CustomButton.TabIndex = 1;
            this.NombreMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NombreMetroTextBox.CustomButton.UseSelectable = true;
            this.NombreMetroTextBox.CustomButton.Visible = false;
            this.NombreMetroTextBox.Lines = new string[0];
            this.NombreMetroTextBox.Location = new System.Drawing.Point(112, 75);
            this.NombreMetroTextBox.MaxLength = 32767;
            this.NombreMetroTextBox.Name = "NombreMetroTextBox";
            this.NombreMetroTextBox.PasswordChar = '\0';
            this.NombreMetroTextBox.PromptText = "Ingrese el Nombre";
            this.NombreMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NombreMetroTextBox.SelectedText = "";
            this.NombreMetroTextBox.SelectionLength = 0;
            this.NombreMetroTextBox.SelectionStart = 0;
            this.NombreMetroTextBox.ShortcutsEnabled = true;
            this.NombreMetroTextBox.Size = new System.Drawing.Size(337, 23);
            this.NombreMetroTextBox.TabIndex = 6;
            this.NombreMetroTextBox.UseSelectable = true;
            this.NombreMetroTextBox.WaterMark = "Ingrese el Nombre";
            this.NombreMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NombreMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Nombre:";
            // 
            // FrmAlumnoAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 298);
            this.ControlBox = false;
            this.Controls.Add(this.CancelarMetroButton);
            this.Controls.Add(this.GuardarMetroButton);
            this.Controls.Add(this.ApellidoMetroTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.NombreMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmAlumnoAE";
            this.Text = "FrmAlumnoAE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton CancelarMetroButton;
        private MetroFramework.Controls.MetroButton GuardarMetroButton;
        private MetroFramework.Controls.MetroTextBox ApellidoMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox NombreMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}