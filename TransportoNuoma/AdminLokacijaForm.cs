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
    public partial class AdminLokacijaForm : Form
    {
        Klientas klientas;
        LokacijaRepository transLokRep;
        TransportRepository transRep;
        KlientoLokacijaRepository klientoLokRep;

        public AdminLokacijaForm(Klientas klientas)
        {
            InitializeComponent();
            this.klientas = klientas;
            transLokRep = new LokacijaRepository();
            klientoLokRep = new KlientoLokacijaRepository();
            transRep = new TransportRepository();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainFormAdmin admin = new MainFormAdmin(klientas);
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }

        private void getTransportLok_Click(object sender, EventArgs e)
        {
            getTransLokDisplay();
        }

        private void addTransportLokShow_Click(object sender, EventArgs e)
        {
            updateTransLokPanel.Visible = false;
            addTransLokPanel.Visible = true;
        }

        private void updateTransLokShow_Click(object sender, EventArgs e)
        {
            addTransLokPanel.Visible = false;
            updateTransLokPanel.Visible = true;
        }

        private void addTransTest_Click(object sender, EventArgs e)
        {
            try
            {
                Lokacija lok = new Lokacija();
                lok.salis = addTransLokSalis.Text;
                lok.miestas = addTransLokMiestas.Text;
                lok.koordinatesX = double.Parse(addTransLokKoordX.Text);
                lok.koordinatesY = double.Parse(addTransLokKoordY.Text);
                lok.transporto_Id = int.Parse(addTransLokTransId.Text);

                Lokacija InsertedLok = transLokRep.InsertLokacija(lok);

                addTransLokSalis.Clear();
                addTransLokMiestas.Clear();
                addTransLokKoordX.Clear();
                addTransLokKoordY.Clear();
                addTransLokTransId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Succesfully inserted");
            getTransLokDisplay();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Lokacija lok = new Lokacija();
                lok.salis = updateTransLokSalis.Text;
                lok.miestas = updateTransLokMiestas.Text;
                lok.koordinatesX = double.Parse(updateTransLokKoordX.Text);
                lok.koordinatesY = double.Parse(updateTransLokKoordY.Text);
                lok.transporto_Id = int.Parse(updateTransLokTransId.Text);
                lok.lokacijos_Id = int.Parse(updateTransLokLokacId.Text);

                transLokRep.UpdateLokacija(lok);

                updateTransLokSalis.Clear();
                updateTransLokMiestas.Clear();
                updateTransLokKoordX.Clear();
                updateTransLokKoordY.Clear();
                updateTransLokTransId.Clear();
                updateTransLokLokacId.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Succesfully updated");
            getTransLokDisplay();
        }

        private void getTransLokDisplay()
        {
            try
            {
                DataTable dta = transLokRep.displayLokacija();
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
