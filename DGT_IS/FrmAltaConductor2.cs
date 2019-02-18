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
    public partial class FrmAltaConductor2 : Form
    {
        public FrmAltaConductor2()
        {
            InitializeComponent();
        }

        private void conductorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.conductorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dGTdbDataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void FrmAltaConductor2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dGTdbDataSet1.conductor' table. You can move, or remove it, as needed.
            this.conductorTableAdapter.Fill(this.dGTdbDataSet1.conductor);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dniTextBox.Text == "")
                {
                    MessageBox.Show("El DNI no puede ser nulo",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }

                this.conductorBindingSource.AddNew();
                puntosNumericUpDown.Value = puntosNumericUpDown.Maximum;
                dniTextBox.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.conductorBindingSource.MoveFirst();
                this.bindingNavigatorPositionItem.Text = (this.conductorBindingSource.Position + 1).ToString();
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
            try
            {
                this.conductorBindingSource.MovePrevious();
                this.bindingNavigatorPositionItem.Text = (this.conductorBindingSource.Position + 1).ToString();
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
            try
            {
                this.conductorBindingSource.MoveNext();
                this.bindingNavigatorPositionItem.Text = (this.conductorBindingSource.Position + 1).ToString();
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
            try
            {
                this.conductorBindingSource.MoveLast();
                this.bindingNavigatorPositionItem.Text = (this.conductorBindingSource.Position + 1).ToString();
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
            try
            {
                int value;
                if (int.TryParse(this.bindingNavigatorPositionItem.Text, out value))
                {
                    this.conductorBindingSource.Position = value - 1;
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

        private void bindingNavigatorPositionItem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int value;
                    if (int.TryParse(this.bindingNavigatorPositionItem.Text, out value))
                    {
                        this.conductorBindingSource.Position = value - 1;
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.conductorBindingSource.RemoveCurrent();
                this.bindingNavigatorPositionItem.Text = (this.conductorBindingSource.Position + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
