using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB5Applicationbureau
{
    public partial class formcategoriee : Form
    {
        public formcategoriee()
        {
            InitializeComponent();
        }

        private void formcategoriee_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'testDataSet.PRODUIT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pRODUITTableAdapter.Fill(this.testDataSet.PRODUIT);
            // TODO: cette ligne de code charge les données dans la table 'testDataSet.CATALOGUE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cATALOGUETableAdapter.Fill(this.testDataSet.CATALOGUE);

        }

        private void cATALOGUEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cATALOGUEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDataSet);

        }
    }
}
