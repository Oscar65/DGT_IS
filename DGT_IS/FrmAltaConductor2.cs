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
            this.Validate();
            this.conductorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dGTdbDataSet1);

        }

        private void FrmAltaConductor2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dGTdbDataSet1.conductor' table. You can move, or remove it, as needed.
            this.conductorTableAdapter.Fill(this.dGTdbDataSet1.conductor);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            puntosNumericUpDown.Value = puntosNumericUpDown.Maximum;
            dniTextBox.Select();
        }
    }
}
