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
    public partial class produitsform : Form
    {
        public produitsform()
        {
            InitializeComponent();
        }

        private void produitsform_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'testDataSet.PRODUIT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.pRODUITTableAdapter.Fill(this.testDataSet.PRODUIT);
            // TODO: cette ligne de code charge les données dans la table 'testDataSet.CATALOGUE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cATALOGUETableAdapter.Fill(this.testDataSet.CATALOGUE);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //creer un data view, apartir table 1 (produit) quant id categorie selectionner dans le combo box, trier par nom, et qui se trouve avec la table courrant
            DataView dv = new DataView(testDataSet.Tables[1], "ID_CAT=" + comboBox1.SelectedValue, "ID_CAT asc", DataViewRowState.CurrentRows);
            pRODUITDataGridView.DataSource = dv;
        }
    }
}
