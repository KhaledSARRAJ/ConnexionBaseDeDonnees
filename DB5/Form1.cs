using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB5
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategorie f = new FormCategorie();
        }
    }
}
