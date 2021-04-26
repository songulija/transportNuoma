using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportoNuoma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                
           
        }

        string connectionString = "server=34.91.29.158;user id=root;persistsecurityinfo=True;database=lsongulija";
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
                con = new SqlConnection(connectionString);
                con.Open();
                //creates an sql command to the connected database
                SqlCommand cmd1 = con.CreateCommand();
                //definies the command type
                cmd1.CommandType = CommandType.Text;
                //selects everything from client table where email and password is same as those written in login textboxes
                cmd1.CommandText = " select * from klientas where email = '" + loginEmail.Text + "' and slaptazodis = '" + loginPassword.Text + "'";
                //executes the command
                cmd1.ExecuteNonQuery();
                //creates new datatable
                DataTable dt1 = new DataTable();               
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
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

        }
    }
}
