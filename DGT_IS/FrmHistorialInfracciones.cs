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
    public partial class FrmHistorialInfraccionesConductor : Form
    {
        private DataGridView masterDataGridView = new DataGridView();
        private BindingSource masterBindingSource = new BindingSource();
        private DataGridView detailsDataGridView = new DataGridView();
        private BindingSource detailsBindingSource = new BindingSource();

        public FrmHistorialInfraccionesConductor()
        {
            InitializeComponent();

            masterDataGridView.Dock = DockStyle.Fill;
            detailsDataGridView.Dock = DockStyle.Fill;

            SplitContainer splitContainer1 = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Horizontal
            };
            splitContainer1.Panel1.Controls.Add(masterDataGridView);
            splitContainer1.Panel2.Controls.Add(detailsDataGridView);

            this.Controls.Add(splitContainer1);
            this.Load += new System.EventHandler(FrmHistorialInfraccionesConductor_Load);

            masterDataGridView.ReadOnly = true;
            masterDataGridView.AllowUserToAddRows = false;
            detailsDataGridView.ReadOnly = true;
            detailsDataGridView.AllowUserToAddRows = false;
        }

        private void FrmHistorialInfraccionesConductor_Load(object sender, EventArgs e)
        {
            masterDataGridView.DataSource = masterBindingSource;
            detailsDataGridView.DataSource = detailsBindingSource;

            try
            {
                DataSet data = new DataSet
                {
                    Locale = System.Globalization.CultureInfo.InvariantCulture
                };

                SqlDataAdapter masterDataAdapter = new
                    SqlDataAdapter("SELECT * FROM conductor", Globals.conn);
                masterDataAdapter.Fill(data, "conductor");

                SqlDataAdapter detailsDataAdapter = new
                    SqlDataAdapter("SELECT infraccion_vehiculo.conductor_id, CONVERT(VARCHAR(130), " +
                    "infraccion.descripcion) as 'Descripcion infracción', infraccion.puntos_descuenta as" +
                    "'Puntos descontados', infraccion_vehiculo.fecha FROM infraccion_vehiculo INNER " +
                    "JOIN infraccion on infraccion_vehiculo.infraccion_id = infraccion.infraccion_id", Globals.conn);
                detailsDataAdapter.Fill(data, "infraccion_vehiculo");

                DataRelation relation = new DataRelation("InfraccionesPorVehiculoRelacion",
                    data.Tables["conductor"].Columns["conductor_id"],
                    data.Tables["infraccion_vehiculo"].Columns["conductor_id"]);
                data.Relations.Add(relation);

                masterBindingSource.DataSource = data;
                masterBindingSource.DataMember = "conductor";

                detailsBindingSource.DataSource = masterBindingSource;
                detailsBindingSource.DataMember = "InfraccionesPorVehiculoRelacion";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            masterDataGridView.AutoResizeColumns();
            detailsDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}