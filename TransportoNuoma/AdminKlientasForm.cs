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
    }
}
