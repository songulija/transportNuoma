using MySql.Data.MySqlClient;
using System;
using System.Data;
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

        static string connectionString = "server=34.91.29.158;user id=root;persistsecurityinfo=True;port=3306;database=lsongulija;password=123456";
        MySqlConnection con = new MySqlConnection(connectionString);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(loginEmail.Text != null && loginEmail.Text!="" && loginPassword.Text != null && loginPassword.Text != "")
            {
                Klientas loggedKlientas = usersRepository.LoginKlientas(loginEmail.Text, loginPassword.Text);

                if (loggedKlientas.email != null && loggedKlientas.email!="")
                {
                    MessageBox.Show("You are logged in");
                    Console.WriteLine(loggedKlientas.email);

                    //could redirect to register page or forget email/pass page
                }
                else
                {
                    MessageBox.Show("Incorrect email or password");
                    // open post loggin form
                }

            }
 

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {   
                if(repeatPassword.Text == registerPassword.Text)
                {
                    //create student object out of textbox values
                    Klientas klientas = new Klientas();
                    klientas.vardas = vardasRegister.Text;
                    klientas.pavarde = pavardeRegister.Text;
                    klientas.kodas = int.Parse(kodasRegister.Text);
                    klientas.email = registerEmail.Text;
                    klientas.slaptazodis = registerPassword.Text;
                    klientas.isAdmin = 0;
                    Klientas registerClient = usersRepository.RegisterClient(klientas);
                    if (registerClient.vardas != null && registerClient.vardas != "")
                    {
                        MessageBox.Show("Register");
                    }
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
