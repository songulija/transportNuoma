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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                //create student object out of textbox values
                Klientas klientas = new Klientas();
                klientas.vardas = vardasRegister.Text;
                klientas.pavarde = pavardeRegister.Text;
                klientas.kodas = int.Parse(kodasRegister.Text);
                klientas.email = registerEmail.Text;
                klientas.slaptazodis = registerPassword.Text;
                usersRepository.RegisterClient(klientas);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            MessageBox.Show("Register of student succesful");
        }
    }
}
