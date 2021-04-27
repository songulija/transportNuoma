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
    public partial class MainFormAdmin : Form
    {
        Klientas klientas;
        TransportRepository transportRepos;
       
        public MainFormAdmin(Klientas klientas)
        {
            InitializeComponent();
            this.klientas = klientas;
            transportRepos = new TransportRepository();
        }

        private void getTransport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dta = transportRepos.displayTransportas();
                dataGridView1.DataSource = dta;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void AddTransportShow_Click(object sender, EventArgs e)
        {
            addUpdatePanel.Visible = true;
            addUpdateButton.Text = "Add";
            CleanTransport();
        }

        private void updateTransShow_Click(object sender, EventArgs e)
        {
            addUpdatePanel.Visible = true;
            addUpdateButton.Text = "Update";
            CleanTransport();
        }


        private void addUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (addUpdateButton.Text == "Update")
                {

                }
                else if (addUpdateButton.Text == "Add")
                {
                    Transportas transportas = new Transportas();
                    transportas.transporto_Nr = transNr.Text;
                    transportas.tipas = transTipas.Text;
                    transportas.spalva = transSpalva.Text;
                    DateTime gamybDate = DateTime.Parse(transGamybM.Text);
                    transportas.gamybos_Metai = gamybDate.Date;
                    transportas.kaina = int.Parse(transKaina.Text);
                    transportas.markes_Id = int.Parse(transMarkesId.Text);
                    transportas.QRCode = transQrKodas.Text;
                    Transportas insertedTransport = transportRepos.InsertTransport(transportas);
                    if (insertedTransport.spalva != null && insertedTransport.spalva != "")
                    {
                        MessageBox.Show("Succesfully inserted");
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        private void CleanTransport()
        {
            transGamybM.Clear();
            transKaina.Clear();
            transMarkesId.Clear();
            transNr.Clear();
            transTipas.Clear();
            transSpalva.Clear();
            transQrKodas.Clear();
            
        }

        
    }
}
