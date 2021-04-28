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
    public partial class AdminLokacijaForm : Form
    {
        Klientas klientas;
        public AdminLokacijaForm(Klientas klientas)
        {
            InitializeComponent();
            this.klientas = klientas;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainFormAdmin admin = new MainFormAdmin(klientas);
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }
    }
}
