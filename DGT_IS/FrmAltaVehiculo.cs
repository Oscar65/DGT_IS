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
    public partial class FrmAltaVehiculo : Form
    {
        private List<int> Lconductor_id;

        public FrmAltaVehiculo()
        {
            InitializeComponent();
            Lconductor_id = new List<int>();
        }

        private void FrmAltaVehiculo_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT conductor_id, (nombre + ' ' + apellidos) as nombrecompleto FROM conductor ORDER BY nombre, apellidos", Globals.conn);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Lconductor_id.Add(reader.GetInt32(0));
                    CbConductorHabitual.Items.Add(reader.GetString(1));
                    LbSeleccionaConductores.Items.Add(reader.GetString(1));
                }
            }
            else
            {
                // No se hace nada
            }
            reader.Close();
        }

        private void BtnAnadirVehiculo_Click(object sender, EventArgs e)
        {
            bool bEncontrado = false;

            if (this.TbMatricula.Text == "")
            {
                MessageBox.Show("La matrícula no puede estar vacía.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (CbConductorHabitual.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un conductor habitual.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < CbConductorHabitual.Items.Count; i++)
            {
                if (LbSeleccionaConductores.SelectedIndices.Contains(i))
                {
                    if (CbConductorHabitual.SelectedIndex == i)
                    {
                        MessageBox.Show("El conductor habitual no puede estar en la lista de conductores habituales.",
                                        "Aviso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        bEncontrado = true;
                        break;
                    }
                }
            }

            if (bEncontrado) return;

            SqlTransaction transaction;
            transaction = Globals.conn.BeginTransaction("AltaVehiculos");

            try
            {
                SqlCommand cmd = Globals.conn.CreateCommand();

                /*
                 * 
                 * Comprueba que el conductor habitual es conductor habitual de menos de diez vehículos.
                 * 
                 */
                cmd.Connection = Globals.conn;
                cmd.Transaction = transaction;
                cmd.CommandText = "SELECT (SELECT COUNT(*) FROM vehiculo WHERE conductor_id = @count_veh)" +
                    " + (SELECT COUNT(*) FROM vehiculo_conductor WHERE conductor_id = @count_veh_con) as SUMA";
                cmd.Parameters.Add("@count_veh", SqlDbType.Int);
                cmd.Parameters["@count_veh"].Value = Lconductor_id[CbConductorHabitual.SelectedIndex];
                cmd.Parameters.Add("@count_veh_con", SqlDbType.Int);
                cmd.Parameters["@count_veh_con"].Value = Lconductor_id[CbConductorHabitual.SelectedIndex];

                int iCount_vehiculo = (int)cmd.ExecuteScalar();

                if (iCount_vehiculo >= 10)
                {
                    MessageBox.Show($"{CbConductorHabitual.Items[CbConductorHabitual.SelectedIndex].ToString()}" +
                                    " ya es conductor habitual de 10 vehículos.",
                                    "ERROR: Máximo 10 vehiculos por conductor",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    transaction.Rollback();
                    return;
                }

                /* 
                 * 
                 * Comprueba el número de vehiculos de los que es conductor habitual por cada uno
                 * 
                 * de los conductores seleccionados.
                 * 
                 */
                for (int i = 0; i < LbSeleccionaConductores.Items.Count; i++)
                {
                    if (LbSeleccionaConductores.SelectedIndices.Contains(i))
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT (SELECT COUNT(*) FROM vehiculo WHERE conductor_id = @count_veh)" +
                        " + (SELECT COUNT(*) FROM vehiculo_conductor WHERE conductor_id = @count_veh_con) as SUMA";
                        cmd.Parameters.Add("@count_veh", SqlDbType.Int);
                        cmd.Parameters["@count_veh"].Value = Convert.ToInt32(Lconductor_id[i].ToString());
                        cmd.Parameters.Add("@count_veh_con", SqlDbType.Int);
                        cmd.Parameters["@count_veh_con"].Value = Convert.ToInt32(Lconductor_id[i].ToString());

                        int iCount_vehiculo_conductor = (int)cmd.ExecuteScalar();

                        if ((iCount_vehiculo_conductor) >= 10)
                        {
                            MessageBox.Show($"{LbSeleccionaConductores.Items[i].ToString()} ya es conductor" +
                                            " habitual de 10 vehículos.",
                                            "ERROR: Máximo 10 vehiculos por conductor",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }
                    }
                }

                /*
                 * 
                 * Inserta el vehiculo.
                 * 
                 */
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO vehiculo (matricula, marca, modelo, conductor_id) VALUES" +
                    " (@matricula, @marca, @modelo, @conductor_id); SELECT CAST(SCOPE_IDENTITY() AS INT);";
                cmd.Parameters.Add("@matricula", SqlDbType.VarChar);
                cmd.Parameters["@matricula"].Value = TbMatricula.Text;
                cmd.Parameters.Add("@marca", SqlDbType.VarChar);
                cmd.Parameters["@marca"].Value = TbMarca.Text;
                cmd.Parameters.Add("@modelo", SqlDbType.VarChar);
                cmd.Parameters["@modelo"].Value = TbModelo.Text;
                cmd.Parameters.Add("@conductor_id", SqlDbType.Int);
                cmd.Parameters["@conductor_id"].Value = Lconductor_id[CbConductorHabitual.SelectedIndex];
                string svehiculo_id = cmd.ExecuteScalar().ToString();
                
                for (int i=0; i < LbSeleccionaConductores.Items.Count; i++)
                {
                    if (LbSeleccionaConductores.SelectedIndices.Contains(i)) {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "INSERT INTO vehiculo_conductor (vehiculo_id, conductor_id)" +
                            " VALUES (@vehiculo_id, @conductor_id)";
                        cmd.Parameters.Add("@vehiculo_id", SqlDbType.Int);
                        cmd.Parameters["@vehiculo_id"].Value = Convert.ToInt32(svehiculo_id);
                        cmd.Parameters.Add("@conductor_id", SqlDbType.Int);
                        cmd.Parameters["@conductor_id"].Value = Convert.ToInt32(Lconductor_id[i].ToString());
                        cmd.ExecuteNonQuery();
                    }
                }
                
                transaction.Commit();

                /*
                 * 
                 * Se inicializan todos los campos y se pasa el foco al primero.
                 * 
                 */
                TbMatricula.Text = "";
                TbMarca.Text = "";
                TbModelo.Text = "";
                CbConductorHabitual.Text = "";
                CbConductorHabitual.SelectedIndex = -1;
                LbSeleccionaConductores.SelectedItems.Clear();
                TbMatricula.Select();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"{ex.Message}",
                                "ERROR al intentar añadir el vehículo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*
         * 
         * Procedimiento que añade los conductores habituales en la tabla vehiculo_conductor de este vehículo a
         * 
         * la ListView
         * 
         */
         private void AnadeConductoresHabitualesLvConductoresHabituales()
         {
            // No empezado porque ya me deja arrastrar data source a un formulario.
         }
    }
}
