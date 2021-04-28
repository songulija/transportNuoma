using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportoNuoma.Classes;

namespace TransportoNuoma.Repositories
{
    class TransTestRepository
    {
        string connectionString = "server=34.91.29.158;user id=root;persistsecurityinfo=True;port=3306;database=lsongulija;password=123456";
        MySqlConnection cnn;



        public void displayTransTest()
        {
            try
            {
                cnn = new MySqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
                cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.

                MySqlCommand cmd = new MySqlCommand("Select * from trans_test", cnn);//select all from newTestTable

                cmd.ExecuteNonQuery();

                DataTable dta = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dta);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }

            cnn.Close();
            Console.WriteLine("Connection Closed. Press any key to exit...");
            Console.Read();
        }

        //REGISTER STUDENT
        public TransportoTestai InsertTransTest(TransportoTestai transTestai)//provide transportas object when calling this function
        {
            try
            {


                //setting new SqlConnection, providing connectionString
                cnn = new MySqlConnection(connectionString);
                cnn.Open();//open database

                MySqlCommand cmd1 = new MySqlCommand("Insert into trans_test (Test_data,Trans_Id) VALUES(@Test_data,@Trans_Id)", cnn);
                cmd1.Parameters.AddWithValue("@Test_data", transTestai.test_Data);
                cmd1.Parameters.AddWithValue("@Trans_Id", transTestai.trans_Id);
                cmd1.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            return transTestai;//return 
        }


        public void UpdateTransTest(TransportoTestai transTestai)
        {
            try
            {
                //setting new SqlConnection, providing connectionString
                cnn = new MySqlConnection(connectionString);
                cnn.Open();//open database

                //check if user exist
                MySqlCommand cmd = new MySqlCommand("Update trans_test SET Test_data=@Test_data, Trans_Id=@Trans_Id  WHERE TestId=@TestId", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@Test_data", transTestai.test_Data);
                cmd.Parameters.AddWithValue("@Trans_Id", transTestai.trans_Id);
                cmd.Parameters.AddWithValue("@TestId", transTestai.test_Id);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
