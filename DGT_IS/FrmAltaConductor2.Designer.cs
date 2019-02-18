namespace DGT_IS
{
    partial class FrmAltaConductor2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label conductor_idLabel;
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label puntosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaConductor2));
            this.dGTdbDataSet1 = new DGT_IS.DGTdbDataSet1();
            this.conductorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conductorTableAdapter = new DGT_IS.DGTdbDataSet1TableAdapters.conductorTableAdapter();
            this.tableAdapterManager = new DGT_IS.DGTdbDataSet1TableAdapters.TableAdapterManager();
            this.conductorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.conductorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.conductor_idTextBox = new System.Windows.Forms.TextBox();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.puntosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BtnCerrar = new System.Windows.Forms.Button();
            conductor_idLabel = new System.Windows.Forms.Label();
            dniLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            puntosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGTdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingNavigator)).BeginInit();
            this.conductorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntosNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // conductor_idLabel
            // 
            conductor_idLabel.AutoSize = true;
            conductor_idLabel.Location = new System.Drawing.Point(12, 54);
            conductor_idLabel.Name = "conductor_idLabel";
            conductor_idLabel.Size = new System.Drawing.Size(90, 17);
            conductor_idLabel.TabIndex = 1;
            conductor_idLabel.Text = "conductor id:";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(12, 82);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(31, 17);
            dniLabel.TabIndex = 3;
            dniLabel.Text = "dni:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 110);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(12, 138);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(68, 17);
            apellidosLabel.TabIndex = 7;
            apellidosLabel.Text = "apellidos:";
            // 
            // puntosLabel
            // 
            puntosLabel.AutoSize = true;
            puntosLabel.Location = new System.Drawing.Point(12, 166);
            puntosLabel.Name = "puntosLabel";
            puntosLabel.Size = new System.Drawing.Size(55, 17);
            puntosLabel.TabIndex = 9;
            puntosLabel.Text = "puntos:";
            // 
            // dGTdbDataSet1
            // 
            this.dGTdbDataSet1.DataSetName = "DGTdbDataSet1";
            this.dGTdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conductorBindingSource
            // 
            this.conductorBindingSource.DataMember = "conductor";
            this.conductorBindingSource.DataSource = this.dGTdbDataSet1;
            // 
            // conductorTableAdapter
            // 
            this.conductorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.conductorTableAdapter = this.conductorTableAdapter;
            this.tableAdapterManager.UpdateOrder = DGT_IS.DGTdbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // conductorBindingNavigator
            // 
            this.conductorBindingNavigator.AddNewItem = null;
            this.conductorBindingNavigator.BindingSource = this.conductorBindingSource;
            this.conductorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.conductorBindingNavigator.DeleteItem = null;
            this.conductorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conductorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.conductorBindingNavigatorSaveItem});
            this.conductorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.conductorBindingNavigator.MoveFirstItem = null;
            this.conductorBindingNavigator.MoveLastItem = null;
            this.conductorBindingNavigator.MoveNextItem = null;
            this.conductorBindingNavigator.MovePreviousItem = null;
            this.conductorBindingNavigator.Name = "conductorBindingNavigator";
            this.conductorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.conductorBindingNavigator.Size = new System.Drawing.Size(439, 27);
            this.conductorBindingNavigator.TabIndex = 0;
            this.conductorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Leave += new System.EventHandler(this.bindingNavigatorPositionItem_Leave);
            this.bindingNavigatorPositionItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bindingNavigatorPositionItem_KeyDown);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // conductorBindingNavigatorSaveItem
            // 
            this.conductorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.conductorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("conductorBindingNavigatorSaveItem.Image")));
            this.conductorBindingNavigatorSaveItem.Name = "conductorBindingNavigatorSaveItem";
            this.conductorBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.conductorBindingNavigatorSaveItem.Text = "Save Data";
            this.conductorBindingNavigatorSaveItem.Click += new System.EventHandler(this.conductorBindingNavigatorSaveItem_Click);
            // 
            // conductor_idTextBox
            // 
            this.conductor_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conductorBindingSource, "conductor_id", true));
            this.conductor_idTextBox.Enabled = false;
            this.conductor_idTextBox.Location = new System.Drawing.Point(108, 51);
            this.conductor_idTextBox.Name = "conductor_idTextBox";
            this.conductor_idTextBox.Size = new System.Drawing.Size(47, 22);
            this.conductor_idTextBox.TabIndex = 2;
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conductorBindingSource, "dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(108, 79);
            this.dniTextBox.MaxLength = 10;
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(85, 22);
            this.dniTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conductorBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(108, 107);
            this.nombreTextBox.MaxLength = 30;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(300, 22);
            this.nombreTextBox.TabIndex = 6;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conductorBindingSource, "apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(108, 135);
            this.apellidosTextBox.MaxLength = 30;
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(300, 22);
            this.apellidosTextBox.TabIndex = 8;
            // 
            // puntosNumericUpDown
            // 
            this.puntosNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.conductorBindingSource, "puntos", true));
            this.puntosNumericUpDown.Location = new System.Drawing.Point(108, 166);
            this.puntosNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.puntosNumericUpDown.Name = "puntosNumericUpDown";
            this.puntosNumericUpDown.Size = new System.Drawing.Size(47, 22);
            this.puntosNumericUpDown.TabIndex = 4;
            this.puntosNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(151, 217);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(167, 73);
            this.BtnCerrar.TabIndex = 10;
            this.BtnCerrar.Text = "&Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmAltaConductor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 339);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.puntosNumericUpDown);
            this.Controls.Add(conductor_idLabel);
            this.Controls.Add(this.conductor_idTextBox);
            this.Controls.Add(dniLabel);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(puntosLabel);
            this.Controls.Add(this.conductorBindingNavigator);
            this.Name = "FrmAltaConductor2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta conductores";
            this.Load += new System.EventHandler(this.FrmAltaConductor2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGTdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingNavigator)).EndInit();
            this.conductorBindingNavigator.ResumeLayout(false);
            this.conductorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntosNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DGTdbDataSet1 dGTdbDataSet1;
        private System.Windows.Forms.BindingSource conductorBindingSource;
        private DGTdbDataSet1TableAdapters.conductorTableAdapter conductorTableAdapter;
        private DGTdbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator conductorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton conductorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox conductor_idTextBox;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.NumericUpDown puntosNumericUpDown;
        private System.Windows.Forms.Button BtnCerrar;
    }
}