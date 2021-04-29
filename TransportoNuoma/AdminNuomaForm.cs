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
    public partial class AdminNuomaForm : Form
    {
        Klientas klientas;
        NuomaRepository nuomaRep;
        TransportRepository transRep;

        public AdminNuomaForm(Klientas klientas)
        {
            InitializeComponent();
            this.klientas = klientas;
            nuomaRep = new NuomaRepository();
            transRep = new TransportRepository();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainFormAdmin admin = new MainFormAdmin(klientas);
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }

        private void getNuoma_Click(object sender, EventArgs e)
        {
            getNuomaDisplay();
        }

        private void AddNuomaShow_Click(object sender, EventArgs e)
        {
            updateNuomaPanel.Visible = false;
            addNuomaPanel.Visible = true;
        }

        private void updateNuomaShow_Click(object sender, EventArgs e)
        {
            addNuomaPanel.Visible = false;
            updateNuomaPanel.Visible = true;
        }

        private void addNuoma_Click(object sender, EventArgs e)
        {
            try
            {
                
                Nuoma nm = new Nuoma();
                DateTime prDate = DateTime.Today;
                DateTime pabDate = DateTime.Today;
                nm.nuomosPrData = prDate;
                nm.nuomosPradLaik = DateTime.Now.TimeOfDay;
                TimeSpan nmLaikas = new TimeSpan(1,0,0);
                nm.nuomosPabLaik = nm.nuomosPradLaik.Add(nmLaikas);
                nm.nuomosPabData = pabDate;
                nm.transporto_Id = int.Parse(addNuomaTransId.Text);
                nm.kliento_Nr = int.Parse(addNuomaKlientoNr.Text);
                nm.rezId = int.Parse(addNuomaRezId.Text);

                Nuoma insertedNm = nuomaRep.InsertNuoma(nm);

                addNuomaTransId.Clear();
                addNuomaKlientoNr.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Succesfully inserted");
            getNuomaDisplay();
        }

        private void updateNuoma_Click(object sender, EventArgs e)
        {
            try
            {
                Nuoma nm = new Nuoma();
                nm.transporto_Id = int.Parse(updateNuomaTransId.Text);
                nm.kliento_Nr = int.Parse(updateNuomaKlientoNr.Text);
                nm.nuomos_Nr = int.Parse(updateNuomaNuomosNr.Text);

                nuomaRep.UpdateNuoma(nm);

                updateNuomaTransId.Clear();
                updateNuomaKlientoNr.Clear();
                updateNuomaNuomosNr.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Succesfully updated");
            getNuomaDisplay();
        }

        private void getNuomaDisplay()
        {
            try
            {
                DataTable dta = nuomaRep.displayNuoma();
                dataGridView1.DataSource = dta;

                DataTable dta1 = transRep.displayTransportas();
                dataGridView2.DataSource = dta1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
