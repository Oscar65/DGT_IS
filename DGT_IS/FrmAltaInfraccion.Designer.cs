namespace DGT_IS
{
    partial class FrmAltaInfraccion
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
            this.TbDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblPuntosDescontar = new System.Windows.Forms.Label();
            this.NudPuntosDescuento = new System.Windows.Forms.NumericUpDown();
            this.BtnAnadirInfraccion = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.TbIdentificador = new System.Windows.Forms.TextBox();
            this.LblIdentificador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudPuntosDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // TbDescripcion
            // 
            this.TbDescripcion.Location = new System.Drawing.Point(190, 75);
            this.TbDescripcion.MaxLength = 250;
            this.TbDescripcion.Multiline = true;
            this.TbDescripcion.Name = "TbDescripcion";
            this.TbDescripcion.Size = new System.Drawing.Size(241, 58);
            this.TbDescripcion.TabIndex = 1;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(24, 80);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "Descripción";
            // 
            // LblPuntosDescontar
            // 
            this.LblPuntosDescontar.AutoSize = true;
            this.LblPuntosDescontar.Location = new System.Drawing.Point(28, 158);
            this.LblPuntosDescontar.Name = "LblPuntosDescontar";
            this.LblPuntosDescontar.Size = new System.Drawing.Size(131, 17);
            this.LblPuntosDescontar.TabIndex = 3;
            this.LblPuntosDescontar.Text = "Puntos a descontar";
            // 
            // NudPuntosDescuento
            // 
            this.NudPuntosDescuento.Location = new System.Drawing.Point(190, 153);
            this.NudPuntosDescuento.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NudPuntosDescuento.Name = "NudPuntosDescuento";
            this.NudPuntosDescuento.Size = new System.Drawing.Size(46, 22);
            this.NudPuntosDescuento.TabIndex = 2;
            // 
            // BtnAnadirInfraccion
            // 
            this.BtnAnadirInfraccion.Location = new System.Drawing.Point(31, 209);
            this.BtnAnadirInfraccion.Name = "BtnAnadirInfraccion";
            this.BtnAnadirInfraccion.Size = new System.Drawing.Size(162, 57);
            this.BtnAnadirInfraccion.TabIndex = 3;
            this.BtnAnadirInfraccion.Text = "&Añadir infracción";
            this.BtnAnadirInfraccion.UseVisualStyleBackColor = true;
            this.BtnAnadirInfraccion.Click += new System.EventHandler(this.BtnAnadirInfraccion_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(247, 209);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(149, 57);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Text = "&Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TbIdentificador
            // 
            this.TbIdentificador.Location = new System.Drawing.Point(190, 28);
            this.TbIdentificador.MaxLength = 10;
            this.TbIdentificador.Name = "TbIdentificador";
            this.TbIdentificador.Size = new System.Drawing.Size(100, 22);
            this.TbIdentificador.TabIndex = 0;
            // 
            // LblIdentificador
            // 
            this.LblIdentificador.AutoSize = true;
            this.LblIdentificador.Location = new System.Drawing.Point(24, 31);
            this.LblIdentificador.Name = "LblIdentificador";
            this.LblIdentificador.Size = new System.Drawing.Size(85, 17);
            this.LblIdentificador.TabIndex = 7;
            this.LblIdentificador.Text = "Identificador";
            // 
            // FrmAltaInfraccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 311);
            this.Controls.Add(this.LblIdentificador);
            this.Controls.Add(this.TbIdentificador);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAnadirInfraccion);
            this.Controls.Add(this.NudPuntosDescuento);
            this.Controls.Add(this.LblPuntosDescontar);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.TbDescripcion);
            this.Name = "FrmAltaInfraccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Infracción";
            ((System.ComponentModel.ISupportInitialize)(this.NudPuntosDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblPuntosDescontar;
        private System.Windows.Forms.NumericUpDown NudPuntosDescuento;
        private System.Windows.Forms.Button BtnAnadirInfraccion;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.TextBox TbIdentificador;
        private System.Windows.Forms.Label LblIdentificador;
    }
}