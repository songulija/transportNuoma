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
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = " select * from klientas where email = '" + loginEmail.Text + "' and slaptazodis = '" + loginPassword.Text + "'";
                cmd1.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);
                count = Convert.ToInt32(dt1.Rows.Count.ToString());
                if (count == 0)
                {
                    MessageBox.Show("Vartotojas neegzistuoja");
                }
            
                else { MessageBox.Show("OK"); }
            //MessageBox.Show("OK");
                con.Close();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }         
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
