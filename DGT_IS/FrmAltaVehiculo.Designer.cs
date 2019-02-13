namespace DGT_IS
{
    partial class FrmAltaVehiculo
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
            this.LblMatricula = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.LblModelo = new System.Windows.Forms.Label();
            this.TbMatricula = new System.Windows.Forms.TextBox();
            this.TbMarca = new System.Windows.Forms.TextBox();
            this.TbModelo = new System.Windows.Forms.TextBox();
            this.BtnAnadirVehiculo = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.CbConductorHabitual = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbSeleccionaConductores = new System.Windows.Forms.ListBox();
            this.LblConductoresHabituales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Location = new System.Drawing.Point(16, 85);
            this.LblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(65, 17);
            this.LblMatricula.TabIndex = 0;
            this.LblMatricula.Text = "Matricula";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(16, 143);
            this.LblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(47, 17);
            this.LblMarca.TabIndex = 1;
            this.LblMarca.Text = "Marca";
            // 
            // LblModelo
            // 
            this.LblModelo.AutoSize = true;
            this.LblModelo.Location = new System.Drawing.Point(16, 194);
            this.LblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(54, 17);
            this.LblModelo.TabIndex = 2;
            this.LblModelo.Text = "Modelo";
            // 
            // TbMatricula
            // 
            this.TbMatricula.Location = new System.Drawing.Point(187, 81);
            this.TbMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.TbMatricula.MaxLength = 15;
            this.TbMatricula.Name = "TbMatricula";
            this.TbMatricula.Size = new System.Drawing.Size(132, 22);
            this.TbMatricula.TabIndex = 0;
            // 
            // TbMarca
            // 
            this.TbMarca.Location = new System.Drawing.Point(187, 139);
            this.TbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.TbMarca.MaxLength = 25;
            this.TbMarca.Name = "TbMarca";
            this.TbMarca.Size = new System.Drawing.Size(240, 22);
            this.TbMarca.TabIndex = 1;
            // 
            // TbModelo
            // 
            this.TbModelo.Location = new System.Drawing.Point(187, 191);
            this.TbModelo.Margin = new System.Windows.Forms.Padding(4);
            this.TbModelo.MaxLength = 25;
            this.TbModelo.Name = "TbModelo";
            this.TbModelo.Size = new System.Drawing.Size(240, 22);
            this.TbModelo.TabIndex = 2;
            // 
            // BtnAnadirVehiculo
            // 
            this.BtnAnadirVehiculo.Location = new System.Drawing.Point(13, 452);
            this.BtnAnadirVehiculo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAnadirVehiculo.Name = "BtnAnadirVehiculo";
            this.BtnAnadirVehiculo.Size = new System.Drawing.Size(187, 68);
            this.BtnAnadirVehiculo.TabIndex = 5;
            this.BtnAnadirVehiculo.Text = "&Añadir vehículo";
            this.BtnAnadirVehiculo.UseVisualStyleBackColor = true;
            this.BtnAnadirVehiculo.Click += new System.EventHandler(this.BtnAnadirVehiculo_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(637, 452);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(187, 68);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "&Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // CbConductorHabitual
            // 
            this.CbConductorHabitual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbConductorHabitual.FormattingEnabled = true;
            this.CbConductorHabitual.Location = new System.Drawing.Point(187, 240);
            this.CbConductorHabitual.Margin = new System.Windows.Forms.Padding(4);
            this.CbConductorHabitual.Name = "CbConductorHabitual";
            this.CbConductorHabitual.Size = new System.Drawing.Size(240, 24);
            this.CbConductorHabitual.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Conductor habitual";
            // 
            // LbSeleccionaConductores
            // 
            this.LbSeleccionaConductores.FormattingEnabled = true;
            this.LbSeleccionaConductores.ItemHeight = 16;
            this.LbSeleccionaConductores.Location = new System.Drawing.Point(460, 40);
            this.LbSeleccionaConductores.Margin = new System.Windows.Forms.Padding(4);
            this.LbSeleccionaConductores.Name = "LbSeleccionaConductores";
            this.LbSeleccionaConductores.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbSeleccionaConductores.Size = new System.Drawing.Size(364, 388);
            this.LbSeleccionaConductores.TabIndex = 4;
            // 
            // LblConductoresHabituales
            // 
            this.LblConductoresHabituales.AutoSize = true;
            this.LblConductoresHabituales.Location = new System.Drawing.Point(558, 19);
            this.LblConductoresHabituales.Name = "LblConductoresHabituales";
            this.LblConductoresHabituales.Size = new System.Drawing.Size(161, 17);
            this.LblConductoresHabituales.TabIndex = 7;
            this.LblConductoresHabituales.Text = "Conductores habituales ";
            // 
            // FrmAltaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 554);
            this.Controls.Add(this.LblConductoresHabituales);
            this.Controls.Add(this.LbSeleccionaConductores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbConductorHabitual);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAnadirVehiculo);
            this.Controls.Add(this.TbModelo);
            this.Controls.Add(this.TbMarca);
            this.Controls.Add(this.TbMatricula);
            this.Controls.Add(this.LblModelo);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblMatricula);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAltaVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Vehiculo";
            this.Load += new System.EventHandler(this.FrmAltaVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.TextBox TbMatricula;
        private System.Windows.Forms.TextBox TbMarca;
        private System.Windows.Forms.TextBox TbModelo;
        private System.Windows.Forms.Button BtnAnadirVehiculo;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox CbConductorHabitual;
        private System.Windows.Forms.ListBox LbSeleccionaConductores;
        private System.Windows.Forms.Label LblConductoresHabituales;
    }
}