using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB5Applicationbureau;
namespace DB5Applicationbureau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formcategoriee f = new formcategoriee();
            f.ShowDialog();
        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produitsform a = new produitsform();
            a.ShowDialog();
        }
    }
}
