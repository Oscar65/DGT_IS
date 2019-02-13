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
    public partial class FrmAltaInfraccionVehiculo : Form
    {
        private List<int> Linfracciones_id;
        private List<int> Lvehiculos_id;

        public FrmAltaInfraccionVehiculo()
        {
            InitializeComponent();
            DtpFechaHora.Value = DateTime.Now;
            Linfracciones_id = new List<int>();
            Lvehiculos_id = new List<int>();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAltaInfraccion_Click(object sender, EventArgs e)
        {
            if (CbInfraccion.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una infración.",
                                "AVISO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return;
            }
            /*
             * 
             * Usamos transacción porque si da un error en medio de la grabación quedarán datos inconsistentes
             * 
             * en la base de datos.
             * 
             */
            SqlTransaction transaction;
            transaction = Globals.conn.BeginTransaction("AltaInfraccionVehiculo");

            try
            {
                /*
                 * 
                 * Lee el conductor habitual y el id del vehículo.
                 * 
                 */
                int iveh_id = -1, icon_id = -1;

                string sql = "SELECT vehiculo_id, conductor_id FROM vehiculo WHERE matricula = @mat";
                SqlCommand cmd = new SqlCommand(sql, Globals.conn)
                {
                    Connection = Globals.conn,
                    Transaction = transaction
                };
                cmd.Parameters.Add("@mat", SqlDbType.NVarChar);
                cmd.Parameters["@mat"].Value = TbMatricula.Text;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        iveh_id = reader.GetInt32(0);
                        icon_id = reader.GetInt32(1);
                    }
                }

                reader.Close();

                if (iveh_id == -1 || icon_id == -1)
                {
                    transaction.Rollback();
                    MessageBox.Show("No se encuentra la matrícula en la base de datos",
                                    "ERROR al intentar añadir infracción por vehículo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                    return;
                }

                /*
                 * 
                 * Inserta la infracción el la base de datos.
                 *
                 */
                cmd.Parameters.Clear();
                sql = "INSERT INTO infraccion_vehiculo(infraccion_id, fecha, conductor_id, vehiculo_id) " +
                      "values (@inf, @fec, @con, @veh)";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@inf", SqlDbType.Int);
                cmd.Parameters["@inf"].Value = Linfracciones_id[CbInfraccion.SelectedIndex];
                cmd.Parameters.Add("@fec", SqlDbType.DateTime);
                cmd.Parameters["@fec"].Value = DtpFechaHora.Value;
                cmd.Parameters.Add("@con", SqlDbType.Int);
                cmd.Parameters["@con"].Value = icon_id;
                cmd.Parameters.Add("@veh", SqlDbType.Int);
                cmd.Parameters["@veh"].Value = iveh_id;
                cmd.ExecuteNonQuery();

                /*
                 * 
                 * Actualiza los puntos del conductor.
                 *
                 */
                cmd.Parameters.Clear();
                sql = "UPDATE conductor SET puntos = puntos - (SELECT puntos_descuenta FROM infraccion WHERE " +
                    "infraccion_id = @inf) WHERE conductor_id = @con";
                cmd.CommandText = sql;
                cmd.Parameters.Add("@inf", SqlDbType.Int);
                cmd.Parameters["@inf"].Value = Linfracciones_id[CbInfraccion.SelectedIndex];
                cmd.Parameters.Add("@con", SqlDbType.Int);
                cmd.Parameters["@con"].Value = icon_id;
                cmd.ExecuteNonQuery();

                transaction.Commit();

                /*
                 * 
                 * Se inicializan los campos y se va al primer campo
                 * 
                 */
                CbInfraccion.SelectedIndex = -1;
                DtpFechaHora.Value = DateTime.Now;
                TbMatricula.Text = "";                
                CbInfraccion.Select();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"{ex.Message}",
                                "ERROR al intentar añadir infracción por vehículo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void FrmAltaInfraccionVehiculo_Load(object sender, EventArgs e)
        {
            /*
             * 
             * Carga infraccion_id en una lista e identificador más descripción en el ComboBox de la pantalla.
             * 
             */
            SqlCommand command = new SqlCommand("SELECT infraccion_id, identificador, descripcion FROM infraccion " +
                                                "ORDER BY identificador", Globals.conn);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Linfracciones_id.Add(reader.GetInt32(0));
                    CbInfraccion.Items.Add(reader.GetString(1).Trim() + " - " + reader.GetString(2).Trim());
                }
            }

            reader.Close();

        }

        private void BtnLeeFechaActual_Click(object sender, EventArgs e)
        {
            DtpFechaHora.Value = DateTime.Now;
        }
    }
}
