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
    public partial class FrmAltaVehiculo2 : Form
    {

        public FrmAltaVehiculo2()
        {
            InitializeComponent();
        }

        private void vehiculoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (conductor_idTextBox.Text == null)
            {
                MessageBox.Show($"{CbConductorHabitual.Text} tiene un id nulo. " +
                                "Por favor, compruebe que esta en la lista.",
                                "ERROR: conductor_id nulo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (CbConductorHabitual.FindStringExact(CbConductorHabitual.Text) == -1)
            {
                MessageBox.Show($"El conductor {CbConductorHabitual.Text} no esta en la base de datos. " +
                                "Por favor, seleccione un conductor que este en la lista.",
                                "ERROR: Conductor inválido.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            /*
             * 
             * Usamos transacción porque vamos a hacer dar de alta, borrar o modificar en diferentes tablas y
             * 
             * si se produce un error en mitad del proceso la base de datos se quedaría con datos inconsistentes.
             * 
             */
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
                cmd.Parameters["@count_veh"].Value = conductor_idTextBox.Text;
                cmd.Parameters.Add("@count_veh_con", SqlDbType.Int);
                cmd.Parameters["@count_veh_con"].Value = Convert.ToInt32(conductor_idTextBox.Text);

                int iCount_vehiculo = (int)cmd.ExecuteScalar();

                string sConductorAnterior = "";
                if (iCount_vehiculo >= 10)
                {
                    /*
                     * 
                     * Lee el conductor de este vehículo en la base de datos porque se puede dar el caso de que
                     * 
                     * otro usuario cambie el registro mientras se esta editando.
                     * 
                     */
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT conductor_id FROM vehiculo WHERE vehiculo_id = @veh_id";
                    cmd.Parameters.Add("@veh_id", SqlDbType.Int);
                    cmd.Parameters["@veh_id"].Value = Convert.ToInt32(vehiculo_idTextBox.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    try
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                sConductorAnterior = reader.GetInt32(0).ToString();
                            }
                        }

                        reader.Close();
                    }
                    catch(Exception ex)
                    {
                        // Hay que cerrar reader si occurre una excepción y está abierto.
                        reader.Close();
                        throw new Exception(ex.Message);
                    }

                    if (sConductorAnterior != conductor_idTextBox.Text)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"{CbConductorHabitual.Text}" +
                                        " ya es conductor habitual de 10 vehículos.",
                                        "ERROR: Máximo 10 vehiculos por conductor",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                }

                /* 
                 * 
                 * Comprueba el número de vehiculos de cada conductor habitual de la list view
                 * 
                 */
                foreach (ListViewItem lvi in LvConductoresHabituales.Items)
                {

                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT (SELECT COUNT(*) FROM vehiculo WHERE conductor_id = @count_veh)" +
                    " + (SELECT COUNT(*) FROM vehiculo_conductor WHERE conductor_id = @count_veh_con) as SUMA";
                    cmd.Parameters.Add("@count_veh", SqlDbType.Int);
                    cmd.Parameters["@count_veh"].Value = Convert.ToInt32(lvi.Text);
                    cmd.Parameters.Add("@count_veh_con", SqlDbType.Int);
                    cmd.Parameters["@count_veh_con"].Value = Convert.ToInt32(lvi.Text);

                    int iCount_vehiculo_conductor = (int)cmd.ExecuteScalar();

                    if ((iCount_vehiculo_conductor) >= 10)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"{lvi.SubItems[1].Text} ya es conductor" +
                                        " habitual de 10 vehículos.",
                                        "ERROR: Máximo 10 vehiculos por conductor",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                }

                /*
                 * 
                 * Borro la lista de conductores añadidos en la list view
                 * 
                 */
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT COUNT(*) FROM vehiculo_conductor WHERE vehiculo_id = @veh_id";
                cmd.Parameters.Add("@veh_id", SqlDbType.Int);
                cmd.Parameters["@veh_id"].Value = Convert.ToInt32(vehiculo_idTextBox.Text);

                int iCount_vehiculo_conductor_vehiculo = (int)cmd.ExecuteScalar();

                if (iCount_vehiculo_conductor_vehiculo > 0)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "DELETE FROM vehiculo_conductor WHERE vehiculo_id = @veh_id";
                    cmd.Parameters.Add("@veh_id", SqlDbType.Int);
                    cmd.Parameters["@veh_id"].Value = Convert.ToInt32(vehiculo_idTextBox.Text);

                    int iCount_vehiculo_conductor_vehiculo_borrados =  (int)cmd.ExecuteNonQuery();
                    
                    if (iCount_vehiculo_conductor_vehiculo != iCount_vehiculo_conductor_vehiculo_borrados)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Solo han borrado {iCount_vehiculo_conductor_vehiculo_borrados} " +
                                        "conductores habituales de {iCount_vehiculo_conductor_vehiculo}",
                                        "ERROR",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                }


                this.Validate();
                this.vehiculoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dGTdbDataSet);

                /*
                 * 
                 * Ahora añade los conductores habituales de la list view
                 * 
                 */

                foreach (ListViewItem lvi in LvConductoresHabituales.Items)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO vehiculo_conductor (vehiculo_id, conductor_id)" +
                        " VALUES (@vehiculo_id, @conductor_id)";
                    cmd.Parameters.Add("@vehiculo_id", SqlDbType.Int);
                    cmd.Parameters["@vehiculo_id"].Value = Convert.ToInt32(vehiculo_idTextBox.Text);
                    cmd.Parameters.Add("@conductor_id", SqlDbType.Int);
                    cmd.Parameters["@conductor_id"].Value = Convert.ToInt32(lvi.SubItems[0].Text);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                MessageBox.Show(ex.Message,
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void FrmAltaVehiculo2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dGTdbDataSet.vehiculo_conductoreshabituales' table. You can move, or remove it, as needed.
            this.vehiculo_conductoreshabitualesTableAdapter.Fill(this.dGTdbDataSet.vehiculo_conductoreshabituales);
            // TODO: This line of code loads data into the 'dGTdbDataSet1.conductor' table. You can move, or remove it, as needed.
            this.conductorTableAdapter1.FillBy(this.dGTdbDataSet1.conductor);
            // TODO: This line of code loads data into the 'dGTdbDataSet.conductor' table. You can move, or remove it, as needed.
            this.conductorTableAdapter.FillBy(this.dGTdbDataSet.conductor);
            // TODO: This line of code loads data into the 'dGTdbDataSet.vehiculo' table. You can move, or remove it, as needed.
            this.vehiculoTableAdapter.Fill(this.dGTdbDataSet.vehiculo);

            /*
             * 
             * Enlaza las propiedades conductor_id y nombreapellidos de ComboBox CbConductorHabitual con el
             * 
             * dataset dGTdbDataSet.conductor y actualiza los campos bidireccionalmente con conductor_id de
             * 
             * vehiculoBindingSource.
             * 
             */
            CbConductorHabitual.DataSource = this.dGTdbDataSet.conductor;
            CbConductorHabitual.DisplayMember = "nombreapellidos";
            CbConductorHabitual.ValueMember = "conductor_id";
            CbConductorHabitual.DataBindings.Add("SelectedValue", vehiculoBindingSource, "conductor_id", true,
                DataSourceUpdateMode.OnPropertyChanged);

            /*
             * 
             * Enlaza las propiedades conductor_id y nombreapellidos de ComboBox CbConductoresHabituales con el
             * 
             * dataset dGTdbDataSet1.conductor.
             * 
             */
            CbConductoresHabituales.DataSource = this.dGTdbDataSet1.conductor;
            CbConductoresHabituales.DisplayMember = "nombreapellidos";
            CbConductoresHabituales.ValueMember = "conductor_id";

            RellenaLvConductoresHabituales(vehiculo_idTextBox.Text);
        }

        private void BtnAnadirConductoresHabituales_Click(object sender, EventArgs e)
        {
            // Si el usuario cambia el texto y no se encuentra en la tabla.
            if (CbConductoresHabituales.SelectedValue == null)
                return;

            if (CbConductoresHabituales.SelectedValue.ToString() == conductor_idTextBox.Text)
            {
                MessageBox.Show("El conductor habitual por defecto no puede estar en la lista",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }

            if (LvConductoresHabituales.Items.Count >= 9)
            {
                MessageBox.Show("El número máximo es 9",
                "Aviso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }

            bool bEncontrado = false;

            foreach (ListViewItem lvi in LvConductoresHabituales.Items)
            {
                if ((lvi.SubItems[0].Text == CbConductoresHabituales.SelectedValue.ToString())
                    && (lvi.SubItems[1].Text == CbConductoresHabituales.Text)) bEncontrado = true;
            }

            if (!bEncontrado)
            {
                LvConductoresHabituales.Items.Add(new ListViewItem(
                  new string[] { CbConductoresHabituales.SelectedValue.ToString(), CbConductoresHabituales.Text }));
            }

        }

        private void BtnQuitarConductoresHabituales_Click(object sender, EventArgs e)
        {
            // TODO: Mirar como permitir multiselección.
            if (LvConductoresHabituales.SelectedItems.Count > 0)
            {
                for (int i = 0; i < LvConductoresHabituales.SelectedIndices.Count; i++)
                {
                    LvConductoresHabituales.Items.RemoveAt(LvConductoresHabituales.SelectedIndices[i]);
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            LvConductoresHabituales.Items.Clear();
            matriculaTextBox.Select();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            RellenaLvConductoresHabituales(vehiculo_idTextBox.Text);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            RellenaLvConductoresHabituales(vehiculo_idTextBox.Text);
        }

        /*
         * 
         * Procedimiento para rellenar la ListVie de conductores habituales. Primero la borra y luego la rellena con
         * 
         * los conductores habituales del vehiculo en la tabla vehiculo_conductor
         * 
         * Entrada:
         *      string vehiculo_id
         *      
         * Salida:
         *      void
         *      
         *  Modifica:
         *      LvConductoresHabituales
         *      
         */
        private void RellenaLvConductoresHabituales(string v_id)
        {
            LvConductoresHabituales.Items.Clear();
            try
            {
                var select = "SELECT vehiculo_conductor.conductor_id , nombre + ' ' +" +
                    " apellidos as 'Nombre y apellidos' FROM vehiculo_conductor INNER JOIN conductor" +
                    " ON vehiculo_conductor.conductor_id = conductor.conductor_id WHERE vehiculo_id = @veh_id";
                SqlCommand cmd = new SqlCommand(select, Globals.conn);
                cmd.Parameters.Add("@veh_id", SqlDbType.Int);
                cmd.Parameters["@veh_id"].Value = v_id;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        LvConductoresHabituales.Items.Add(new ListViewItem(
                         new string[] { reader.GetInt32(0).ToString(), reader.GetString(1) }));
                    }
                }
                else
                {
                    LvConductoresHabituales.Items.Clear();
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,
                "ERROR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            RellenaLvConductoresHabituales(vehiculo_idTextBox.Text);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            RellenaLvConductoresHabituales(vehiculo_idTextBox.Text);
        }

        private void vehiculoBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            if (e.BindingCompleteContext ==
                BindingCompleteContext.DataSourceUpdate && e.Exception == null)

                e.Binding.BindingManagerBase.EndCurrentEdit();
        }

        private void bindingNavigatorPositionItem_Leave(object sender, EventArgs e)
        {
            RellenaLvConductoresHabituales(bindingNavigatorPositionItem.Text);
        }

        private void CbConductorHabitual_Leave(object sender, EventArgs e)
        {
            if (CbConductorHabitual.FindStringExact(CbConductorHabitual.Text) == -1)
            {
                LblConductorHabitualEncontrado.Visible = true;
            }
            else
            {
                LblConductorHabitualEncontrado.Visible = false;
            }
        }

        /*
         * 
         * Borra el vehiculo y en cascada todos los conductores habituales de la tabla vehiculo_conductores .
         * 
         */
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiculoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dGTdbDataSet);
        }
    }
}