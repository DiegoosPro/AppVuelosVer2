namespace AppVuelos
{
    partial class FrmReservaciones
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
            System.Windows.Forms.Label iD_RESERVACIONLabel;
            System.Windows.Forms.Label iD_CLIENTELabel;
            System.Windows.Forms.Label iD_VUELOLabel;
            System.Windows.Forms.Label fECHALabel;
            System.Windows.Forms.Label sUBTOTALLabel;
            System.Windows.Forms.Label iVALabel;
            System.Windows.Forms.Label tOTALLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservaciones));
            this.tAB_RESERVACIONESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tAB_RESERVACIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bddvuelosDataSet = new AppVuelos.bddvuelosDataSet();
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
            this.tAB_RESERVACIONESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_RESERVACIONLabel1 = new System.Windows.Forms.Label();
            this.iD_CLIENTEComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_CLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_VUELOComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_VUELOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fECHADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sUBTOTALTextBox = new System.Windows.Forms.TextBox();
            this.iVATextBox = new System.Windows.Forms.TextBox();
            this.tOTALTextBox = new System.Windows.Forms.TextBox();
            this.tAB_PLAZASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_PLAZASDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAB_RESERVACIONESTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_RESERVACIONESTableAdapter();
            this.tableAdapterManager = new AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager();
            this.tAB_PLAZASTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_PLAZASTableAdapter();
            this.tAB_CLIENTESTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_CLIENTESTableAdapter();
            this.tAB_VUELOSTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_VUELOSTableAdapter();
            iD_RESERVACIONLabel = new System.Windows.Forms.Label();
            iD_CLIENTELabel = new System.Windows.Forms.Label();
            iD_VUELOLabel = new System.Windows.Forms.Label();
            fECHALabel = new System.Windows.Forms.Label();
            sUBTOTALLabel = new System.Windows.Forms.Label();
            iVALabel = new System.Windows.Forms.Label();
            tOTALLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RESERVACIONESBindingNavigator)).BeginInit();
            this.tAB_RESERVACIONESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RESERVACIONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_VUELOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PLAZASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PLAZASDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_RESERVACIONLabel
            // 
            iD_RESERVACIONLabel.AutoSize = true;
            iD_RESERVACIONLabel.Location = new System.Drawing.Point(97, 36);
            iD_RESERVACIONLabel.Name = "iD_RESERVACIONLabel";
            iD_RESERVACIONLabel.Size = new System.Drawing.Size(101, 13);
            iD_RESERVACIONLabel.TabIndex = 1;
            iD_RESERVACIONLabel.Text = "ID RESERVACION:";
            // 
            // iD_CLIENTELabel
            // 
            iD_CLIENTELabel.AutoSize = true;
            iD_CLIENTELabel.Location = new System.Drawing.Point(97, 65);
            iD_CLIENTELabel.Name = "iD_CLIENTELabel";
            iD_CLIENTELabel.Size = new System.Drawing.Size(69, 13);
            iD_CLIENTELabel.TabIndex = 3;
            iD_CLIENTELabel.Text = "ID CLIENTE:";
            // 
            // iD_VUELOLabel
            // 
            iD_VUELOLabel.AutoSize = true;
            iD_VUELOLabel.Location = new System.Drawing.Point(97, 92);
            iD_VUELOLabel.Name = "iD_VUELOLabel";
            iD_VUELOLabel.Size = new System.Drawing.Size(60, 13);
            iD_VUELOLabel.TabIndex = 5;
            iD_VUELOLabel.Text = "ID VUELO:";
            // 
            // fECHALabel
            // 
            fECHALabel.AutoSize = true;
            fECHALabel.Location = new System.Drawing.Point(97, 120);
            fECHALabel.Name = "fECHALabel";
            fECHALabel.Size = new System.Drawing.Size(45, 13);
            fECHALabel.TabIndex = 7;
            fECHALabel.Text = "FECHA:";
            // 
            // sUBTOTALLabel
            // 
            sUBTOTALLabel.AutoSize = true;
            sUBTOTALLabel.Location = new System.Drawing.Point(373, 402);
            sUBTOTALLabel.Name = "sUBTOTALLabel";
            sUBTOTALLabel.Size = new System.Drawing.Size(67, 13);
            sUBTOTALLabel.TabIndex = 9;
            sUBTOTALLabel.Text = "SUBTOTAL:";
            // 
            // iVALabel
            // 
            iVALabel.AutoSize = true;
            iVALabel.Location = new System.Drawing.Point(373, 428);
            iVALabel.Name = "iVALabel";
            iVALabel.Size = new System.Drawing.Size(27, 13);
            iVALabel.TabIndex = 11;
            iVALabel.Text = "IVA:";
            // 
            // tOTALLabel
            // 
            tOTALLabel.AutoSize = true;
            tOTALLabel.Location = new System.Drawing.Point(373, 454);
            tOTALLabel.Name = "tOTALLabel";
            tOTALLabel.Size = new System.Drawing.Size(45, 13);
            tOTALLabel.TabIndex = 13;
            tOTALLabel.Text = "TOTAL:";
            // 
            // tAB_RESERVACIONESBindingNavigator
            // 
            this.tAB_RESERVACIONESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tAB_RESERVACIONESBindingNavigator.BindingSource = this.tAB_RESERVACIONESBindingSource;
            this.tAB_RESERVACIONESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_RESERVACIONESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tAB_RESERVACIONESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_RESERVACIONESBindingNavigatorSaveItem});
            this.tAB_RESERVACIONESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tAB_RESERVACIONESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tAB_RESERVACIONESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tAB_RESERVACIONESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tAB_RESERVACIONESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tAB_RESERVACIONESBindingNavigator.Name = "tAB_RESERVACIONESBindingNavigator";
            this.tAB_RESERVACIONESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_RESERVACIONESBindingNavigator.Size = new System.Drawing.Size(806, 25);
            this.tAB_RESERVACIONESBindingNavigator.TabIndex = 0;
            this.tAB_RESERVACIONESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // tAB_RESERVACIONESBindingSource
            // 
            this.tAB_RESERVACIONESBindingSource.DataMember = "TAB_RESERVACIONES";
            this.tAB_RESERVACIONESBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // bddvuelosDataSet
            // 
            this.bddvuelosDataSet.DataSetName = "bddvuelosDataSet";
            this.bddvuelosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tAB_RESERVACIONESBindingNavigatorSaveItem
            // 
            this.tAB_RESERVACIONESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tAB_RESERVACIONESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tAB_RESERVACIONESBindingNavigatorSaveItem.Image")));
            this.tAB_RESERVACIONESBindingNavigatorSaveItem.Name = "tAB_RESERVACIONESBindingNavigatorSaveItem";
            this.tAB_RESERVACIONESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tAB_RESERVACIONESBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tAB_RESERVACIONESBindingNavigatorSaveItem.Click += new System.EventHandler(this.tAB_RESERVACIONESBindingNavigatorSaveItem_Click);
            // 
            // iD_RESERVACIONLabel1
            // 
            this.iD_RESERVACIONLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_RESERVACIONESBindingSource, "ID_RESERVACION", true));
            this.iD_RESERVACIONLabel1.Location = new System.Drawing.Point(204, 36);
            this.iD_RESERVACIONLabel1.Name = "iD_RESERVACIONLabel1";
            this.iD_RESERVACIONLabel1.Size = new System.Drawing.Size(200, 23);
            this.iD_RESERVACIONLabel1.TabIndex = 2;
            this.iD_RESERVACIONLabel1.Text = "label1";
            // 
            // iD_CLIENTEComboBox
            // 
            this.iD_CLIENTEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAB_RESERVACIONESBindingSource, "ID_CLIENTE", true));
            this.iD_CLIENTEComboBox.DataSource = this.tAB_CLIENTESBindingSource;
            this.iD_CLIENTEComboBox.DisplayMember = "DATOS";
            this.iD_CLIENTEComboBox.FormattingEnabled = true;
            this.iD_CLIENTEComboBox.Location = new System.Drawing.Point(204, 62);
            this.iD_CLIENTEComboBox.Name = "iD_CLIENTEComboBox";
            this.iD_CLIENTEComboBox.Size = new System.Drawing.Size(200, 21);
            this.iD_CLIENTEComboBox.TabIndex = 4;
            this.iD_CLIENTEComboBox.ValueMember = "ID_CLIENTE";
            // 
            // tAB_CLIENTESBindingSource
            // 
            this.tAB_CLIENTESBindingSource.DataMember = "TAB_CLIENTES";
            this.tAB_CLIENTESBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // iD_VUELOComboBox
            // 
            this.iD_VUELOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAB_RESERVACIONESBindingSource, "ID_VUELO", true));
            this.iD_VUELOComboBox.DataSource = this.tAB_VUELOSBindingSource;
            this.iD_VUELOComboBox.DisplayMember = "CODIGO_VUELO";
            this.iD_VUELOComboBox.FormattingEnabled = true;
            this.iD_VUELOComboBox.Location = new System.Drawing.Point(204, 89);
            this.iD_VUELOComboBox.Name = "iD_VUELOComboBox";
            this.iD_VUELOComboBox.Size = new System.Drawing.Size(200, 21);
            this.iD_VUELOComboBox.TabIndex = 6;
            this.iD_VUELOComboBox.ValueMember = "ID_VUELO";
            // 
            // tAB_VUELOSBindingSource
            // 
            this.tAB_VUELOSBindingSource.DataMember = "TAB_VUELOS";
            this.tAB_VUELOSBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // fECHADateTimePicker
            // 
            this.fECHADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tAB_RESERVACIONESBindingSource, "FECHA", true));
            this.fECHADateTimePicker.Location = new System.Drawing.Point(204, 116);
            this.fECHADateTimePicker.Name = "fECHADateTimePicker";
            this.fECHADateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fECHADateTimePicker.TabIndex = 8;
            // 
            // sUBTOTALTextBox
            // 
            this.sUBTOTALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_RESERVACIONESBindingSource, "SUBTOTAL", true));
            this.sUBTOTALTextBox.Location = new System.Drawing.Point(480, 399);
            this.sUBTOTALTextBox.Name = "sUBTOTALTextBox";
            this.sUBTOTALTextBox.Size = new System.Drawing.Size(200, 20);
            this.sUBTOTALTextBox.TabIndex = 10;
            // 
            // iVATextBox
            // 
            this.iVATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_RESERVACIONESBindingSource, "IVA", true));
            this.iVATextBox.Location = new System.Drawing.Point(480, 425);
            this.iVATextBox.Name = "iVATextBox";
            this.iVATextBox.Size = new System.Drawing.Size(200, 20);
            this.iVATextBox.TabIndex = 12;
            // 
            // tOTALTextBox
            // 
            this.tOTALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_RESERVACIONESBindingSource, "TOTAL", true));
            this.tOTALTextBox.Location = new System.Drawing.Point(480, 451);
            this.tOTALTextBox.Name = "tOTALTextBox";
            this.tOTALTextBox.Size = new System.Drawing.Size(200, 20);
            this.tOTALTextBox.TabIndex = 14;
            // 
            // tAB_PLAZASBindingSource
            // 
            this.tAB_PLAZASBindingSource.DataMember = "FK_TAB_PLAZ_REFERENCE_TAB_RESE";
            this.tAB_PLAZASBindingSource.DataSource = this.tAB_RESERVACIONESBindingSource;
            // 
            // tAB_PLAZASDataGridView
            // 
            this.tAB_PLAZASDataGridView.AutoGenerateColumns = false;
            this.tAB_PLAZASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_PLAZASDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tAB_PLAZASDataGridView.DataSource = this.tAB_PLAZASBindingSource;
            this.tAB_PLAZASDataGridView.Location = new System.Drawing.Point(0, 189);
            this.tAB_PLAZASDataGridView.Name = "tAB_PLAZASDataGridView";
            this.tAB_PLAZASDataGridView.Size = new System.Drawing.Size(806, 153);
            this.tAB_PLAZASDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PLAZA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_PLAZA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_RESERVACION";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_RESERVACION";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID_TARJETA";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID_TARJETA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NRO_PLANTA";
            this.dataGridViewTextBoxColumn4.HeaderText = "NRO_PLANTA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FILA_ASIENTO";
            this.dataGridViewTextBoxColumn5.HeaderText = "FILA_ASIENTO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "COLUMNA_ASIENTO";
            this.dataGridViewTextBoxColumn6.HeaderText = "COLUMNA_ASIENTO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ASIGNADO_TARJETA";
            this.dataGridViewTextBoxColumn7.HeaderText = "ASIGNADO_TARJETA";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PRECIO";
            this.dataGridViewTextBoxColumn8.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // tAB_RESERVACIONESTableAdapter
            // 
            this.tAB_RESERVACIONESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_AEROPUERTOSTableAdapter = null;
            this.tableAdapterManager.TAB_CIUDADESTableAdapter = null;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = null;
            this.tableAdapterManager.TAB_PAISESTableAdapter = null;
            this.tableAdapterManager.TAB_PLAZASTableAdapter = null;
            this.tableAdapterManager.TAB_RESERVACIONESTableAdapter = this.tAB_RESERVACIONESTableAdapter;
            this.tableAdapterManager.TAB_ROLESTableAdapter = null;
            this.tableAdapterManager.TAB_TARJETAS_EMBARQUETableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.TAB_VUELOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_PLAZASTableAdapter
            // 
            this.tAB_PLAZASTableAdapter.ClearBeforeFill = true;
            // 
            // tAB_CLIENTESTableAdapter
            // 
            this.tAB_CLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // tAB_VUELOSTableAdapter
            // 
            this.tAB_VUELOSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 491);
            this.Controls.Add(this.tAB_PLAZASDataGridView);
            this.Controls.Add(iD_RESERVACIONLabel);
            this.Controls.Add(this.iD_RESERVACIONLabel1);
            this.Controls.Add(iD_CLIENTELabel);
            this.Controls.Add(this.iD_CLIENTEComboBox);
            this.Controls.Add(iD_VUELOLabel);
            this.Controls.Add(this.iD_VUELOComboBox);
            this.Controls.Add(fECHALabel);
            this.Controls.Add(this.fECHADateTimePicker);
            this.Controls.Add(sUBTOTALLabel);
            this.Controls.Add(this.sUBTOTALTextBox);
            this.Controls.Add(iVALabel);
            this.Controls.Add(this.iVATextBox);
            this.Controls.Add(tOTALLabel);
            this.Controls.Add(this.tOTALTextBox);
            this.Controls.Add(this.tAB_RESERVACIONESBindingNavigator);
            this.Name = "FrmReservaciones";
            this.Text = "FrmReservaciones";
            this.Load += new System.EventHandler(this.FrmReservaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RESERVACIONESBindingNavigator)).EndInit();
            this.tAB_RESERVACIONESBindingNavigator.ResumeLayout(false);
            this.tAB_RESERVACIONESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_RESERVACIONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_VUELOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PLAZASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PLAZASDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bddvuelosDataSet bddvuelosDataSet;
        private System.Windows.Forms.BindingSource tAB_RESERVACIONESBindingSource;
        private bddvuelosDataSetTableAdapters.TAB_RESERVACIONESTableAdapter tAB_RESERVACIONESTableAdapter;
        private bddvuelosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_RESERVACIONESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tAB_RESERVACIONESBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iD_RESERVACIONLabel1;
        private System.Windows.Forms.ComboBox iD_CLIENTEComboBox;
        private System.Windows.Forms.ComboBox iD_VUELOComboBox;
        private System.Windows.Forms.DateTimePicker fECHADateTimePicker;
        private System.Windows.Forms.TextBox sUBTOTALTextBox;
        private System.Windows.Forms.TextBox iVATextBox;
        private System.Windows.Forms.TextBox tOTALTextBox;
        private System.Windows.Forms.BindingSource tAB_PLAZASBindingSource;
        private bddvuelosDataSetTableAdapters.TAB_PLAZASTableAdapter tAB_PLAZASTableAdapter;
        private System.Windows.Forms.DataGridView tAB_PLAZASDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource tAB_CLIENTESBindingSource;
        private bddvuelosDataSetTableAdapters.TAB_CLIENTESTableAdapter tAB_CLIENTESTableAdapter;
        private System.Windows.Forms.BindingSource tAB_VUELOSBindingSource;
        private bddvuelosDataSetTableAdapters.TAB_VUELOSTableAdapter tAB_VUELOSTableAdapter;
    }
}