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
    public partial class FrmAltaInfraccion : Form
    {
        public FrmAltaInfraccion()
        {
            InitializeComponent();
        }

        private void BtnAnadirInfraccion_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO infraccion(identificador, descripcion, puntos_descuenta) values (@iden, @des, @ptsdes)";
                SqlCommand cmd = new SqlCommand(sql, Globals.conn);
                cmd.Parameters.Add("@iden", SqlDbType.VarChar);
                cmd.Parameters["@iden"].Value = TbIdentificador.Text;
                cmd.Parameters.Add("@des", SqlDbType.VarChar);
                cmd.Parameters["@des"].Value = TbDescripcion.Text;
                cmd.Parameters.Add("@ptsdes", SqlDbType.TinyInt);
                cmd.Parameters["@ptsdes"].Value = this.NudPuntosDescuento.Value;
                cmd.ExecuteNonQuery();

                TbIdentificador.Text = "";
                TbDescripcion.Text = "";
                NudPuntosDescuento.Value = 0;
                TbIdentificador.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                                "ERROR al intentar añadir Infracción",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
