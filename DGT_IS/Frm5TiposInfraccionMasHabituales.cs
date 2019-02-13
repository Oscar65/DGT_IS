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
    public partial class Frm5TiposInformacionMasHabituales : Form
    {
        private DataGridView DataGridView = new DataGridView();
        private BindingSource BindingSource = new BindingSource();

        public Frm5TiposInformacionMasHabituales()
        {
            InitializeComponent();

            DataGridView.Dock = DockStyle.Fill;
            this.Controls.Add(DataGridView);
            this.Load += new System.EventHandler(Frm5TiposInformacionMasHabituales_Load);

            DataGridView.ReadOnly = true;
            DataGridView.AllowUserToAddRows = false;
        }

        private void Frm5TiposInformacionMasHabituales_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = BindingSource;

            try
            {
                DataSet data = new DataSet
                {
                    Locale = System.Globalization.CultureInfo.InvariantCulture
                };

                SqlDataAdapter DataAdapter = new
                    SqlDataAdapter("SELECT TOP 5 COUNT(infraccion_vehiculo.infraccion_id) as " +
                    "'Total de infracciones', infraccion_vehiculo.infraccion_id, CONVERT(VARCHAR(160), " +
                    "(SELECT infraccion.descripcion FROM infraccion WHERE infraccion.infraccion_id = " +
                    "infraccion_vehiculo.infraccion_id)) as Descripcion FROM infraccion_vehiculo GROUP BY " +
                    "infraccion_vehiculo.infraccion_id", Globals.conn);
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
    }
}
