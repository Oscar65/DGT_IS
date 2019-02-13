namespace DGT_IS
{
    partial class FrmAltaConductor
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
            this.TbDNI = new System.Windows.Forms.TextBox();
            this.LblDNI = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblPuntos = new System.Windows.Forms.Label();
            this.TbApellidos = new System.Windows.Forms.TextBox();
            this.MudPuntos = new System.Windows.Forms.NumericUpDown();
            this.BtnAnadirConductor = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MudPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // TbDNI
            // 
            this.TbDNI.Location = new System.Drawing.Point(123, 58);
            this.TbDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbDNI.MaxLength = 10;
            this.TbDNI.Name = "TbDNI";
            this.TbDNI.Size = new System.Drawing.Size(116, 22);
            this.TbDNI.TabIndex = 0;
            // 
            // LblDNI
            // 
            this.LblDNI.AutoSize = true;
            this.LblDNI.Location = new System.Drawing.Point(32, 66);
            this.LblDNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDNI.Name = "LblDNI";
            this.LblDNI.Size = new System.Drawing.Size(31, 17);
            this.LblDNI.TabIndex = 1;
            this.LblDNI.Text = "DNI";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(32, 118);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(58, 17);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre";
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(123, 114);
            this.TbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbNombre.MaxLength = 30;
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(217, 22);
            this.TbNombre.TabIndex = 1;
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Location = new System.Drawing.Point(32, 169);
            this.LblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(65, 17);
            this.LblApellidos.TabIndex = 4;
            this.LblApellidos.Text = "Apellidos";
            // 
            // LblPuntos
            // 
            this.LblPuntos.AutoSize = true;
            this.LblPuntos.Location = new System.Drawing.Point(32, 224);
            this.LblPuntos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPuntos.Name = "LblPuntos";
            this.LblPuntos.Size = new System.Drawing.Size(52, 17);
            this.LblPuntos.TabIndex = 5;
            this.LblPuntos.Text = "Puntos";
            // 
            // TbApellidos
            // 
            this.TbApellidos.Location = new System.Drawing.Point(123, 165);
            this.TbApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbApellidos.MaxLength = 30;
            this.TbApellidos.Name = "TbApellidos";
            this.TbApellidos.Size = new System.Drawing.Size(217, 22);
            this.TbApellidos.TabIndex = 2;
            // 
            // MudPuntos
            // 
            this.MudPuntos.Location = new System.Drawing.Point(123, 222);
            this.MudPuntos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MudPuntos.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.MudPuntos.Name = "MudPuntos";
            this.MudPuntos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MudPuntos.Size = new System.Drawing.Size(51, 22);
            this.MudPuntos.TabIndex = 3;
            this.MudPuntos.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // BtnAnadirConductor
            // 
            this.BtnAnadirConductor.Location = new System.Drawing.Point(36, 311);
            this.BtnAnadirConductor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAnadirConductor.Name = "BtnAnadirConductor";
            this.BtnAnadirConductor.Size = new System.Drawing.Size(191, 59);
            this.BtnAnadirConductor.TabIndex = 4;
            this.BtnAnadirConductor.Text = "&Añadir Conductor";
            this.BtnAnadirConductor.UseVisualStyleBackColor = true;
            this.BtnAnadirConductor.Click += new System.EventHandler(this.BtnAnadirConductor_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(353, 315);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(204, 55);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "&Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmAltaConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 425);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAnadirConductor);
            this.Controls.Add(this.MudPuntos);
            this.Controls.Add(this.TbApellidos);
            this.Controls.Add(this.LblPuntos);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblDNI);
            this.Controls.Add(this.TbDNI);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAltaConductor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Conductor";
            ((System.ComponentModel.ISupportInitialize)(this.MudPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbDNI;
        private System.Windows.Forms.Label LblDNI;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblPuntos;
        private System.Windows.Forms.TextBox TbApellidos;
        private System.Windows.Forms.NumericUpDown MudPuntos;
        private System.Windows.Forms.Button BtnAnadirConductor;
        private System.Windows.Forms.Button BtnCerrar;
    }
}