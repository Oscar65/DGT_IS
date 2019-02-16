namespace DGT_IS
{
    partial class FrmAltaInfraccion2
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
            System.Windows.Forms.Label infraccion_idLabel;
            System.Windows.Forms.Label identificadorLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label puntos_descuentaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaInfraccion2));
            this.dGTdbDataSet2 = new DGT_IS.DGTdbDataSet2();
            this.infraccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infraccionTableAdapter = new DGT_IS.DGTdbDataSet2TableAdapters.infraccionTableAdapter();
            this.tableAdapterManager = new DGT_IS.DGTdbDataSet2TableAdapters.TableAdapterManager();
            this.infraccionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.infraccionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.infraccion_idTextBox = new System.Windows.Forms.TextBox();
            this.identificadorTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.puntos_descuentaUpDown = new System.Windows.Forms.NumericUpDown();
            infraccion_idLabel = new System.Windows.Forms.Label();
            identificadorLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            puntos_descuentaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGTdbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infraccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infraccionBindingNavigator)).BeginInit();
            this.infraccionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntos_descuentaUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // infraccion_idLabel
            // 
            infraccion_idLabel.AutoSize = true;
            infraccion_idLabel.Location = new System.Drawing.Point(12, 55);
            infraccion_idLabel.Name = "infraccion_idLabel";
            infraccion_idLabel.Size = new System.Drawing.Size(88, 17);
            infraccion_idLabel.TabIndex = 4;
            infraccion_idLabel.Text = "infraccion id:";
            // 
            // identificadorLabel
            // 
            identificadorLabel.AutoSize = true;
            identificadorLabel.Location = new System.Drawing.Point(12, 83);
            identificadorLabel.Name = "identificadorLabel";
            identificadorLabel.Size = new System.Drawing.Size(89, 17);
            identificadorLabel.TabIndex = 5;
            identificadorLabel.Text = "identificador:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(12, 111);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(84, 17);
            descripcionLabel.TabIndex = 6;
            descripcionLabel.Text = "descripcion:";
            // 
            // puntos_descuentaLabel
            // 
            puntos_descuentaLabel.AutoSize = true;
            puntos_descuentaLabel.Location = new System.Drawing.Point(12, 233);
            puntos_descuentaLabel.Name = "puntos_descuentaLabel";
            puntos_descuentaLabel.Size = new System.Drawing.Size(153, 17);
            puntos_descuentaLabel.TabIndex = 7;
            puntos_descuentaLabel.Text = "puntos que descuenta:";
            // 
            // dGTdbDataSet2
            // 
            this.dGTdbDataSet2.DataSetName = "DGTdbDataSet2";
            this.dGTdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infraccionBindingSource
            // 
            this.infraccionBindingSource.DataMember = "infraccion";
            this.infraccionBindingSource.DataSource = this.dGTdbDataSet2;
            // 
            // infraccionTableAdapter
            // 
            this.infraccionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.infraccionTableAdapter = this.infraccionTableAdapter;
            this.tableAdapterManager.UpdateOrder = DGT_IS.DGTdbDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // infraccionBindingNavigator
            // 
            this.infraccionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.infraccionBindingNavigator.BindingSource = this.infraccionBindingSource;
            this.infraccionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.infraccionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.infraccionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.infraccionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.infraccionBindingNavigatorSaveItem});
            this.infraccionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.infraccionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.infraccionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.infraccionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.infraccionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.infraccionBindingNavigator.Name = "infraccionBindingNavigator";
            this.infraccionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.infraccionBindingNavigator.Size = new System.Drawing.Size(949, 27);
            this.infraccionBindingNavigator.TabIndex = 0;
            this.infraccionBindingNavigator.Text = "bindingNavigator1";
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
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bindingNavigatorMoveFirstItem_MouseDown);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bindingNavigatorMovePreviousItem_MouseDown);
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
            this.bindingNavigatorMoveNextItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bindingNavigatorMoveNextItem_MouseDown);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bindingNavigatorMoveLastItem_MouseDown);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // infraccionBindingNavigatorSaveItem
            // 
            this.infraccionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infraccionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("infraccionBindingNavigatorSaveItem.Image")));
            this.infraccionBindingNavigatorSaveItem.Name = "infraccionBindingNavigatorSaveItem";
            this.infraccionBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.infraccionBindingNavigatorSaveItem.Text = "Save Data";
            this.infraccionBindingNavigatorSaveItem.Click += new System.EventHandler(this.infraccionBindingNavigatorSaveItem_Click);
            // 
            // infraccion_idTextBox
            // 
            this.infraccion_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infraccionBindingSource, "infraccion_id", true));
            this.infraccion_idTextBox.Enabled = false;
            this.infraccion_idTextBox.Location = new System.Drawing.Point(168, 52);
            this.infraccion_idTextBox.Name = "infraccion_idTextBox";
            this.infraccion_idTextBox.Size = new System.Drawing.Size(51, 22);
            this.infraccion_idTextBox.TabIndex = 0;
            // 
            // identificadorTextBox
            // 
            this.identificadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infraccionBindingSource, "identificador", true));
            this.identificadorTextBox.Location = new System.Drawing.Point(168, 80);
            this.identificadorTextBox.MaxLength = 10;
            this.identificadorTextBox.Name = "identificadorTextBox";
            this.identificadorTextBox.Size = new System.Drawing.Size(100, 22);
            this.identificadorTextBox.TabIndex = 1;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.infraccionBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(168, 108);
            this.descripcionTextBox.MaxLength = 250;
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(439, 116);
            this.descripcionTextBox.TabIndex = 2;
            // 
            // puntos_descuentaUpDown
            // 
            this.puntos_descuentaUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.infraccionBindingSource, "puntos_descuenta", true));
            this.puntos_descuentaUpDown.Location = new System.Drawing.Point(168, 233);
            this.puntos_descuentaUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.puntos_descuentaUpDown.Name = "puntos_descuentaUpDown";
            this.puntos_descuentaUpDown.Size = new System.Drawing.Size(58, 22);
            this.puntos_descuentaUpDown.TabIndex = 3;
            // 
            // FrmAltaInfraccion2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 296);
            this.Controls.Add(this.puntos_descuentaUpDown);
            this.Controls.Add(infraccion_idLabel);
            this.Controls.Add(this.infraccion_idTextBox);
            this.Controls.Add(identificadorLabel);
            this.Controls.Add(this.identificadorTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(puntos_descuentaLabel);
            this.Controls.Add(this.infraccionBindingNavigator);
            this.Name = "FrmAltaInfraccion2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta infracción";
            this.Load += new System.EventHandler(this.FrmAltaInfraccion2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGTdbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infraccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infraccionBindingNavigator)).EndInit();
            this.infraccionBindingNavigator.ResumeLayout(false);
            this.infraccionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntos_descuentaUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DGTdbDataSet2 dGTdbDataSet2;
        private System.Windows.Forms.BindingSource infraccionBindingSource;
        private DGTdbDataSet2TableAdapters.infraccionTableAdapter infraccionTableAdapter;
        private DGTdbDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator infraccionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton infraccionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox infraccion_idTextBox;
        private System.Windows.Forms.TextBox identificadorTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.NumericUpDown puntos_descuentaUpDown;
    }
}