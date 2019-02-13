using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DGT_IS
{
    /*
     * Este formulario se usa par añadir conductores al la base de datos
     * El tabindex esta configurado para que se pueda mover mediante la tecla tab
     * 
     */
    public partial class FrmAltaConductor : Form
    {
        public FrmAltaConductor()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAnadirConductor_Click(object sender, EventArgs e)
        {
            if (this.TbDNI.Text == "")
            {
                MessageBox.Show("El DNI no puede estar vacío.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = "INSERT INTO conductor(dni, nombre, apellidos, puntos) values (@dni, @nombre, @apellidos, @puntos)";
                SqlCommand cmd = new SqlCommand(sql, Globals.conn);
                cmd.Parameters.Add("@dni", SqlDbType.VarChar);
                cmd.Parameters["@dni"].Value = this.TbDNI.Text;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = this.TbNombre.Text;
                cmd.Parameters.Add("@apellidos", SqlDbType.VarChar);
                cmd.Parameters["@apellidos"].Value = this.TbApellidos.Text;
                cmd.Parameters.Add("@puntos", SqlDbType.Int);
                cmd.Parameters["@puntos"].Value = this.MudPuntos.Value;
                cmd.ExecuteNonQuery();
                TbDNI.Text = "";
                TbNombre.Text = "";
                TbApellidos.Text = "";
                MudPuntos.Value = 15;
                TbDNI.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                                "ERROR al intentar añadir conductor",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
