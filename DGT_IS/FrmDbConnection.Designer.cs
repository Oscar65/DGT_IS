namespace DGT_IS
{
    partial class FrmDbConnection
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
            this.BtnConectar = new System.Windows.Forms.Button();
            this.TbStingConexion = new System.Windows.Forms.TextBox();
            this.LblStringConexion = new System.Windows.Forms.Label();
            this.CbCadenaConexionDefecto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(367, 209);
            this.BtnConectar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(191, 76);
            this.BtnConectar.TabIndex = 0;
            this.BtnConectar.Text = "&Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // TbStingConexion
            // 
            this.TbStingConexion.Location = new System.Drawing.Point(179, 38);
            this.TbStingConexion.Margin = new System.Windows.Forms.Padding(4);
            this.TbStingConexion.Multiline = true;
            this.TbStingConexion.Name = "TbStingConexion";
            this.TbStingConexion.Size = new System.Drawing.Size(477, 124);
            this.TbStingConexion.TabIndex = 1;
            // 
            // LblStringConexion
            // 
            this.LblStringConexion.AutoSize = true;
            this.LblStringConexion.Location = new System.Drawing.Point(16, 42);
            this.LblStringConexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStringConexion.Name = "LblStringConexion";
            this.LblStringConexion.Size = new System.Drawing.Size(137, 17);
            this.LblStringConexion.TabIndex = 2;
            this.LblStringConexion.Text = "Cadena de conexión";
            // 
            // CbCadenaConexionDefecto
            // 
            this.CbCadenaConexionDefecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCadenaConexionDefecto.FormattingEnabled = true;
            this.CbCadenaConexionDefecto.Items.AddRange(new object[] {
            "SQL Server EXPRESS",
            "SQL Server"});
            this.CbCadenaConexionDefecto.Location = new System.Drawing.Point(675, 42);
            this.CbCadenaConexionDefecto.Name = "CbCadenaConexionDefecto";
            this.CbCadenaConexionDefecto.Size = new System.Drawing.Size(187, 24);
            this.CbCadenaConexionDefecto.TabIndex = 2;
            this.CbCadenaConexionDefecto.SelectedIndexChanged += new System.EventHandler(this.CbCadenaConexionDefecto_SelectedIndexChanged);
            // 
            // FrmDbConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 315);
            this.Controls.Add(this.CbCadenaConexionDefecto);
            this.Controls.Add(this.LblStringConexion);
            this.Controls.Add(this.TbStingConexion);
            this.Controls.Add(this.BtnConectar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDbConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión a la base de datos";
            this.Load += new System.EventHandler(this.FrmDbConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.TextBox TbStingConexion;
        private System.Windows.Forms.Label LblStringConexion;
        private System.Windows.Forms.ComboBox CbCadenaConexionDefecto;
    }
}