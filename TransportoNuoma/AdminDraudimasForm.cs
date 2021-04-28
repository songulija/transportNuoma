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
    public partial class AdminDraudimasForm : Form
    {
        Klientas klientas;
        DraudimoTiekRepository draudTiekRep;
        DraudimasRepository draudimasRep;

        public AdminDraudimasForm(Klientas klientas)
        {
            InitializeComponent();
            this.klientas = klientas;
            draudTiekRep = new DraudimoTiekRepository();
            draudimasRep = new DraudimasRepository();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainFormAdmin admin = new MainFormAdmin(klientas);
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }

        private void getDraudTiek_Click(object sender, EventArgs e)
        {
            try
            {
                //FOR TESTS
                DataTable dta = draudTiekRep.displayDraudimoTiekejai();
                dataGridView1.DataSource = dta;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addDraudTiekShow_Click(object sender, EventArgs e)
        {
            
        }

        private void updateDraudTiekShow_Click(object sender, EventArgs e)
        {
            
        }

        private void addDraudTIek_Click(object sender, EventArgs e)
        {
            try
            {
                //FOR TESTS
                DataTable dta = draudTiekRep.displayDraudimoTiekejai();
                dataGridView1.DataSource = dta;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateDraudTIek_Click(object sender, EventArgs e)
        {
            try
            {
                //FOR TESTS
                DataTable dta = draudTiekRep.displayDraudimoTiekejai();
                dataGridView1.DataSource = dta;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
