
namespace DB5Applicationbureau
{
    partial class formcategoriee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formcategoriee));
            System.Windows.Forms.Label iD_CATLabel;
            System.Windows.Forms.Label nOMLabel;
            this.testDataSet = new DB5Applicationbureau.testDataSet();
            this.cATALOGUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATALOGUETableAdapter = new DB5Applicationbureau.testDataSetTableAdapters.CATALOGUETableAdapter();
            this.tableAdapterManager = new DB5Applicationbureau.testDataSetTableAdapters.TableAdapterManager();
            this.cATALOGUEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cATALOGUEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pRODUITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUITTableAdapter = new DB5Applicationbureau.testDataSetTableAdapters.PRODUITTableAdapter();
            this.iD_CATTextBox = new System.Windows.Forms.TextBox();
            this.nOMTextBox = new System.Windows.Forms.TextBox();
            this.pRODUITDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_CATLabel = new System.Windows.Forms.Label();
            nOMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGUEBindingNavigator)).BeginInit();
            this.cATALOGUEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUITDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATALOGUEBindingSource
            // 
            this.cATALOGUEBindingSource.DataMember = "CATALOGUE";
            this.cATALOGUEBindingSource.DataSource = this.testDataSet;
            // 
            // cATALOGUETableAdapter
            // 
            this.cATALOGUETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATALOGUETableAdapter = this.cATALOGUETableAdapter;
            this.tableAdapterManager.PRODUITTableAdapter = this.pRODUITTableAdapter;
            this.tableAdapterManager.UpdateOrder = DB5Applicationbureau.testDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cATALOGUEBindingNavigator
            // 
            this.cATALOGUEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cATALOGUEBindingNavigator.BindingSource = this.cATALOGUEBindingSource;
            this.cATALOGUEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cATALOGUEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cATALOGUEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cATALOGUEBindingNavigatorSaveItem});
            this.cATALOGUEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cATALOGUEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cATALOGUEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cATALOGUEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cATALOGUEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cATALOGUEBindingNavigator.Name = "cATALOGUEBindingNavigator";
            this.cATALOGUEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cATALOGUEBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.cATALOGUEBindingNavigator.TabIndex = 0;
            this.cATALOGUEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
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
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
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
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // cATALOGUEBindingNavigatorSaveItem
            // 
            this.cATALOGUEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cATALOGUEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cATALOGUEBindingNavigatorSaveItem.Image")));
            this.cATALOGUEBindingNavigatorSaveItem.Name = "cATALOGUEBindingNavigatorSaveItem";
            this.cATALOGUEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cATALOGUEBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.cATALOGUEBindingNavigatorSaveItem.Click += new System.EventHandler(this.cATALOGUEBindingNavigatorSaveItem_Click);
            // 
            // pRODUITBindingSource
            // 
            this.pRODUITBindingSource.DataMember = "PRODUIT";
            this.pRODUITBindingSource.DataSource = this.testDataSet;
            // 
            // pRODUITTableAdapter
            // 
            this.pRODUITTableAdapter.ClearBeforeFill = true;
            // 
            // iD_CATLabel
            // 
            iD_CATLabel.AutoSize = true;
            iD_CATLabel.Location = new System.Drawing.Point(349, 111);
            iD_CATLabel.Name = "iD_CATLabel";
            iD_CATLabel.Size = new System.Drawing.Size(45, 13);
            iD_CATLabel.TabIndex = 1;
            iD_CATLabel.Text = "ID CAT:";
            // 
            // iD_CATTextBox
            // 
            this.iD_CATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cATALOGUEBindingSource, "ID_CAT", true));
            this.iD_CATTextBox.Location = new System.Drawing.Point(400, 108);
            this.iD_CATTextBox.Name = "iD_CATTextBox";
            this.iD_CATTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_CATTextBox.TabIndex = 2;
            // 
            // nOMLabel
            // 
            nOMLabel.AutoSize = true;
            nOMLabel.Location = new System.Drawing.Point(349, 137);
            nOMLabel.Name = "nOMLabel";
            nOMLabel.Size = new System.Drawing.Size(35, 13);
            nOMLabel.TabIndex = 3;
            nOMLabel.Text = "NOM:";
            // 
            // nOMTextBox
            // 
            this.nOMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cATALOGUEBindingSource, "NOM", true));
            this.nOMTextBox.Location = new System.Drawing.Point(400, 134);
            this.nOMTextBox.Name = "nOMTextBox";
            this.nOMTextBox.Size = new System.Drawing.Size(100, 20);
            this.nOMTextBox.TabIndex = 4;
            // 
            // pRODUITDataGridView
            // 
            this.pRODUITDataGridView.AutoGenerateColumns = false;
            this.pRODUITDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRODUITDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pRODUITDataGridView.DataSource = this.pRODUITBindingSource;
            this.pRODUITDataGridView.Location = new System.Drawing.Point(292, 206);
            this.pRODUITDataGridView.Name = "pRODUITDataGridView";
            this.pRODUITDataGridView.Size = new System.Drawing.Size(469, 341);
            this.pRODUITDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PRO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_PRO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "QUANTITE";
            this.dataGridViewTextBoxColumn2.HeaderText = "QUANTITE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRIX";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRIX";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_CAT";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID_CAT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // formcategoriee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.pRODUITDataGridView);
            this.Controls.Add(iD_CATLabel);
            this.Controls.Add(this.iD_CATTextBox);
            this.Controls.Add(nOMLabel);
            this.Controls.Add(this.nOMTextBox);
            this.Controls.Add(this.cATALOGUEBindingNavigator);
            this.Name = "formcategoriee";
            this.Text = "formcategoriee";
            this.Load += new System.EventHandler(this.formcategoriee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGUEBindingNavigator)).EndInit();
            this.cATALOGUEBindingNavigator.ResumeLayout(false);
            this.cATALOGUEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUITDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource cATALOGUEBindingSource;
        private testDataSetTableAdapters.CATALOGUETableAdapter cATALOGUETableAdapter;
        private testDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cATALOGUEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cATALOGUEBindingNavigatorSaveItem;
        private testDataSetTableAdapters.PRODUITTableAdapter pRODUITTableAdapter;
        private System.Windows.Forms.BindingSource pRODUITBindingSource;
        private System.Windows.Forms.TextBox iD_CATTextBox;
        private System.Windows.Forms.TextBox nOMTextBox;
        private System.Windows.Forms.DataGridView pRODUITDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}