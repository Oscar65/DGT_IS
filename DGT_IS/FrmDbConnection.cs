/*
 * 
 * Modificado settings para que se puede editar la cadena de conexión.
 * 
 * NO USARLO EN PRODUCCIÓN.
 * 
 * Si no permite cambiar la candana de conexión hay que comentar la línea que la cambia:
 * 
 *      Properties.Settings.Default["DGTdbConnectionString"] = TbStingConexion.Text;
 *  
 *  y modificarla en Solution Explorer/Settings.settings
 * 
 */

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
    public partial class FrmDbConnection : Form
    {
        public FrmDbConnection()
        {
            InitializeComponent();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.conn = new SqlConnection(TbStingConexion.Text);
                Globals.conn.Open();
                // Comentar la línea de abajo si da error.
                Properties.Settings.Default["DGTdbConnectionString"] = TbStingConexion.Text;
                Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "ERROR conectandome con la base de datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    System.Environment.Exit(1);
                }
            }
        }

        private void FrmDbConnection_Load(object sender, EventArgs e)
        {
            CbCadenaConexionDefecto.SelectedIndex = 0;
        }

        private void CbCadenaConexionDefecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbCadenaConexionDefecto.SelectedIndex)
            {
                // SQL Server EXPRESS
                case 0:
                    TbStingConexion.Text = "Data source=.\\SQLEXPRESS; initial catalog=DGTdb; Integrated Security=SSPI;";
                    break;

                // SQL Server
                case 1:
                    TbStingConexion.Text = "Data source=.(local); initial catalog=DGTdb; Integrated Security=SSPI;";
                    break;

                default:
                    break;
            }
        }
    }
}
