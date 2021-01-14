using System;
using System.Data.SqlClient;
using System.Data;
namespace DB2
{
    class Program
    {
        static void Main(string[] args)
        {
            //l'emplacement de serveur\\ nom de serveur : nom de la base de données\\la connexion néssécite un mot de pas ou non si non true
            String str = "Data Source= (localdb)\\MSSQLLocalDB;Initial Catalog=test;Integrated Security=yes";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlTransaction tx = conn.BeginTransaction();
            try { 
            SqlCommand cmd = new SqlCommand
           ("INSERT into CATALOGUE(NOM) values(@a)", conn);
          // ("SELECT * FROM CATALOGUE WHERE NOM like @d", conn);
            SqlParameter p1 = new SqlParameter("@a", "KhaledTest");
            cmd.Parameters.Add(p1);
            cmd.Transaction = tx;
            cmd.ExecuteNonQuery();
            tx.Commit();
              }
            catch
            (Exception e)
            {
                tx.Rollback();
                Console.WriteLine(e.Message);
            }
        }
    }
}
