using System;
using System.Data;
using System.Data.SqlClient;
namespace DB3
{
    class Program
    {
        static void Main(string[] args)
        {
            //l'emplacement de serveur\\ nom de serveur : nom de la base de données\\la connexion néssécite un mot de pas ou non si non true
            String str = "Data Source= (localdb)\\MSSQLLocalDB;Initial Catalog=test;Integrated Security=yes";
            IDbConnection con = new SqlConnection(str);
            IDbCommand cmd = con.CreateCommand();
            string req = "select * from PRODUIT";
            cmd.CommandText = req;
            cmd.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            IDbDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;        
            da.Fill(ds);

            foreach(DataColumn dc in ds.Tables[0].Columns)
            {
                Console.Write(dc.ColumnName+ "\t");

            }
            Console.WriteLine();

            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                foreach (DataColumn dc in ds.Tables[0].Columns)
                {
                    Console.Write(dr[dc.ColumnName] + "\t");

                }
            Console.WriteLine();
            }
            

        }
    }
}
