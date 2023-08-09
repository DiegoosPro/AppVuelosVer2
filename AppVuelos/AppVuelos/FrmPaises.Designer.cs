namespace AppVuelos
{
    partial class FrmPaises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaises));
            System.Windows.Forms.Label iD_PAISLabel;
            System.Windows.Forms.Label pAISLabel;
            this.bddvuelosDataSet = new AppVuelos.bddvuelosDataSet();
            this.tAB_PAISESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_PAISESTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_PAISESTableAdapter();
            this.tableAdapterManager = new AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager();
            this.tAB_PAISESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tAB_PAISESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_PAISTextBox = new System.Windows.Forms.TextBox();
            this.pAISTextBox = new System.Windows.Forms.TextBox();
            this.tAB_CIUDADESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAB_CIUDADESTableAdapter = new AppVuelos.bddvuelosDataSetTableAdapters.TAB_CIUDADESTableAdapter();
            this.tAB_CIUDADESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_PAISLabel = new System.Windows.Forms.Label();
            pAISLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PAISESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PAISESBindingNavigator)).BeginInit();
            this.tAB_PAISESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bddvuelosDataSet
            // 
            this.bddvuelosDataSet.DataSetName = "bddvuelosDataSet";
            this.bddvuelosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAB_PAISESBindingSource
            // 
            this.tAB_PAISESBindingSource.DataMember = "TAB_PAISES";
            this.tAB_PAISESBindingSource.DataSource = this.bddvuelosDataSet;
            // 
            // tAB_PAISESTableAdapter
            // 
            this.tAB_PAISESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TAB_AEROPUERTOSTableAdapter = null;
            this.tableAdapterManager.TAB_CIUDADESTableAdapter = this.tAB_CIUDADESTableAdapter;
            this.tableAdapterManager.TAB_CLIENTESTableAdapter = null;
            this.tableAdapterManager.TAB_PAISESTableAdapter = this.tAB_PAISESTableAdapter;
            this.tableAdapterManager.TAB_PLAZASTableAdapter = null;
            this.tableAdapterManager.TAB_RESERVACIONESTableAdapter = null;
            this.tableAdapterManager.TAB_ROLESTableAdapter = null;
            this.tableAdapterManager.TAB_TARJETAS_EMBARQUETableAdapter = null;
            this.tableAdapterManager.TAB_USUARIOSTableAdapter = null;
            this.tableAdapterManager.TAB_VUELOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppVuelos.bddvuelosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAB_PAISESBindingNavigator
            // 
            this.tAB_PAISESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tAB_PAISESBindingNavigator.BindingSource = this.tAB_PAISESBindingSource;
            this.tAB_PAISESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAB_PAISESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tAB_PAISESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAB_PAISESBindingNavigatorSaveItem});
            this.tAB_PAISESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tAB_PAISESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tAB_PAISESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tAB_PAISESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tAB_PAISESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tAB_PAISESBindingNavigator.Name = "tAB_PAISESBindingNavigator";
            this.tAB_PAISESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAB_PAISESBindingNavigator.Size = new System.Drawing.Size(694, 25);
            this.tAB_PAISESBindingNavigator.TabIndex = 0;
            this.tAB_PAISESBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // tAB_PAISESBindingNavigatorSaveItem
            // 
            this.tAB_PAISESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tAB_PAISESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tAB_PAISESBindingNavigatorSaveItem.Image")));
            this.tAB_PAISESBindingNavigatorSaveItem.Name = "tAB_PAISESBindingNavigatorSaveItem";
            this.tAB_PAISESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tAB_PAISESBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tAB_PAISESBindingNavigatorSaveItem.Click += new System.EventHandler(this.tAB_PAISESBindingNavigatorSaveItem_Click_3);
            // 
            // iD_PAISLabel
            // 
            iD_PAISLabel.AutoSize = true;
            iD_PAISLabel.Location = new System.Drawing.Point(75, 69);
            iD_PAISLabel.Name = "iD_PAISLabel";
            iD_PAISLabel.Size = new System.Drawing.Size(48, 13);
            iD_PAISLabel.TabIndex = 1;
            iD_PAISLabel.Text = "ID PAIS:";
            // 
            // iD_PAISTextBox
            // 
            this.iD_PAISTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PAISESBindingSource, "ID_PAIS", true));
            this.iD_PAISTextBox.Location = new System.Drawing.Point(129, 66);
            this.iD_PAISTextBox.Name = "iD_PAISTextBox";
            this.iD_PAISTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_PAISTextBox.TabIndex = 2;
            // 
            // pAISLabel
            // 
            pAISLabel.AutoSize = true;
            pAISLabel.Location = new System.Drawing.Point(75, 95);
            pAISLabel.Name = "pAISLabel";
            pAISLabel.Size = new System.Drawing.Size(34, 13);
            pAISLabel.TabIndex = 3;
            pAISLabel.Text = "PAIS:";
            // 
            // pAISTextBox
            // 
            this.pAISTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAB_PAISESBindingSource, "PAIS", true));
            this.pAISTextBox.Location = new System.Drawing.Point(129, 92);
            this.pAISTextBox.Name = "pAISTextBox";
            this.pAISTextBox.Size = new System.Drawing.Size(100, 20);
            this.pAISTextBox.TabIndex = 4;
            // 
            // tAB_CIUDADESBindingSource
            // 
            this.tAB_CIUDADESBindingSource.DataMember = "FK_TAB_CIUD_REFERENCE_TAB_PAIS";
            this.tAB_CIUDADESBindingSource.DataSource = this.tAB_PAISESBindingSource;
            // 
            // tAB_CIUDADESTableAdapter
            // 
            this.tAB_CIUDADESTableAdapter.ClearBeforeFill = true;
            // 
            // tAB_CIUDADESDataGridView
            // 
            this.tAB_CIUDADESDataGridView.AutoGenerateColumns = false;
            this.tAB_CIUDADESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAB_CIUDADESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tAB_CIUDADESDataGridView.DataSource = this.tAB_CIUDADESBindingSource;
            this.tAB_CIUDADESDataGridView.Location = new System.Drawing.Point(54, 168);
            this.tAB_CIUDADESDataGridView.Name = "tAB_CIUDADESDataGridView";
            this.tAB_CIUDADESDataGridView.Size = new System.Drawing.Size(552, 134);
            this.tAB_CIUDADESDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CIUDAD";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_CIUDAD";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_PAIS";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_PAIS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CIUDAD";
            this.dataGridViewTextBoxColumn3.HeaderText = "CIUDAD";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FrmPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 408);
            this.Controls.Add(this.tAB_CIUDADESDataGridView);
            this.Controls.Add(iD_PAISLabel);
            this.Controls.Add(this.iD_PAISTextBox);
            this.Controls.Add(pAISLabel);
            this.Controls.Add(this.pAISTextBox);
            this.Controls.Add(this.tAB_PAISESBindingNavigator);
            this.Name = "FrmPaises";
            this.Text = "FrmPaises";
            this.Load += new System.EventHandler(this.FrmPaises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PAISESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_PAISESBindingNavigator)).EndInit();
            this.tAB_PAISESBindingNavigator.ResumeLayout(false);
            this.tAB_PAISESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAB_CIUDADESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bddvuelosDataSet bddvuelosDataSet;
        private System.Windows.Forms.BindingSource tAB_PAISESBindingSource;
        private bddvuelosDataSetTableAdapters.TAB_PAISESTableAdapter tAB_PAISESTableAdapter;
        private bddvuelosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAB_PAISESBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tAB_PAISESBindingNavigatorSaveItem;
        private bddvuelosDataSetTableAdapters.TAB_CIUDADESTableAdapter tAB_CIUDADESTableAdapter;
        private System.Windows.Forms.TextBox iD_PAISTextBox;
        private System.Windows.Forms.TextBox pAISTextBox;
        private System.Windows.Forms.BindingSource tAB_CIUDADESBindingSource;
        private System.Windows.Forms.DataGridView tAB_CIUDADESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;



    }
}