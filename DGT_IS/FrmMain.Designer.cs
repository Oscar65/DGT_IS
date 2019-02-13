namespace DGT_IS
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnAltaConductor = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnAltaVehiculo = new System.Windows.Forms.Button();
            this.BtnAltaInfraccion = new System.Windows.Forms.Button();
            this.BtnAltaInfraccionVehiculo = new System.Windows.Forms.Button();
            this.BtnHistorialInfraccionesConductor = new System.Windows.Forms.Button();
            this.Btn5TiposInfraccionMasHabituales = new System.Windows.Forms.Button();
            this.BtnTopNConductores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAltaConductor
            // 
            resources.ApplyResources(this.BtnAltaConductor, "BtnAltaConductor");
            this.BtnAltaConductor.Name = "BtnAltaConductor";
            this.BtnAltaConductor.UseVisualStyleBackColor = true;
            this.BtnAltaConductor.Click += new System.EventHandler(this.BtnAltaConductor_Click);
            // 
            // BtnCerrar
            // 
            resources.ApplyResources(this.BtnCerrar, "BtnCerrar");
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnAltaVehiculo
            // 
            resources.ApplyResources(this.BtnAltaVehiculo, "BtnAltaVehiculo");
            this.BtnAltaVehiculo.Name = "BtnAltaVehiculo";
            this.BtnAltaVehiculo.UseVisualStyleBackColor = true;
            this.BtnAltaVehiculo.Click += new System.EventHandler(this.BtnAltaVehiculo_Click);
            // 
            // BtnAltaInfraccion
            // 
            resources.ApplyResources(this.BtnAltaInfraccion, "BtnAltaInfraccion");
            this.BtnAltaInfraccion.Name = "BtnAltaInfraccion";
            this.BtnAltaInfraccion.UseVisualStyleBackColor = true;
            this.BtnAltaInfraccion.Click += new System.EventHandler(this.BtnAltaInfraccion_Click);
            // 
            // BtnAltaInfraccionVehiculo
            // 
            resources.ApplyResources(this.BtnAltaInfraccionVehiculo, "BtnAltaInfraccionVehiculo");
            this.BtnAltaInfraccionVehiculo.Name = "BtnAltaInfraccionVehiculo";
            this.BtnAltaInfraccionVehiculo.UseVisualStyleBackColor = true;
            this.BtnAltaInfraccionVehiculo.Click += new System.EventHandler(this.BtnAltaInfraccionVehiculo_Click);
            // 
            // BtnHistorialInfraccionesConductor
            // 
            resources.ApplyResources(this.BtnHistorialInfraccionesConductor, "BtnHistorialInfraccionesConductor");
            this.BtnHistorialInfraccionesConductor.Name = "BtnHistorialInfraccionesConductor";
            this.BtnHistorialInfraccionesConductor.UseVisualStyleBackColor = true;
            this.BtnHistorialInfraccionesConductor.Click += new System.EventHandler(this.BtnHistorialInfraccionesConductor_Click);
            // 
            // Btn5TiposInfraccionMasHabituales
            // 
            resources.ApplyResources(this.Btn5TiposInfraccionMasHabituales, "Btn5TiposInfraccionMasHabituales");
            this.Btn5TiposInfraccionMasHabituales.Name = "Btn5TiposInfraccionMasHabituales";
            this.Btn5TiposInfraccionMasHabituales.UseVisualStyleBackColor = true;
            this.Btn5TiposInfraccionMasHabituales.Click += new System.EventHandler(this.Btn5TiposInfraccionMasHabituales_Click);
            // 
            // BtnTopNConductores
            // 
            resources.ApplyResources(this.BtnTopNConductores, "BtnTopNConductores");
            this.BtnTopNConductores.Name = "BtnTopNConductores";
            this.BtnTopNConductores.UseVisualStyleBackColor = true;
            this.BtnTopNConductores.Click += new System.EventHandler(this.BtnTopNConductores_Click);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnTopNConductores);
            this.Controls.Add(this.Btn5TiposInfraccionMasHabituales);
            this.Controls.Add(this.BtnHistorialInfraccionesConductor);
            this.Controls.Add(this.BtnAltaInfraccionVehiculo);
            this.Controls.Add(this.BtnAltaInfraccion);
            this.Controls.Add(this.BtnAltaVehiculo);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnAltaConductor);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAltaConductor;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnAltaVehiculo;
        private System.Windows.Forms.Button BtnAltaInfraccion;
        private System.Windows.Forms.Button BtnAltaInfraccionVehiculo;
        private System.Windows.Forms.Button BtnHistorialInfraccionesConductor;
        private System.Windows.Forms.Button Btn5TiposInfraccionMasHabituales;
        private System.Windows.Forms.Button BtnTopNConductores;
    }
}

