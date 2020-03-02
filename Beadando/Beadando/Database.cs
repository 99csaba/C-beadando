using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    class Database
    {
        public bool IsConnected { get; set; } = false;


        private string connectionString = "Integrated Security=true;" +
                                          @"server=(localdb)\MSSQLLocalDB;" +
                                          "Trusted_Connection=yes;" +
                                          "database=music; " +
                                          "connection timeout=30";
        SqlConnection myConnection;

        public Database() {
            EstablishConnection();
        }

        private void EstablishConnection()
        {
            if (!IsConnected)
            {
                try
                {
                    myConnection = new SqlConnection(this.connectionString);
                    myConnection.Open();
                    this.IsConnected = true;
                }
                catch (Exception)
                {
                    this.IsConnected = false;
                    throw;
                }
            }


        }

    /*    public void GetBlogPostWithID(int ID)
        {
            SqlCommand command = new SqlCommand("SELECT headline, content FROM TBL_BlogPost WHERE blogpost_id = @ID;", myConnection);
            command.Parameters.AddWithValue("@ID", ID);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("Data: ");
                Console.WriteLine(reader.GetValue(0).ToString());
                Console.WriteLine(reader.GetValue(1).ToString());
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public void GetBlogPostData()
        {
            SqlCommand command = new SqlCommand("SELECT headline, content FROM TBL_BlogPost;", myConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("Data: ");
                Console.WriteLine(reader.GetValue(0).ToString());
                Console.WriteLine(reader.GetValue(1).ToString());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        */
        public void test(int id)
        {
            SqlCommand asdasd = new SqlCommand("Select title, lenght from Tracks where id = @id",myConnection);
            asdasd.Parameters.AddWithValue("@id",id);
            SqlDataReader béla = asdasd.ExecuteReader();


            while (béla.Read())
            {
                Console.WriteLine("Adatok amiket az Ádi kért:");
                Console.WriteLine(béla.GetValue(0).ToString());
                Console.WriteLine(béla.GetValue(1).ToString());
            }
        }
     }
}
