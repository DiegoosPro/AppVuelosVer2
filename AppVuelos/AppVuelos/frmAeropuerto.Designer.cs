namespace AppVuelos
{
    partial class frmAeropuerto
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
            System.Windows.Forms.Label iD_AEROPUERTOLabel;
            System.Windows.Forms.Label iD_CIUDADLabel;
            System.Windows.Forms.Label cODIGO_AEROPUERTOLabel;
            System.Windows.Forms.Label nOMBRE_AEROPUERTOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAeropuerto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tAB_AEROPUERTOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tAB_AEROPUERTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tAB_AEROPUERTOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_AEROPUERTOLabel1 = new System.Windows.Forms.Label();
            this.iD_CIUDADComboBox = new System.Windows.Forms.ComboBox();
            this.tAB_CIUDADESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cODIGO_AEROPUERTOTextBox = new System.Windows.Forms.TextBox();
            this.nOMBRE_AEROPUERTOTextBox = new System.Windows.Forms.TextBox();
            this.tAB_AEROPUERTOSTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_AEROPUERTOSTableAdapter();
            this.tableAdapterManager = new AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager();
            this.tAB_CIUDADESTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_CIUDADESTableAdapter();
            this.tAB_AEROPUERTOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_AEROPUERTOLabel = new System.Windows.Forms.Label();
            iD_CIUDADLabel = new System.Windows.Forms.Label();
            cODIGO_AEROPUERTOLabel = new System.Windows.Forms.Label();
            nOMBRE_AEROPUERTOLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_AEROPUERTOSBindingNavigator)).BeginInit();
            this.tAB_AEROPUERTOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_AEROPUERTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_AEROPUERTOSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_AEROPUERTOLabel
            // 
            iD_AEROPUERTOLabel.AutoSize = true;
            iD_AEROPUERTOLabel.Location = new System.Drawing.Point(137, 61);
            iD_AEROPUERTOLabel.Name = "iD_AEROPUERTOLabel";
            iD_AEROPUERTOLabel.Size = new System.Drawing.Size(99, 13);
            iD_AEROPUERTOLabel.TabIndex = 0;
            iD_AEROPUERTOLabel.Text = "ID AEROPUERTO:";
            // 
            // iD_CIUDADLabel
            // 
            iD_CIUDADLabel.AutoSize = true;
            iD_CIUDADLabel.Location = new System.Drawing.Point(137, 90);
            iD_CIUDADLabel.Name = "iD_CIUDADLabel";
            iD_CIUDADLabel.Size = new System.Drawing.Size(65, 13);
            iD_CIUDADLabel.TabIndex = 2;
            iD_CIUDADLabel.Text = "ID CIUDAD:";
            // 
            // cODIGO_AEROPUERTOLabel
            // 
            cODIGO_AEROPUERTOLabel.AutoSize = true;
            cODIGO_AEROPUERTOLabel.Location = new System.Drawing.Point(137, 117);
            cODIGO_AEROPUERTOLabel.Name = "cODIGO_AEROPUERTOLabel";
            cODIGO_AEROPUERTOLabel.Size = new System.Drawing.Size(130, 13);
            cODIGO_AEROPUERTOLabel.TabIndex = 4;
            cODIGO_AEROPUERTOLabel.Text = "CODIGO AEROPUERTO:";
            // 
            // nOMBRE_AEROPUERTOLabel
            // 
            nOMBRE_AEROPUERTOLabel.AutoSize = true;
            nOMBRE_AEROPUERTOLabel.Location = new System.Drawing.Point(137, 143);
            nOMBRE_AEROPUERTOLabel.Name = "nOMBRE_AEROPUERTOLabel";
            nOMBRE_AEROPUERTOLabel.Size = new System.Drawing.Size(135, 13);
            nOMBRE_AEROPUERTOLabel.TabIndex = 6;
            nOMBRE_AEROPUERTOLabel.Text = "NOMBRE AEROPUERTO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTodos);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(461, 46);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(379, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(261, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(144, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar código o nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tAB_AEROPUERTOSBindingNavigator);
            this.groupBox2.Controls.Add(iD_AEROPUERTOLabel);
            this.groupBox2.Controls.Add(this.iD_AEROPUERTOLabel1);
            this.groupBox2.Controls.Add(iD_CIUDADLabel);
            this.groupBox2.Controls.Add(this.iD_CIUDADComboBox);
            this.groupBox2.Controls.Add(cODIGO_AEROPUERTOLabel);
            this.groupBox2.Controls.Add(this.cODIGO_AEROPUERTOTextBox);
            this.groupBox2.Controls.Add(nOMBRE_AEROPUERTOLabel);
            this.groupBox2.Controls.Add(this.nOMBRE_AEROPUERTOTextBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editar";
            // 
            // tAB_AEROPUERTOSBindingNavigator
            // 
            this.tAB_AEROPUERTOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tAB_AEROPUERTOSBindingNavigator.BindingSource = this.tAB_AEROPUERTOSBindingSource;
            this.tAB_AEROPUERTOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_AEROPUERTOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tAB_AEROPUERTOSBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tAB_AEROPUERTOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_AEROPUERTOSBindingNavigatorSaveItem});
            this.tAB_AEROPUERTOSBindingNavigator.Location = new System.Drawing.Point(128, 16);
            this.tAB_AEROPUERTOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tAB_AEROPUERTOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tAB_AEROPUERTOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tAB_AEROPUERTOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tAB_AEROPUERTOSBindingNavigator.Name = "tAB_AEROPUERTOSBindingNavigator";
            this.tAB_AEROPUERTOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_AEROPUERTOSBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.tAB_AEROPUERTOSBindingNavigator.TabIndex = 2;
            this.tAB_AEROPUERTOSBindingNavigator.Text = "bindingNavigator1";
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
            // tAB_AEROPUERTOSBindingSource
            // 
            this.tAB_AEROPUERTOSBindingSource.DataMember = "TAB_AEROPUERTOS";
            this.tAB_AEROPUERTOSBindingSource.DataSource = this.bddvuelosDataSet;
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
            // tAB_AEROPUERTOSBindingNavigatorSaveItem
            // 
            this.tAB_AEROPUERTOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tAB_AEROPUERTOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tAB_AEROPUERTOSBindingNavigatorSaveItem.Image")));
            this.tAB_AEROPUERTOSBindingNavigatorSaveItem.Name = "tAB_AEROPUERTOSBindingNavigatorSaveItem";
            this.tAB_AEROPUERTOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tAB_AEROPUERTOSBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tAB_AEROPUERTOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.tAB_AEROPUERTOSBindingNavigatorSaveItem_Click);
            // 
            // iD_AEROPUERTOLabel1
            // 
            this.iD_AEROPUERTOLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_AEROPUERTOSBindingSource, "ID_AEROPUERTO", true));
            this.iD_AEROPUERTOLabel1.Location = new System.Drawing.Point(278, 61);
            this.iD_AEROPUERTOLabel1.Name = "iD_AEROPUERTOLabel1";
            this.iD_AEROPUERTOLabel1.Size = new System.Drawing.Size(121, 23);
            this.iD_AEROPUERTOLabel1.TabIndex = 1;
            this.iD_AEROPUERTOLabel1.Text = "label2";
            // 
            // iD_CIUDADComboBox
            // 
            this.iD_CIUDADComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAB_AEROPUERTOSBindingSource, "ID_CIUDAD", true));
            this.iD_CIUDADComboBox.DataSource = this.tAB_CIUDADESBindingSource;
            this.iD_CIUDADComboBox.DisplayMember = "CIUDAD";
            this.iD_CIUDADComboBox.FormattingEnabled = true;
            this.iD_CIUDADComboBox.Location = new System.Drawing.Point(278, 87);
            this.iD_CIUDADComboBox.Name = "iD_CIUDADComboBox";
            this.iD_CIUDADComboBox.Size = new System.Drawing.Size(121, 21);
            this.iD_CIUDADComboBox.TabIndex = 3;
            this.iD_CIUDADComboBox.ValueMember = "ID_CIUDAD";
            // 
            // tAB_CIUDADESBindingSource
            // 
            this.tAB_CIUDADESBindingSource.DataMember = "TAB_CIUDADES";
            this.tAB_CIUDADESBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // cODIGO_AEROPUERTOTextBox
            // 
            this.cODIGO_AEROPUERTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_AEROPUERTOSBindingSource, "CODIGO_AEROPUERTO", true));
            this.cODIGO_AEROPUERTOTextBox.Location = new System.Drawing.Point(278, 114);
            this.cODIGO_AEROPUERTOTextBox.Name = "cODIGO_AEROPUERTOTextBox";
            this.cODIGO_AEROPUERTOTextBox.Size = new System.Drawing.Size(121, 20);
            this.cODIGO_AEROPUERTOTextBox.TabIndex = 5;
            // 
            // nOMBRE_AEROPUERTOTextBox
            // 
            this.nOMBRE_AEROPUERTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_AEROPUERTOSBindingSource, "NOMBRE_AEROPUERTO", true));
            this.nOMBRE_AEROPUERTOTextBox.Location = new System.Drawing.Point(278, 140);
            this.nOMBRE_AEROPUERTOTextBox.Name = "nOMBRE_AEROPUERTOTextBox";
            this.nOMBRE_AEROPUERTOTextBox.Size = new System.Drawing.Size(121, 20);
            this.nOMBRE_AEROPUERTOTextBox.TabIndex = 7;
            // 
            // tAB_AEROPUERTOSTableAdapter
            // 
            this.tAB_AEROPUERTOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_AEROPUERTOSTableAdapter = this.tAB_AEROPUERTOSTableAdapter;
            this.tableAdapterManager.TAB_CIUDADESTableAdapter = this.tAB_CIUDADESTableAdapter;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = null;
            this.tableAdapterManager.TAB_PAISESTableAdapter = null;
            this.tableAdapterManager.TAB_PLAZASTableAdapter = null;
            this.tableAdapterManager.TAB_RESERVACIONESTableAdapter = null;
            this.tableAdapterManager.TAB_TARJETAS_EMBARQUETableAdapter = null;
            this.tableAdapterManager.TAB_VUELOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_CIUDADESTableAdapter
            // 
            this.tAB_CIUDADESTableAdapter.ClearBeforeFill = true;
            // 
            // tAB_AEROPUERTOSDataGridView
            // 
            this.tAB_AEROPUERTOSDataGridView.AutoGenerateColumns = false;
            this.tAB_AEROPUERTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_AEROPUERTOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tAB_AEROPUERTOSDataGridView.DataSource = this.tAB_AEROPUERTOSBindingSource;
            this.tAB_AEROPUERTOSDataGridView.Location = new System.Drawing.Point(13, 352);
            this.tAB_AEROPUERTOSDataGridView.Name = "tAB_AEROPUERTOSDataGridView";
            this.tAB_AEROPUERTOSDataGridView.Size = new System.Drawing.Size(563, 220);
            this.tAB_AEROPUERTOSDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_AEROPUERTO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_AEROPUERTO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_CIUDAD";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_CIUDAD";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CODIGO_AEROPUERTO";
            this.dataGridViewTextBoxColumn3.HeaderText = "CODIGO_AEROPUERTO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NOMBRE_AEROPUERTO";
            this.dataGridViewTextBoxColumn4.HeaderText = "NOMBRE_AEROPUERTO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frmAeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(617, 595);
            this.Controls.Add(this.tAB_AEROPUERTOSDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAeropuerto";
            this.Text = "frmAeropuerto";
            this.Load += new System.EventHandler(this.frmAeropuerto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_AEROPUERTOSBindingNavigator)).EndInit();
            this.tAB_AEROPUERTOSBindingNavigator.ResumeLayout(false);
            this.tAB_AEROPUERTOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_AEROPUERTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_AEROPUERTOSDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private bddvuelosDataSet bddvuelosDataSet;
        private System.Windows.Forms.BindingSource tAB_AEROPUERTOSBindingSource;
        private bddvuelosDataSetTableAdapters.TAB_AEROPUERTOSTableAdapter tAB_AEROPUERTOSTableAdapter;
        private bddvuelosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_AEROPUERTOSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tAB_AEROPUERTOSBindingNavigatorSaveItem;
        private System.Windows.Forms.Label iD_AEROPUERTOLabel1;
        private System.Windows.Forms.ComboBox iD_CIUDADComboBox;
        private System.Windows.Forms.TextBox cODIGO_AEROPUERTOTextBox;
        private System.Windows.Forms.TextBox nOMBRE_AEROPUERTOTextBox;
        private System.Windows.Forms.DataGridView tAB_AEROPUERTOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private bddvuelosDataSetTableAdapters.TAB_CIUDADESTableAdapter tAB_CIUDADESTableAdapter;
        private System.Windows.Forms.BindingSource tAB_CIUDADESBindingSource;
    }
}