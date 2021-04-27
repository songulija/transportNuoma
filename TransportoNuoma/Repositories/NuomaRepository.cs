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
    class NuomaRepository
    {

        string connectionString = "server=34.91.29.158;user id=root;persistsecurityinfo=True;port=3306;database=lsongulija;password=123456";
        MySqlConnection cnn;



        public void displayTransportas()
        {
            try
            {
                cnn = new MySqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
                cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.

                MySqlCommand cmd = new MySqlCommand("Select * from nuoma", cnn);//select all from newTestTable

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
        public Nuoma InsertNuoma(Nuoma nuoma)//provide transportas object when calling this function
        {
            try
            {


                //setting new SqlConnection, providing connectionString
                cnn = new MySqlConnection(connectionString);
                cnn.Open();//open database

                //check if rezervacija exist
                MySqlCommand cmd = new MySqlCommand("Select * from rezervacija where rezId=@rezId", cnn);
                cmd.Parameters.AddWithValue("@rezId", nuoma.rezId);
                MySqlDataReader dataReader = cmd.ExecuteReader();//sends SQLCommand.CommandText to the SQLCommand.Connection and builds SqlDataReader
                if ((dataReader.Read() == true))
                {
                    Console.WriteLine("Transport with that Number already exists");
                    MySqlCommand cmd1 = new MySqlCommand("Insert into nuoma (NuomosPrData,NuomosPradLaik,NuomosPabLaik,NuomosPabData,Trans_Id,Kliento_nr,rezId) VALUES(@NuomosPrData,@NuomosPradLaik,@NuomosPabLaik,@NuomosPabData,@Trans_Id,@Kliento_nr,@rezId)", cnn);
                    cmd1.Parameters.AddWithValue("@NuomosPrData", nuoma.nuomosPrData);
                    cmd1.Parameters.AddWithValue("@NuomosPradLaik", nuoma.nuomosPradLaik);
                    cmd1.Parameters.AddWithValue("@NuomosPabLaik", nuoma.nuomosPabLaik);
                    cmd1.Parameters.AddWithValue("@NuomosPabData", nuoma.nuomosPabData);
                    cmd1.Parameters.AddWithValue("@Trans_Id", nuoma.transporto_Id);
                    cmd1.Parameters.AddWithValue("@Kliento_nr", nuoma.kliento_Nr);
                    cmd1.Parameters.AddWithValue("@rezId", nuoma.rezId);
                    cmd1.ExecuteNonQuery();
                    cnn.Close();
                }
                else
                {
                    Console.WriteLine("Transport is free so you can register");
                    return null;
                }
                dataReader.Close();//close data reader when it finishes work

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            return nuoma;//return 
        }


        

    }
}
