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
    public partial class AdminKlientasForm : Form
    {
        Klientas klientas;
        UsersRepository usersRep;
        GalimiNusizengimaiRepository galimiNuzRep;
        NusizengimaiRepository nusizRep;

        public AdminKlientasForm(Klientas klientas)
        {
            InitializeComponent();
            this.klientas = klientas;
            usersRep = new UsersRepository();
            galimiNuzRep = new GalimiNusizengimaiRepository();
            nusizRep = new NusizengimaiRepository();
        }

        private void getKlientai_Click(object sender, EventArgs e)
        {
            getKlientaiDisplay();
        }

        private void AddKlientaiShow_Click(object sender, EventArgs e)
        {
            updateKlientaiPanel.Visible = false;
            addKlientaiPanel.Visible = true;
        }

        private void updateKlientaiShow_Click(object sender, EventArgs e)
        {
            addKlientaiPanel.Visible = false;
            updateKlientaiPanel.Visible = true;
        }

        private void addKlientas_Click(object sender, EventArgs e)
        {
            try
            {
                Klientas kl = new Klientas();
                kl.vardas = addKlientasVardas.Text;
                kl.pavarde = addKlientasPavarde.Text;
                kl.email = addKlientasEmail.Text;
                kl.kodas = int.Parse(addKlientasAsmKodas.Text);
                kl.slaptazodis = addKlientasSlapt.Text;

                Klientas insertKl = usersRep.RegisterClient(kl);

                addKlientasVardas.Clear();
                addKlientasPavarde.Clear();
                addKlientasEmail.Clear();
                addKlientasAsmKodas.Clear();
                addKlientasSlapt.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Succesfully inserted");
            getKlientaiDisplay();
        }

        private void updateKlientas_Click(object sender, EventArgs e)
        {
            try
            {
                Klientas kl = new Klientas();
                kl.vardas = updateKlientasVardas.Text;
                kl.pavarde = updateKlientasPav.Text;
                kl.email = updateKlientasEmail.Text;
                kl.klientoNr = int.Parse(updateKlientasKlientoNr.Text);
                
                usersRep.UpdateKlientas(kl);

                updateKlientasVardas.Clear();
                updateKlientasPav.Clear();
                updateKlientasEmail.Clear();
                updateKlientasKlientoNr.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Succesfully updated");
            getKlientaiDisplay();
        }

        private void getKlientaiDisplay()
        {
            try
            {
                //FOR TESTS
                DataTable dta = usersRep.displayClients();
                dataGridView1.DataSource = dta;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
