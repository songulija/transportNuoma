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
    public partial class MainForm : Form
    {
        Klientas klientas;
        public MainForm(Klientas klientas)
        {
            InitializeComponent();
            this.klientas = klientas;
        }
    }
}
