/*
 * 
 * Pantalla principal con las opciones del programa. Se ejecuta después de la pantala de login.
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

namespace DGT_IS
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Globals.conn != null) Globals.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "ERROR cerrando la conexión con la base de datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void BtnAltaVehiculo_Click(object sender, EventArgs e)
        {
            FrmAltaVehiculo2 frmAltaVehiculo2 = new FrmAltaVehiculo2();
            frmAltaVehiculo2.ShowDialog();
        }

        private void BtnAltaConductor_Click(object sender, EventArgs e)
        {
            FrmAltaConductor2 frmAltaConductor2 = new FrmAltaConductor2();
            frmAltaConductor2.ShowDialog();
        }

        private void BtnAltaInfraccion_Click(object sender, EventArgs e)
        {
            FrmAltaInfraccion2 frmAltaInfraccion2 = new FrmAltaInfraccion2();
            frmAltaInfraccion2.ShowDialog();
        }

        private void BtnAltaInfraccionVehiculo_Click(object sender, EventArgs e)
        {
            FrmAltaInfraccionVehiculo frmAltaInfraccionVehiculo = new FrmAltaInfraccionVehiculo();
            frmAltaInfraccionVehiculo.ShowDialog();
        }

        private void BtnHistorialInfraccionesConductor_Click(object sender, EventArgs e)
        {
            FrmHistorialInfraccionesConductor frmHistorialInfraccionesConductor  = new FrmHistorialInfraccionesConductor();
            frmHistorialInfraccionesConductor.ShowDialog();
        }

        private void Btn5TiposInfraccionMasHabituales_Click(object sender, EventArgs e)
        {
            Frm5TiposInformacionMasHabituales frm5TiposInformacionMasHabituales = new Frm5TiposInformacionMasHabituales();
            frm5TiposInformacionMasHabituales.ShowDialog();
        }

        private void BtnTopNConductores_Click(object sender, EventArgs e)
        {
            FrmTopNConductores frmTopNConductores = new FrmTopNConductores();
            frmTopNConductores.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Globals.conn == null)
            {
                FrmDbConnection frmDbConnection = new FrmDbConnection();
                frmDbConnection.ShowDialog();

                if (Globals.conn == null) {
                    if (System.Windows.Forms.Application.MessageLoop)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                    else
                    {
                        System.Environment.Exit(1);
                    }
                }
            }
        }
    }
}
