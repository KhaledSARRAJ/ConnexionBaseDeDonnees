using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnexionBaseDeDonnees
{
    class Program
    {
        static void Main(string[] args)
        {
            //l'emplacement de serveur\\ nom de serveur : nom de la base de données\\la connexion néssécite un mot de pas ou non si non true
            String str = "Data Source= (localdb)\\MSSQLLocalDB;Initial Catalog=test;Integrated Security=yes";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand
           //("SELECT TOP (10) [ID_CAT] ,[NOM] FROM [test].[dbo].[CATALOGUE]", conn);
           ("SELECT * FROM CATALOGUE WHERE NOM like @d", conn);
            SqlParameter p1 = new SqlParameter("@d", "%S%");
            cmd.Parameters.Add(p1);
            SqlDataReader dr = cmd.ExecuteReader();
            //lire ligne par ligne
            while(dr.Read())
            {
                Console.WriteLine(dr.GetString(1));
            }
            dr.Close();
            conn.Close();
        }
    }
}
