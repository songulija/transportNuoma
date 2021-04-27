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

namespace TransportoNuoma
{
    public partial class MainFormAdmin : Form
    {
        Klientas klientas;
        public MainFormAdmin(Klientas klientas)
        {
            InitializeComponent();
            this.klientas = klientas;
        }

        private void getTransport_Click(object sender, EventArgs e)
        {

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
