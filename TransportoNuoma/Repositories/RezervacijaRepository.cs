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



        public void displayRezervacija()
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
        public (Rezervacija, bool) InsertRezervacija(Rezervacija rezervacija)//provide transportas object when calling this function
        {
            try
            {
                
                
                //setting new SqlConnection, providing connectionString
                cnn = new MySqlConnection(connectionString);
                cnn.Open();//open database

                //check if rezervacija exist
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM rezervacija WHERE rezId=( SELECT MAX(rezId) FROM rezervacija WHERE Trans_Id=@Trans_Id);", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@Trans_Id", rezervacija.Transporto_Id);
                
                MySqlDataReader dataReader = cmd.ExecuteReader();//sends SQLCommand.CommandText to the SQLCommand.Connection and builds SqlDataReader
                if ((dataReader.Read() == true) && TimeSpan.Parse(dataReader["rezPab"].ToString()) >= DateTime.Now.TimeOfDay && DateTime.Parse(dataReader["rezData"].ToString()) >= DateTime.Today)
                {
                    
                        if (TimeSpan.Parse(dataReader["rezPab"].ToString()) >= DateTime.Now.TimeOfDay)
                        {
                            Console.WriteLine("Transport is already under reservation");
                            return (null, false);
                        }

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
                Console.WriteLine("Rezervation completed succesfuly");


                
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
           
            return (rezervacija, true);//return 
        }

       

        public bool addNewRezervacija(Klientas klientas, Transportas transportas, Lokacija lokacija)
        {
            
                cnn = new MySqlConnection(connectionString);
                cnn.Open();//opens connection
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM rezervacija WHERE rezId=( SELECT MAX(rezId) FROM rezervacija WHERE Kliento_nr=@Kliento_nr);", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@Kliento_nr", klientas.klientoNr);
                MySqlDataReader dataReader = cmd.ExecuteReader();//sends SQLCommand.CommandText to the SQLCommand.Connection and builds SqlDataReader
            if (dataReader.Read() == true)
            {
                
                    if (TimeSpan.Parse(dataReader["rezPab"].ToString()) > DateTime.Now.TimeOfDay && DateTime.Parse(dataReader["rezData"].ToString()) >= DateTime.Today)
                    {
                        Console.WriteLine("Client already has an active reservation");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Creating new rezervation object");
                        Rezervacija rezervacija1 = new Rezervacija();
                        TimeSpan rezervacijosLaikas1 = new TimeSpan(0, 15, 0);
                        rezervacija1.kliento_Id = klientas.klientoNr;
                        rezervacija1.lokacijos_Id = lokacija.lokacijos_Id;
                        rezervacija1.Transporto_Id = transportas.transporto_Id;
                        rezervacija1.rezervacijos_Data = DateTime.Today;
                        rezervacija1.rezervacijosPrad = DateTime.Now.TimeOfDay;
                        rezervacija1.rezervacijosPab = rezervacija1.rezervacijosPrad.Add(rezervacijosLaikas1);     //DateTime.Today.AddSeconds(900);
                        if (InsertRezervacija(rezervacija1).Item2 == true) { return true; }
                        

                    }
                

            }else if(dataReader.Read() == false)
            {
                Console.WriteLine("Creating new rezervation object");
                Rezervacija rezervacija = new Rezervacija();
                TimeSpan rezervacijosLaikas = new TimeSpan(0, 15, 0);
                rezervacija.kliento_Id = klientas.klientoNr;
                rezervacija.lokacijos_Id = lokacija.lokacijos_Id;
                rezervacija.Transporto_Id = transportas.transporto_Id;
                rezervacija.rezervacijos_Data = DateTime.Today;
                rezervacija.rezervacijosPrad = DateTime.Now.TimeOfDay;
                rezervacija.rezervacijosPab = rezervacija.rezervacijosPrad.Add(rezervacijosLaikas);     //DateTime.Today.AddSeconds(900);
                if (InsertRezervacija(rezervacija).Item2 == true) { return true; }

            }

            dataReader.Close();
                cnn.Close();
            return false;
            
        }
        public bool isTransportasTaken(Transportas transportas)
        {
            try 
            {
                cnn = new MySqlConnection(connectionString);
                cnn.Open();//open database

                //check if rezervacija exist
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM rezervacija WHERE rezId=( SELECT MAX(rezId) FROM rezervacija WHERE Trans_Id=@Trans_Id);", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@Trans_Id", transportas.transporto_Id);
                MySqlDataReader dataReader = cmd.ExecuteReader();//sends SQLCommand.CommandText to the SQLCommand.Connection and builds SqlDataReader
                if ((dataReader.Read() == true) && TimeSpan.Parse(dataReader["rezPab"].ToString()) > DateTime.Now.TimeOfDay && DateTime.Parse(dataReader["rezData"].ToString()) >= DateTime.Today)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("transport is not taken");   
                }
                
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return false;
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
             
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void CancelRezervacija(Klientas klientas)
        {
            try
            {
                //setting new SqlConnection, providing connectionString
                cnn = new MySqlConnection(connectionString);
                cnn.Open();//open database
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM rezervacija WHERE rezId=( SELECT MAX(rezId) FROM rezervacija WHERE Kliento_nr=@Kliento_nr)", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@Kliento_nr", klientas.klientoNr);
                MySqlDataReader dataReader = cmd.ExecuteReader();//sends SQLCommand.CommandText to the SQLCommand.Connection and builds SqlDataReader
                while(dataReader.Read() == true)
                {
                    if(TimeSpan.Parse(dataReader["rezPab"].ToString()) > DateTime.Now.TimeOfDay )
                    {
                        int rezervID = Convert.ToInt32(dataReader["rezId"]);
                        
                        MySqlCommand cmd1 = new MySqlCommand("Update rezervacija SET rezPab=@rezPab WHERE rezId=@rezId", cnn);//to check if username exist we have to select all items with username
                        
                        cmd1.Parameters.AddWithValue("@rezPab", DateTime.Now.TimeOfDay);
                        cmd1.Parameters.AddWithValue("@rezId", rezervID);
                        dataReader.Close();
                        cmd1.ExecuteNonQuery();
                        Console.WriteLine("Succesfuly canceled");
                        
                        return;
                    }
                }
                
                Console.WriteLine("connection is closing");
                cnn.Close();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
