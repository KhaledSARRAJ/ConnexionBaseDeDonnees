
namespace DB5Applicationbureau
{
    partial class produitsform
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.testDataSet = new DB5Applicationbureau.testDataSet();
            this.cATALOGUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATALOGUETableAdapter = new DB5Applicationbureau.testDataSetTableAdapters.CATALOGUETableAdapter();
            this.tableAdapterManager = new DB5Applicationbureau.testDataSetTableAdapters.TableAdapterManager();
            this.pRODUITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUITTableAdapter = new DB5Applicationbureau.testDataSetTableAdapters.PRODUITTableAdapter();
            this.pRODUITDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUITDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cATALOGUEBindingSource;
            this.comboBox1.DisplayMember = "NOM";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(282, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID_CAT";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // pRODUITBindingSource
            // 
            this.pRODUITBindingSource.DataMember = "PRODUIT";
            this.pRODUITBindingSource.DataSource = this.testDataSet;
            // 
            // pRODUITTableAdapter
            // 
            this.pRODUITTableAdapter.ClearBeforeFill = true;
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
            this.pRODUITDataGridView.Location = new System.Drawing.Point(282, 107);
            this.pRODUITDataGridView.Name = "pRODUITDataGridView";
            this.pRODUITDataGridView.Size = new System.Drawing.Size(300, 220);
            this.pRODUITDataGridView.TabIndex = 1;
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
            // produitsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pRODUITDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Name = "produitsform";
            this.Text = "produitsform";
            this.Load += new System.EventHandler(this.produitsform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUITDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource cATALOGUEBindingSource;
        private testDataSetTableAdapters.CATALOGUETableAdapter cATALOGUETableAdapter;
        private testDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private testDataSetTableAdapters.PRODUITTableAdapter pRODUITTableAdapter;
        private System.Windows.Forms.BindingSource pRODUITBindingSource;
        private System.Windows.Forms.DataGridView pRODUITDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}