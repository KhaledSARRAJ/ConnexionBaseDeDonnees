using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonchercher_Click(object sender, EventArgs e)
        {
            string mc = textBoxmc.Text;

            //l'emplacement de serveur\\ nom de serveur : nom de la base de données\\la connexion néssécite un mot de pas ou non si non true
            String str = "Data Source= (localdb)\\MSSQLLocalDB;Initial Catalog=test;Integrated Security=yes";
            IDbConnection con = new SqlConnection(str);
            IDbCommand cmd = con.CreateCommand();
            string req = "select * from PRODUIT where PRIX like @x";
            SqlParameter p1 = new SqlParameter("@x","%"+mc+"%");
            cmd.CommandText = req;
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(p1);
            DataSet ds = new DataSet();
            IDbDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            dataGridViewProduit.DataSource = ds.Tables[0];

        }
    }
}
