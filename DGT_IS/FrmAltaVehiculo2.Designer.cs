namespace DGT_IS
{
    partial class FrmAltaVehiculo2
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
            System.Windows.Forms.Label vehiculo_idLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label conductor_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaVehiculo2));
            this.vehiculoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dGTdbDataSet = new DGT_IS.DGTdbDataSet();
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
            this.vehiculoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vehiculo_idTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.conductor_idTextBox = new System.Windows.Forms.TextBox();
            this.CbConductorHabitual = new System.Windows.Forms.ComboBox();
            this.vehiculo_conductoreshabitualesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LblConductoresHabituales = new System.Windows.Forms.Label();
            this.CbConductoresHabituales = new System.Windows.Forms.ComboBox();
            this.BtnAnadirConductoresHabituales = new System.Windows.Forms.Button();
            this.BtnQuitarConductoresHabituales = new System.Windows.Forms.Button();
            this.dGTdbDataSet1 = new DGT_IS.DGTdbDataSet1();
            this.conductorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.conductorTableAdapter1 = new DGT_IS.DGTdbDataSet1TableAdapters.conductorTableAdapter();
            this.tableAdapterManager1 = new DGT_IS.DGTdbDataSet1TableAdapters.TableAdapterManager();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.vehiculoTableAdapter = new DGT_IS.DGTdbDataSetTableAdapters.vehiculoTableAdapter();
            this.tableAdapterManager = new DGT_IS.DGTdbDataSetTableAdapters.TableAdapterManager();
            this.conductorTableAdapter = new DGT_IS.DGTdbDataSetTableAdapters.conductorTableAdapter();
            this.conductorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculo_conductoreshabitualesTableAdapter = new DGT_IS.DGTdbDataSetTableAdapters.vehiculo_conductoreshabitualesTableAdapter();
            this.LvConductoresHabituales = new System.Windows.Forms.ListView();
            this.conductor_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreapellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblConductorHabitualEncontrado = new System.Windows.Forms.Label();
            vehiculo_idLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            conductor_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingNavigator)).BeginInit();
            this.vehiculoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGTdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculo_conductoreshabitualesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGTdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiculo_idLabel
            // 
            vehiculo_idLabel.AutoSize = true;
            vehiculo_idLabel.Location = new System.Drawing.Point(12, 59);
            vehiculo_idLabel.Name = "vehiculo_idLabel";
            vehiculo_idLabel.Size = new System.Drawing.Size(79, 17);
            vehiculo_idLabel.TabIndex = 1;
            vehiculo_idLabel.Text = "vehiculo id:";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(12, 87);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(69, 17);
            matriculaLabel.TabIndex = 3;
            matriculaLabel.Text = "matricula:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(12, 114);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(51, 17);
            marcaLabel.TabIndex = 5;
            marcaLabel.Text = "marca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(12, 143);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(58, 17);
            modeloLabel.TabIndex = 7;
            modeloLabel.Text = "modelo:";
            // 
            // conductor_idLabel
            // 
            conductor_idLabel.AutoSize = true;
            conductor_idLabel.Location = new System.Drawing.Point(12, 171);
            conductor_idLabel.Name = "conductor_idLabel";
            conductor_idLabel.Size = new System.Drawing.Size(90, 17);
            conductor_idLabel.TabIndex = 9;
            conductor_idLabel.Text = "conductor id:";
            // 
            // vehiculoBindingNavigator
            // 
            this.vehiculoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vehiculoBindingNavigator.BindingSource = this.vehiculoBindingSource;
            this.vehiculoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vehiculoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vehiculoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vehiculoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vehiculoBindingNavigatorSaveItem});
            this.vehiculoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vehiculoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vehiculoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vehiculoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vehiculoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vehiculoBindingNavigator.Name = "vehiculoBindingNavigator";
            this.vehiculoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vehiculoBindingNavigator.Size = new System.Drawing.Size(927, 27);
            this.vehiculoBindingNavigator.TabIndex = 0;
            this.vehiculoBindingNavigator.Text = "bindingNavigator1";
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
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataMember = "vehiculo";
            this.vehiculoBindingSource.DataSource = this.dGTdbDataSet;
            this.vehiculoBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.vehiculoBindingSource_BindingComplete);
            // 
            // dGTdbDataSet
            // 
            this.dGTdbDataSet.DataSetName = "DGTdbDataSet";
            this.dGTdbDataSet.EnforceConstraints = false;
            this.dGTdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Leave += new System.EventHandler(this.bindingNavigatorPositionItem_Leave);
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
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
            // vehiculoBindingNavigatorSaveItem
            // 
            this.vehiculoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vehiculoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vehiculoBindingNavigatorSaveItem.Image")));
            this.vehiculoBindingNavigatorSaveItem.Name = "vehiculoBindingNavigatorSaveItem";
            this.vehiculoBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.vehiculoBindingNavigatorSaveItem.Text = "Save Data";
            this.vehiculoBindingNavigatorSaveItem.Click += new System.EventHandler(this.vehiculoBindingNavigatorSaveItem_Click);
            // 
            // vehiculo_idTextBox
            // 
            this.vehiculo_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "vehiculo_id", true));
            this.vehiculo_idTextBox.Location = new System.Drawing.Point(108, 57);
            this.vehiculo_idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vehiculo_idTextBox.Name = "vehiculo_idTextBox";
            this.vehiculo_idTextBox.ReadOnly = true;
            this.vehiculo_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.vehiculo_idTextBox.TabIndex = 2;
            this.vehiculo_idTextBox.TabStop = false;
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(108, 84);
            this.matriculaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matriculaTextBox.MaxLength = 15;
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(160, 22);
            this.matriculaTextBox.TabIndex = 4;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(108, 112);
            this.marcaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marcaTextBox.MaxLength = 25;
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(300, 22);
            this.marcaTextBox.TabIndex = 6;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(108, 140);
            this.modeloTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeloTextBox.MaxLength = 25;
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(300, 22);
            this.modeloTextBox.TabIndex = 8;
            // 
            // conductor_idTextBox
            // 
            this.conductor_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiculoBindingSource, "conductor_id", true));
            this.conductor_idTextBox.Location = new System.Drawing.Point(108, 167);
            this.conductor_idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conductor_idTextBox.Name = "conductor_idTextBox";
            this.conductor_idTextBox.ReadOnly = true;
            this.conductor_idTextBox.Size = new System.Drawing.Size(81, 22);
            this.conductor_idTextBox.TabIndex = 10;
            this.conductor_idTextBox.TabStop = false;
            // 
            // CbConductorHabitual
            // 
            this.CbConductorHabitual.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbConductorHabitual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbConductorHabitual.FormattingEnabled = true;
            this.CbConductorHabitual.Location = new System.Drawing.Point(195, 166);
            this.CbConductorHabitual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbConductorHabitual.Name = "CbConductorHabitual";
            this.CbConductorHabitual.Size = new System.Drawing.Size(190, 24);
            this.CbConductorHabitual.TabIndex = 11;
            this.CbConductorHabitual.Leave += new System.EventHandler(this.CbConductorHabitual_Leave);
            // 
            // vehiculo_conductoreshabitualesBindingSource
            // 
            this.vehiculo_conductoreshabitualesBindingSource.DataMember = "vehiculo_conductoreshabituales";
            this.vehiculo_conductoreshabitualesBindingSource.DataSource = this.dGTdbDataSet;
            // 
            // LblConductoresHabituales
            // 
            this.LblConductoresHabituales.AutoSize = true;
            this.LblConductoresHabituales.Location = new System.Drawing.Point(573, 38);
            this.LblConductoresHabituales.Name = "LblConductoresHabituales";
            this.LblConductoresHabituales.Size = new System.Drawing.Size(157, 17);
            this.LblConductoresHabituales.TabIndex = 13;
            this.LblConductoresHabituales.Text = "Conductores habituales";
            // 
            // CbConductoresHabituales
            // 
            this.CbConductoresHabituales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbConductoresHabituales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbConductoresHabituales.FormattingEnabled = true;
            this.CbConductoresHabituales.Location = new System.Drawing.Point(428, 74);
            this.CbConductoresHabituales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbConductoresHabituales.Name = "CbConductoresHabituales";
            this.CbConductoresHabituales.Size = new System.Drawing.Size(468, 24);
            this.CbConductoresHabituales.TabIndex = 12;
            // 
            // BtnAnadirConductoresHabituales
            // 
            this.BtnAnadirConductoresHabituales.Location = new System.Drawing.Point(428, 114);
            this.BtnAnadirConductoresHabituales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAnadirConductoresHabituales.Name = "BtnAnadirConductoresHabituales";
            this.BtnAnadirConductoresHabituales.Size = new System.Drawing.Size(56, 34);
            this.BtnAnadirConductoresHabituales.TabIndex = 13;
            this.BtnAnadirConductoresHabituales.Text = "+";
            this.BtnAnadirConductoresHabituales.UseVisualStyleBackColor = true;
            this.BtnAnadirConductoresHabituales.Click += new System.EventHandler(this.BtnAnadirConductoresHabituales_Click);
            // 
            // BtnQuitarConductoresHabituales
            // 
            this.BtnQuitarConductoresHabituales.Location = new System.Drawing.Point(837, 114);
            this.BtnQuitarConductoresHabituales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnQuitarConductoresHabituales.Name = "BtnQuitarConductoresHabituales";
            this.BtnQuitarConductoresHabituales.Size = new System.Drawing.Size(59, 34);
            this.BtnQuitarConductoresHabituales.TabIndex = 14;
            this.BtnQuitarConductoresHabituales.Text = "-";
            this.BtnQuitarConductoresHabituales.UseVisualStyleBackColor = true;
            this.BtnQuitarConductoresHabituales.Click += new System.EventHandler(this.BtnQuitarConductoresHabituales_Click);
            // 
            // dGTdbDataSet1
            // 
            this.dGTdbDataSet1.DataSetName = "DGTdbDataSet1";
            this.dGTdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conductorBindingSource1
            // 
            this.conductorBindingSource1.DataMember = "conductor";
            this.conductorBindingSource1.DataSource = this.dGTdbDataSet1;
            // 
            // conductorTableAdapter1
            // 
            this.conductorTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.conductorTableAdapter = this.conductorTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = DGT_IS.DGTdbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(335, 483);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(191, 74);
            this.BtnCerrar.TabIndex = 18;
            this.BtnCerrar.Text = "&Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // vehiculoTableAdapter
            // 
            this.vehiculoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.conductorTableAdapter = this.conductorTableAdapter;
            this.tableAdapterManager.UpdateOrder = DGT_IS.DGTdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vehiculoTableAdapter = this.vehiculoTableAdapter;
            // 
            // conductorTableAdapter
            // 
            this.conductorTableAdapter.ClearBeforeFill = true;
            // 
            // conductorBindingSource
            // 
            this.conductorBindingSource.DataMember = "conductor";
            this.conductorBindingSource.DataSource = this.dGTdbDataSet;
            // 
            // vehiculo_conductoreshabitualesTableAdapter
            // 
            this.vehiculo_conductoreshabitualesTableAdapter.ClearBeforeFill = true;
            // 
            // LvConductoresHabituales
            // 
            this.LvConductoresHabituales.AutoArrange = false;
            this.LvConductoresHabituales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.conductor_id,
            this.nombreapellidos});
            this.LvConductoresHabituales.FullRowSelect = true;
            this.LvConductoresHabituales.GridLines = true;
            this.LvConductoresHabituales.Location = new System.Drawing.Point(428, 171);
            this.LvConductoresHabituales.Margin = new System.Windows.Forms.Padding(4);
            this.LvConductoresHabituales.MultiSelect = false;
            this.LvConductoresHabituales.Name = "LvConductoresHabituales";
            this.LvConductoresHabituales.Size = new System.Drawing.Size(468, 288);
            this.LvConductoresHabituales.TabIndex = 19;
            this.LvConductoresHabituales.UseCompatibleStateImageBehavior = false;
            this.LvConductoresHabituales.View = System.Windows.Forms.View.Details;
            // 
            // conductor_id
            // 
            this.conductor_id.Text = "conductor_id";
            this.conductor_id.Width = 110;
            // 
            // nombreapellidos
            // 
            this.nombreapellidos.Text = "Nombre y apellidos";
            this.nombreapellidos.Width = 250;
            // 
            // LblConductorHabitualEncontrado
            // 
            this.LblConductorHabitualEncontrado.AutoSize = true;
            this.LblConductorHabitualEncontrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblConductorHabitualEncontrado.Location = new System.Drawing.Point(391, 169);
            this.LblConductorHabitualEncontrado.Name = "LblConductorHabitualEncontrado";
            this.LblConductorHabitualEncontrado.Size = new System.Drawing.Size(19, 19);
            this.LblConductorHabitualEncontrado.TabIndex = 20;
            this.LblConductorHabitualEncontrado.Text = "X";
            this.LblConductorHabitualEncontrado.Visible = false;
            // 
            // FrmAltaVehiculo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 583);
            this.Controls.Add(this.LblConductorHabitualEncontrado);
            this.Controls.Add(this.LvConductoresHabituales);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnQuitarConductoresHabituales);
            this.Controls.Add(this.BtnAnadirConductoresHabituales);
            this.Controls.Add(this.CbConductoresHabituales);
            this.Controls.Add(this.LblConductoresHabituales);
            this.Controls.Add(this.CbConductorHabitual);
            this.Controls.Add(vehiculo_idLabel);
            this.Controls.Add(this.vehiculo_idTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(conductor_idLabel);
            this.Controls.Add(this.conductor_idTextBox);
            this.Controls.Add(this.vehiculoBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAltaVehiculo2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta vehículo";
            this.Load += new System.EventHandler(this.FrmAltaVehiculo2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingNavigator)).EndInit();
            this.vehiculoBindingNavigator.ResumeLayout(false);
            this.vehiculoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGTdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculo_conductoreshabitualesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGTdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DGTdbDataSet dGTdbDataSet;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private DGTdbDataSetTableAdapters.vehiculoTableAdapter vehiculoTableAdapter;
        //private DGTdbDataSetTableAdapters.vehiculo_conductoreshabitualesTableAdapter vehiculo_conductoresTableAdapter;
        private DGTdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vehiculoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vehiculoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vehiculo_idTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox conductor_idTextBox;
        private DGTdbDataSetTableAdapters.conductorTableAdapter conductorTableAdapter;
        private System.Windows.Forms.BindingSource conductorBindingSource;
        private System.Windows.Forms.ComboBox CbConductorHabitual;
        private System.Windows.Forms.Label LblConductoresHabituales;
        private System.Windows.Forms.ComboBox CbConductoresHabituales;
        private System.Windows.Forms.Button BtnAnadirConductoresHabituales;
        private System.Windows.Forms.Button BtnQuitarConductoresHabituales;
        private DGTdbDataSet1 dGTdbDataSet1;
        private System.Windows.Forms.BindingSource conductorBindingSource1;
        private DGTdbDataSet1TableAdapters.conductorTableAdapter conductorTableAdapter1;
        private DGTdbDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.BindingSource vehiculo_conductoreshabitualesBindingSource;
        private DGTdbDataSetTableAdapters.vehiculo_conductoreshabitualesTableAdapter vehiculo_conductoreshabitualesTableAdapter;
        private System.Windows.Forms.ListView LvConductoresHabituales;
        private System.Windows.Forms.ColumnHeader conductor_id;
        private System.Windows.Forms.ColumnHeader nombreapellidos;
        private System.Windows.Forms.Label LblConductorHabitualEncontrado;
    }
}