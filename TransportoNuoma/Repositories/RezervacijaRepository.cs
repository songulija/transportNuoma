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
    class RezervacijaRepository
    {
        string connectionString = "server=34.91.29.158;user id=root;persistsecurityinfo=True;port=3306;database=lsongulija;password=123456";
        MySqlConnection cnn;



        public void displayTransportas()
        {
            try
            {
                cnn = new MySqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
                cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.

                MySqlCommand cmd = new MySqlCommand("Select * from rezervacija", cnn);//select all from newTestTable

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
        public Rezervacija InsertRezervacija(Rezervacija rezervacija)//provide transportas object when calling this function
        {
            try
            {


                //setting new SqlConnection, providing connectionString
                cnn = new MySqlConnection(connectionString);
                cnn.Open();//open database

                //check if rezervacija exist
                MySqlCommand cmd = new MySqlCommand("Select * from rezervacija where Trans_Id=@Trans_Id AND rezData=@rezData AND rezPrad=@rezPrad", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@Trans_Id", rezervacija.Transporto_Id);
                cmd.Parameters.AddWithValue("@rezData", rezervacija.rezervacijos_Data);
                cmd.Parameters.AddWithValue("@rezPrad", rezervacija.rezervacijosPrad);
                MySqlDataReader dataReader = cmd.ExecuteReader();//sends SQLCommand.CommandText to the SQLCommand.Connection and builds SqlDataReader
                if ((dataReader.Read() == true))
                {
                    Console.WriteLine("Transport with that Number already exists");
                    return null;
                }
                else
                {
                    Console.WriteLine("Transport is free so you can register");
                }
                dataReader.Close();//close data reader when it finishes work

                MySqlCommand cmd1 = new MySqlCommand("Insert into rezervacija (rezData,rezPrad,rezPab,Kliento_nr,Trans_Id,lokacijosId) VALUES(@rezData,@rezPrad,@rezPab,@Kliento_nr,@Trans_Id,@lokacijosId)", cnn);
                cmd1.Parameters.AddWithValue("@rezData", rezervacija.rezervacijos_Data);
                cmd1.Parameters.AddWithValue("@rezPrad", rezervacija.rezervacijosPrad);
                cmd1.Parameters.AddWithValue("@rezPab", rezervacija.rezervacijosPab);
                cmd1.Parameters.AddWithValue("@Kliento_nr", rezervacija.kliento_Id);
                cmd1.Parameters.AddWithValue("@Trans_Id", rezervacija.Transporto_Id);
                cmd1.Parameters.AddWithValue("@lokacijosId", rezervacija.lokacijos_Id);
                cmd1.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            return rezervacija;//return 
        }


        public void UpdateRezervacija(Rezervacija rezervacija)
        {
            try
            {
                //setting new SqlConnection, providing connectionString
                cnn = new MySqlConnection(connectionString);
                cnn.Open();//open database

                //check if user exist
                MySqlCommand cmd = new MySqlCommand("Update rezervacija SET rezData=@rezData, rezPrad=@rezPrad, rezPab=@rezPab WHERE rezId=@rezId", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@rezData", rezervacija.rezervacijos_Data);
                cmd.Parameters.AddWithValue("@rezPrad", rezervacija.rezervacijosPrad);
                cmd.Parameters.AddWithValue("@rezPab", rezervacija.rezervacijosPab);
                cmd.Parameters.AddWithValue("@rezId", rezervacija.rezervacijos_Id);
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
