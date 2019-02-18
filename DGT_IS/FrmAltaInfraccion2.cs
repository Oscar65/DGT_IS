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

            /*
             * 
             * Para que no deje moverse mientras puntos_descuentaUpDown sea cero.
             * 
             */
            this.infraccionBindingNavigator.CausesValidation = true;

            this.bindingNavigatorPositionItem.Text = (this.infraccionBindingSource.Position + 1).ToString();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (identificadorTextBox.Text == "" && descripcionTextBox.Text == "")
            {
                this.bindingNavigatorPositionItem.Text = (this.infraccionBindingSource.Position + 1).ToString();
                puntos_descuentaUpDown.Value = puntos_descuentaUpDown.Minimum;
                puntos_descuentaUpDown.Select();
            }
        }

        private bool ValidaPuntos_descuenta()
        {
            bool ret = true;

            if (puntos_descuentaUpDown.Value == 0)
            {
                MessageBox.Show("Debes introducir un valor mayor que cero para el campo puntos que descuenta.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                ret = false;
            }

            return ret;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void puntos_descuentaUpDown_Validating(object sender, CancelEventArgs e)
        {
            if (puntos_descuentaUpDown.Value == 0)
            {
                /*
                 * 
                 * Para que funcionen las flechas para incrementar y decrementar el valor.
                 * 
                 */
                //identificadorTextBox.Select();
                puntos_descuentaUpDown.Select();
                this.errorProvider1.SetError(puntos_descuentaUpDown, "Debe ser mayor que cero");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                this.errorProvider1.SetError(puntos_descuentaUpDown, "");
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            infraccionBindingNavigator.CausesValidation = false;

            try
            {
                this.infraccionBindingSource.RemoveCurrent();
                this.errorProvider1.SetError(puntos_descuentaUpDown, "");
                this.bindingNavigatorPositionItem.Text = (this.infraccionBindingSource.Position + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            infraccionBindingNavigator.CausesValidation = true;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            if (puntos_descuentaUpDown.Value == 0)
            {
                identificadorTextBox.Select();
                return;
            }

            try
            {
                this.infraccionBindingSource.MoveFirst();
                this.bindingNavigatorPositionItem.Text = (this.infraccionBindingSource.Position + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (puntos_descuentaUpDown.Value == 0)
            {
                identificadorTextBox.Select();
                return;
            }

            try
            {
                this.infraccionBindingSource.MovePrevious();
                this.bindingNavigatorPositionItem.Text = (this.infraccionBindingSource.Position + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorPositionItem_Leave(object sender, EventArgs e)
        {
            if (puntos_descuentaUpDown.Value == 0)
            {
                identificadorTextBox.Select();
                return;
            }

            try
            {
                int value;
                if (int.TryParse(this.bindingNavigatorPositionItem.Text, out value))
                {
                    this.infraccionBindingSource.Position = value - 1;
                }
                else
                {
                    this.bindingNavigatorPositionItem.Undo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if (puntos_descuentaUpDown.Value == 0)
            {
                identificadorTextBox.Select();
                return;
            }

            try
            {
                this.infraccionBindingSource.MoveNext();
                this.bindingNavigatorPositionItem.Text = (this.infraccionBindingSource.Position + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            if (puntos_descuentaUpDown.Value == 0)
            {
                identificadorTextBox.Select();
                return;
            }

            try
            {
                this.infraccionBindingSource.MoveLast();
                this.bindingNavigatorPositionItem.Text = (this.infraccionBindingSource.Position + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void bindingNavigatorPositionItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (puntos_descuentaUpDown.Value == 0)
            {
                identificadorTextBox.Select();
                return;
            }

            try
            {
               if (e.KeyCode == Keys.Enter)
                {
                    int value;
                    if (int.TryParse(this.bindingNavigatorPositionItem.Text, out value))
                    {
                        this.infraccionBindingSource.Position = value - 1;
                    }
                    else
                    {
                        this.bindingNavigatorPositionItem.Undo();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void puntos_descuentaUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (this.puntos_descuentaUpDown.Value > 0)
            {
                this.errorProvider1.SetError(puntos_descuentaUpDown, "");
            }
        }
    }
}
