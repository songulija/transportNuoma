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
    class PakrovimasRepository
    {

        string connectionString = "server=34.91.29.158;user id=root;persistsecurityinfo=True;port=3306;database=lsongulija;password=123456";
        MySqlConnection cnn;



        public void displayPakrovimas()
        {
            try
            {
                cnn = new MySqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
                cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.

                MySqlCommand cmd = new MySqlCommand("Select * from pakrovimas", cnn);//select all from newTestTable

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
        public Pakrovimas InsertPakrovimas(Pakrovimas pakrovimas)//provide transportas object when calling this function
        {
            try
            {
                bool transYra = false;

                //setting new SqlConnection, providing connectionString
                cnn = new MySqlConnection(connectionString);
                cnn.Open();//open database

                //check if rezervacija exist
                MySqlCommand cmd = new MySqlCommand("Select * from transportas where Trans_Id=@Trans_Id", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@Trans_Id", pakrovimas.transporto_Id);

                MySqlDataReader dataReader = cmd.ExecuteReader();//sends SQLCommand.CommandText to the SQLCommand.Connection and builds SqlDataReader
                if ((dataReader.Read() == true))
                {
                    transYra = true;
                }
                else
                {
                    return null;
                }
                dataReader.Close();//close data reader when it finishes work
                if (transYra == true)
                {
                    MySqlCommand cmd1 = new MySqlCommand("Insert into pakrovimas (PakrovimoDydis,Trans_Id) VALUES(@PakrovimoDydis,@Trans_Id)", cnn);
                    cmd1.Parameters.AddWithValue("@PakrovimoDydis", pakrovimas.pakrovimo_Dydis);
                    cmd1.Parameters.AddWithValue("@Trans_Id", pakrovimas.transporto_Id);
                    cmd1.ExecuteNonQuery();
                }

                cnn.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            return pakrovimas;//return 
        }


        public void UpdatePakrovimas(Pakrovimas pakrovimas)
        {
            try
            {
                //setting new SqlConnection, providing connectionString
                cnn = new MySqlConnection(connectionString);
                cnn.Open();//open database

                //check if user exist
                MySqlCommand cmd = new MySqlCommand("Update pakrovimas SET PakrovimoDydis=@PakrovimoDydis, Trans_Id=@Trans_Id WHERE pakrovimoNr=@pakrovimoNr", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@PakrovimoDydis", pakrovimas.pakrovimo_Dydis);
                cmd.Parameters.AddWithValue("@Trans_Id", pakrovimas.transporto_Id);
                cmd.Parameters.AddWithValue("@pakrovimoNr", pakrovimas.pakrovimo_Nr);
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
