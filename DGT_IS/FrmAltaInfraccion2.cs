using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DGT_IS
{
    public partial class FrmAltaInfraccion2 : Form
    {
        public FrmAltaInfraccion2()
        {
            InitializeComponent();
        }

        private void infraccionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidaPuntos_descuenta())
            {
                return;
            }

            try
            {
                this.Validate();
                this.infraccionBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dGTdbDataSet2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void FrmAltaInfraccion2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dGTdbDataSet2.infraccion' table. You can move, or remove it, as needed.
            this.infraccionTableAdapter.Fill(this.dGTdbDataSet2.infraccion);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            puntos_descuentaUpDown.Value = puntos_descuentaUpDown.Minimum;
            identificadorTextBox.Select();
        }


        private void bindingNavigatorMovePreviousItem_MouseDown(object sender, MouseEventArgs e)
        {
            ValidaPuntos_descuenta();
        }

        private bool ValidaPuntos_descuenta()
        {
            bool ret = true;
            if (puntos_descuentaUpDown.Value == 0)
            {
                MessageBox.Show("Debes introducir un valor mayor que cero para el campo puntos que descuenta .",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                ret = false;
            }

            return ret;
        }

        private void bindingNavigatorMoveFirstItem_MouseDown(object sender, MouseEventArgs e)
        {
            ValidaPuntos_descuenta();
        }

        private void bindingNavigatorMoveNextItem_MouseDown(object sender, MouseEventArgs e)
        {
            ValidaPuntos_descuenta();
        }

        private void bindingNavigatorMoveLastItem_MouseDown(object sender, MouseEventArgs e)
        {
            ValidaPuntos_descuenta();
        }
    }
}
