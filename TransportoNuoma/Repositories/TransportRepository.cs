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
    class TransportRepository
    {
            string connectionString = "server=34.91.29.158;user id=root;persistsecurityinfo=True;port=3306;database=lsongulija;password=123456";
            MySqlConnection cnn;



            public void displayTransportas()
            {
                try
                {
                    cnn = new MySqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
                    cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.

                    MySqlCommand cmd = new MySqlCommand("Select * from transportas", cnn);//select all from newTestTable

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
            public Transportas InsertTransport(Transportas transportas)//provide transportas object when calling this function
            {
                try
                {


                    //setting new SqlConnection, providing connectionString
                    cnn = new MySqlConnection(connectionString);
                    cnn.Open();//open database

                    //check if user exist
                    MySqlCommand cmd = new MySqlCommand("Select * from transportas where Trans_nr=@Trans_nr", cnn);//to check if username exist we have to select all items with username
                    cmd.Parameters.AddWithValue("@Trans_nr", transportas.transporto_Nr);
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

                    MySqlCommand cmd1 = new MySqlCommand("Insert into transportas (Trans_nr,Tipas,Spalva,Gamybos_Metai,Kaina,QrKodas) VALUES(@Trans_nr,@Tipas,@Spalva,@Gamybos_Metai,@Kaina,@QrKodas)", cnn);
                    cmd1.Parameters.AddWithValue("@Trans_nr", transportas.transporto_Nr);
                    cmd1.Parameters.AddWithValue("@Tipas", transportas.tipas);
                    cmd1.Parameters.AddWithValue("@Spalva", transportas.spalva);
                    cmd1.Parameters.AddWithValue("@Gamybos_Metai", transportas.gamybos_Metai);
                    cmd1.Parameters.AddWithValue("@Kaina", transportas.kaina);
                    cmd1.Parameters.AddWithValue("@QrKodas", transportas.QRCode);
                    cmd1.ExecuteNonQuery();
                    cnn.Close();

                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
                return transportas;//return 
            }

        
    }
}
