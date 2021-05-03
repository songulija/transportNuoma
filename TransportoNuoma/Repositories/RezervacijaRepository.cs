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



        public DataTable displayRezervacija()
        {
            DataTable dta = new DataTable();
            try
            {
                cnn = new MySqlConnection(connectionString);//assign connection. The variable cnn, which is of type SqlConnection is used to establish the connection to the database.
                cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.

                MySqlCommand cmd = new MySqlCommand("SELECT rezervacija.rezId, rezervacija.rezData, rezervacija.rezPrad, rezervacija.rezPab,klientas.Kliento_nr,klientas.Vardas,klientas.Pavarde, transportas.Trans_Id,transportas.Trans_nr,lokacija.lokacijosId,lokacija.KoordinatesX,lokacija.KoordinatesY FROM rezervacija INNER JOIN klientas ON rezervacija.Kliento_nr=klientas.Kliento_nr INNER JOIN transportas ON rezervacija.Trans_Id=transportas.Trans_Id INNER JOIN lokacija ON rezervacija.lokacijosId=lokacija.lokacijosId", cnn);//select all from newTestTable

                cmd.ExecuteNonQuery();

                
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dta);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());
            }

            cnn.Close();
            return dta;
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
                MySqlCommand cmd = new MySqlCommand("Select * from rezervacija where Trans_Id=@Trans_Id", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@Trans_Id", rezervacija.Transporto_Id);
                
                MySqlDataReader dataReader = cmd.ExecuteReader();//sends SQLCommand.CommandText to the SQLCommand.Connection and builds SqlDataReader
                if ((dataReader.Read() == true) && TimeSpan.Parse(dataReader["rezPab"].ToString()) > DateTime.Now.TimeOfDay)
                {
                    Console.WriteLine("Transport is already under reservation");
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

       

        public void addNewRezervacija(Klientas klientas, Transportas transportas, Lokacija lokacija)
        {
            
            try
            {
                cnn = new MySqlConnection(connectionString);
                cnn.Open();//opens connection
                MySqlCommand cmd = new MySqlCommand("Select * from rezervacija where Kliento_nr=@Kliento_nr", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@Kliento_nr", klientas.klientoNr);
                MySqlDataReader dataReader = cmd.ExecuteReader();//sends SQLCommand.CommandText to the SQLCommand.Connection and builds SqlDataReader
                if ((dataReader.Read() == true) && TimeSpan.Parse(dataReader["rezPab"].ToString()) > DateTime.Now.TimeOfDay)
                {
                    Console.WriteLine("Client already has an active reservation");
                    
                }
                else
                {
                    Rezervacija rezervacija = new Rezervacija();
                    TimeSpan rezervacijosLaikas = new TimeSpan(0, 15, 0);
                    rezervacija.kliento_Id = klientas.klientoNr;
                    rezervacija.lokacijos_Id = lokacija.lokacijos_Id;
                    rezervacija.Transporto_Id = transportas.transporto_Id;
                    rezervacija.rezervacijos_Data = DateTime.Today;
                    rezervacija.rezervacijosPrad = DateTime.Now.TimeOfDay;
                    rezervacija.rezervacijosPab = rezervacija.rezervacijosPrad.Add(rezervacijosLaikas);     //DateTime.Today.AddSeconds(900);
                    InsertRezervacija(rezervacija);
                }

            }
            catch(Exception e) { Console.WriteLine(e.Message); }
            

           
        }
        
        public void UpdateRezervacija(Rezervacija rezervacija)
        {
            try
            {
                //setting new SqlConnection, providing connectionString
                cnn = new MySqlConnection(connectionString);

                //check if user exist
                MySqlCommand cmd = new MySqlCommand("Update rezervacija SET Trans_Id=@Trans_Id, Kliento_nr=@Kliento_nr WHERE rezId=@rezId", cnn);//to check if username exist we have to select all items with username
                cmd.Parameters.AddWithValue("@Trans_Id", rezervacija.Transporto_Id);
                cmd.Parameters.AddWithValue("@Kliento_nr", rezervacija.kliento_Id);
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




        public void DeleteRezervacija(Rezervacija rezervacija, int nuomosNr)
        {
            try
            {
                cnn = new MySqlConnection(connectionString);

                string newSql = ("Delete from apmokejimas where apmokejimas.Nuomos_nr=@Nuomos_nr; ");
                newSql += ("Delete from nuoma where nuoma.rezId=@rezId; ");
                newSql += ("Delete from rezervacija where rezervacija.rezId=@rezId");

                cnn.Open();//open connection. we use the Open method of the cnn variable to open a connection to the database.
                MySqlCommand cmd = new MySqlCommand(newSql, cnn);//select all from newTestTable
                cmd.Parameters.AddWithValue("@Nuomos_nr", nuomosNr);
                cmd.Parameters.AddWithValue("@rezId", rezervacija.rezervacijos_Id);
                cmd.ExecuteNonQuery();//execute function

                cnn.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }

        }

    }
}
