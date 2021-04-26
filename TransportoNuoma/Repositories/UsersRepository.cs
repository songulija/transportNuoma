using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportoNuoma.Classes;

namespace TransportoNuoma.Repositories
{
    class UsersRepository
    {
        string connectionString = "server=34.91.29.158;user id=root;persistsecurityinfo=True;database=lsongulija;allowuservariables=True;password=123456";
        MySqlConnection cnn;



        public void displayClients()
        {
            try
            {
                cnn = new MySqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
                cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.

                MySqlCommand cmd = new MySqlCommand("Select * from klientas", cnn);//select all from newTestTable

                MySqlDataReader rdr = cmd.ExecuteReader();

                //read the data
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1] + " -- " + rdr[2]);
                }
                rdr.Close();
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
        public Klientas RegisterClient(Klientas klientas)//provide student object when calling this function
        {
            try
            {


                //setting new SqlConnection, providing connectionString
                cnn = new MySqlConnection(connectionString);
                cnn.Open();//open database

                //check if user exist
                MySqlCommand cmd = new MySqlCommand("Select * from klientas where email=@email", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@email", klientas.email);
                MySqlDataReader dataReader = cmd.ExecuteReader();//sends SQLCommand.CommandText to the SQLCommand.Connection and builds SqlDataReader
                if ((dataReader.Read() == true))//if dataReader.Read is true then it means that it found User with that Username
                {
                    //then User with that Username already exists
                    Console.WriteLine("User with that Username already exists");
                    return null;//if username exist than it will not watch script bellow, it will just return
                }

                else//there is no user with that Username that we want to register
                {
                    //so we can register user
                    Console.WriteLine("Username is free so you can register");
                }
                dataReader.Close();//close data reader when it finishes work

                MySqlCommand cmd1 = new MySqlCommand("Insert into klientas (Kliento_nr,Vardas,Pavarde,Asmens_Kodas,email,slaptazodis) VALUES(@Kliento_nr,@Vardas,@Pavarde,@Asmens_Kodas,@email,@slaptazodis)", cnn);
                cmd1.Parameters.AddWithValue("@Kliento_nr", klientas.id);
                cmd1.Parameters.AddWithValue("@Vardas", klientas.vardas);
                cmd1.Parameters.AddWithValue("@Pavarde", klientas.pavarde);
                cmd1.Parameters.AddWithValue("@Asmens_Kodas", klientas.kodas);
                cmd1.Parameters.AddWithValue("@email", klientas.email);
                cmd1.Parameters.AddWithValue("@slaptazodis", klientas.pavarde);

                cmd1.ExecuteNonQuery();
                cnn.Close();

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            return klientas;//return 
        }

        


    }
}
