using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportoNuoma.Classes;
using TransportoNuoma.Repositories;

namespace TransportoNuoma
{
    public partial class Form1 : Form
    {
        UsersRepository usersRepository;
        public Form1()
        {
            InitializeComponent();

            usersRepository = new UsersRepository();


        }

        string connectionString = "server=34.91.29.158;user id=root;persistsecurityinfo=True;database=lsongulija;allowuservariables=True";
        SqlConnection con;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            int count = 0;
            try
            {
                //establishes new connection to the database
                con = new MySqlConnection(connectionString);
                con.Open();
                //creates an sql command to the connected database
                MySqlCommand cmd1 = con.CreateCommand();
                //definies the command type
                cmd1.CommandType = CommandType.Text;
                //selects everything from client table where email and password is same as those written in login textboxes
                cmd1.CommandText = " select * from klientas where email = '" + loginEmail.Text + "' and slaptazodis = '" + loginPassword.Text + "'";
                //executes the command
                cmd1.ExecuteNonQuery();
                //creates new datatable
                DataTable dt1 = new DataTable();               
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                //fill the datatable with datarows from the database
                da1.Fill(dt1);
                //sets count to one if theres a data row with email and password specified in the login textboxes
                count = Convert.ToInt32(dt1.Rows.Count.ToString());
                if (count == 0)
                {
                    MessageBox.Show("Vartotojas neegzistuoja");
                }
            
                else { MessageBox.Show("OK"); }
            
                con.Close();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }         
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                //create student object out of textbox values
                Klientas klientas = new Klientas();
                klientas.id = 16;
                klientas.vardas = vardasRegister.Text;
                klientas.pavarde = pavardeRegister.Text;
                klientas.kodas = int.Parse(kodasRegister.Text);
                klientas.email = registerEmail.Text;
                klientas.slaptazodis = registerPassword.Text;
                Klientas registerClient = usersRepository.RegisterClient(klientas);
                if (registerClient.vardas != null && registerClient.vardas != "")
                {
                    MessageBox.Show("Register");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            
        }

        private void getClients_Click(object sender, EventArgs e)
        {
            usersRepository.displayClients();
        }
    }
}
