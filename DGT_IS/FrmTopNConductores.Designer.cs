namespace DGT_IS
{
    partial class FrmTopNConductores
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.CbSeleccionaTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(394, 465);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(188, 75);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "&Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // CbSeleccionaTipo
            // 
            this.CbSeleccionaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSeleccionaTipo.FormattingEnabled = true;
            this.CbSeleccionaTipo.Items.AddRange(new object[] {
            "Conductores por puntos ascendente",
            "Conductores puntos descendente",
            "Con algún SEAT",
            "Con algún CITRÖEN"});
            this.CbSeleccionaTipo.Location = new System.Drawing.Point(50, 37);
            this.CbSeleccionaTipo.Name = "CbSeleccionaTipo";
            this.CbSeleccionaTipo.Size = new System.Drawing.Size(275, 24);
            this.CbSeleccionaTipo.TabIndex = 1;
            this.CbSeleccionaTipo.SelectedIndexChanged += new System.EventHandler(this.CbSeleccionaTipo_SelectedIndexChanged);
            // 
            // FrmTopNConductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 570);
            this.Controls.Add(this.CbSeleccionaTipo);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "FrmTopNConductores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Top N de conductores";
            this.Load += new System.EventHandler(this.FrmTopNConductores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.ComboBox CbSeleccionaTipo;
    }
}