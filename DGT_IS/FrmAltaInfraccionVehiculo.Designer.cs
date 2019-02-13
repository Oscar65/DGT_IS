namespace DGT_IS
{
    partial class FrmAltaInfraccionVehiculo
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
            this.CbInfraccion = new System.Windows.Forms.ComboBox();
            this.DtpFechaHora = new System.Windows.Forms.DateTimePicker();
            this.LblInfraccion = new System.Windows.Forms.Label();
            this.LblFechaHora = new System.Windows.Forms.Label();
            this.LblVehiculo = new System.Windows.Forms.Label();
            this.BtnAltaInfraccion = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnLeeFechaActual = new System.Windows.Forms.Button();
            this.TbMatricula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbInfraccion
            // 
            this.CbInfraccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbInfraccion.FormattingEnabled = true;
            this.CbInfraccion.Location = new System.Drawing.Point(167, 51);
            this.CbInfraccion.Name = "CbInfraccion";
            this.CbInfraccion.Size = new System.Drawing.Size(220, 24);
            this.CbInfraccion.TabIndex = 0;
            // 
            // DtpFechaHora
            // 
            this.DtpFechaHora.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.DtpFechaHora.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DtpFechaHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaHora.Location = new System.Drawing.Point(167, 110);
            this.DtpFechaHora.Name = "DtpFechaHora";
            this.DtpFechaHora.Size = new System.Drawing.Size(164, 22);
            this.DtpFechaHora.TabIndex = 1;
            this.DtpFechaHora.Value = new System.DateTime(2019, 2, 9, 19, 33, 2, 0);
            // 
            // LblInfraccion
            // 
            this.LblInfraccion.AutoSize = true;
            this.LblInfraccion.Location = new System.Drawing.Point(26, 58);
            this.LblInfraccion.Name = "LblInfraccion";
            this.LblInfraccion.Size = new System.Drawing.Size(69, 17);
            this.LblInfraccion.TabIndex = 3;
            this.LblInfraccion.Text = "Infracción";
            // 
            // LblFechaHora
            // 
            this.LblFechaHora.AutoSize = true;
            this.LblFechaHora.Location = new System.Drawing.Point(26, 115);
            this.LblFechaHora.Name = "LblFechaHora";
            this.LblFechaHora.Size = new System.Drawing.Size(91, 17);
            this.LblFechaHora.TabIndex = 4;
            this.LblFechaHora.Text = "Fecha y hora";
            // 
            // LblVehiculo
            // 
            this.LblVehiculo.AutoSize = true;
            this.LblVehiculo.Location = new System.Drawing.Point(26, 173);
            this.LblVehiculo.Name = "LblVehiculo";
            this.LblVehiculo.Size = new System.Drawing.Size(121, 17);
            this.LblVehiculo.TabIndex = 5;
            this.LblVehiculo.Text = "Matricula vehículo";
            // 
            // BtnAltaInfraccion
            // 
            this.BtnAltaInfraccion.Location = new System.Drawing.Point(41, 302);
            this.BtnAltaInfraccion.Name = "BtnAltaInfraccion";
            this.BtnAltaInfraccion.Size = new System.Drawing.Size(188, 85);
            this.BtnAltaInfraccion.TabIndex = 6;
            this.BtnAltaInfraccion.Text = "&Añadir Infracción";
            this.BtnAltaInfraccion.UseVisualStyleBackColor = true;
            this.BtnAltaInfraccion.Click += new System.EventHandler(this.BtnAltaInfraccion_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(572, 302);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(188, 85);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.Text = "&Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnLeeFechaActual
            // 
            this.BtnLeeFechaActual.Location = new System.Drawing.Point(337, 105);
            this.BtnLeeFechaActual.Name = "BtnLeeFechaActual";
            this.BtnLeeFechaActual.Size = new System.Drawing.Size(118, 37);
            this.BtnLeeFechaActual.TabIndex = 8;
            this.BtnLeeFechaActual.Text = "Actualizar hora";
            this.BtnLeeFechaActual.UseVisualStyleBackColor = true;
            this.BtnLeeFechaActual.Click += new System.EventHandler(this.BtnLeeFechaActual_Click);
            // 
            // TbMatricula
            // 
            this.TbMatricula.Location = new System.Drawing.Point(167, 173);
            this.TbMatricula.MaxLength = 15;
            this.TbMatricula.Name = "TbMatricula";
            this.TbMatricula.Size = new System.Drawing.Size(137, 22);
            this.TbMatricula.TabIndex = 9;
            // 
            // FrmAltaInfraccionVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbMatricula);
            this.Controls.Add(this.BtnLeeFechaActual);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAltaInfraccion);
            this.Controls.Add(this.LblVehiculo);
            this.Controls.Add(this.LblFechaHora);
            this.Controls.Add(this.LblInfraccion);
            this.Controls.Add(this.DtpFechaHora);
            this.Controls.Add(this.CbInfraccion);
            this.Name = "FrmAltaInfraccionVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir infracción por vehículo";
            this.Load += new System.EventHandler(this.FrmAltaInfraccionVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbInfraccion;
        private System.Windows.Forms.DateTimePicker DtpFechaHora;
        private System.Windows.Forms.Label LblInfraccion;
        private System.Windows.Forms.Label LblFechaHora;
        private System.Windows.Forms.Label LblVehiculo;
        private System.Windows.Forms.Button BtnAltaInfraccion;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnLeeFechaActual;
        private System.Windows.Forms.TextBox TbMatricula;
    }
}