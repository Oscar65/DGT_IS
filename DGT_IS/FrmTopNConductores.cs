
/*
 * 
 * Entiendo que es una pantalla para sacar diferentes informes de conductores.
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
    public partial class FrmTopNConductores : Form
    {
        private DataGridView DataGridView = new DataGridView();
        private BindingSource BindingSource = new BindingSource();

        public FrmTopNConductores()
        {
            InitializeComponent();

            DataGridView.Top = 100;
            DataGridView.Left = 10;
            DataGridView.Width = this.Width - 40;
            DataGridView.Height = 350;
            this.Controls.Add(DataGridView);
            DataGridView.ReadOnly = true;
            DataGridView.AllowUserToAddRows = false;
        }

        private void FrmTopNConductores_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = BindingSource;

            try
            {
                DataSet data = new DataSet
                {
                    Locale = System.Globalization.CultureInfo.InvariantCulture
                };

                SqlDataAdapter DataAdapter = new
                    SqlDataAdapter("SELECT * from conductor", Globals.conn);
                DataAdapter.Fill(data, "conductor");

                BindingSource.DataSource = data;
                BindingSource.DataMember = "conductor";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            DataGridView.AutoResizeColumns();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CbSeleccionaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet data = new DataSet
                {
                    Locale = System.Globalization.CultureInfo.InvariantCulture
                };

                string sql;

                
                switch (CbSeleccionaTipo.SelectedIndex)
                {
                    // Conductores por Nombre y apellidos ascendente
                    case 0:
                        sql = "SELECT * FROM conductor ORDER BY puntos ASC";
                        break;

                    // Conductores por Nombre y apellidos descendente
                    case 1:
                        sql = "SELECT * FROM conductor ORDER BY puntos DESC";
                        break;

                    // Algún SEAT
                    case 2:
                        sql = "SELECT * FROM conductor INNER JOIN vehiculo ON conductor.conductor_id = " +
                              "vehiculo.conductor_id WHERE vehiculo.marca LIKE '%SEAT%'";
                        break;

                    // Algún CITRÖEN
                    case 3:
                        sql = "SELECT * FROM conductor INNER JOIN vehiculo ON conductor.conductor_id = " +
                              "vehiculo.conductor_id WHERE vehiculo.marca LIKE '%CITRÖEN%'";
                        break;

                    default:
                        sql = "SELECT * FROM vehiculo";
                        break;
                }

                SqlDataAdapter DataAdapter = new SqlDataAdapter(sql, Globals.conn);
                DataAdapter.Fill(data, "conductor");

                BindingSource.DataSource = data;
                BindingSource.DataMember = "conductor";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
