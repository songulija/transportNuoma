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
    public partial class AdminTestingScreen : Form
    {
        Klientas klientas;
        TransTestRepository transTestRep;
        TransportRepository transportRep;
        GalimiTestaiRepository galimiTestRep;
        public AdminTestingScreen(Klientas klientas)
        {
            InitializeComponent();
            this.klientas = klientas;
            transTestRep = new TransTestRepository();
            transportRep = new TransportRepository();
            galimiTestRep = new GalimiTestaiRepository();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainFormAdmin admin = new MainFormAdmin(klientas);
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }

        private void getTransport_Click(object sender, EventArgs e)
        {
            try
            {
                getTransTest();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void addTransTest_Click(object sender, EventArgs e)
        {
            try
            {
                TransportoTestai test = new TransportoTestai();
                DateTime testoData = DateTime.Parse(addTransTestData.Text);
                test.test_Data = testoData.Date;
                test.trans_Id = int.Parse(addTransTestTransId.Text);
                TransportoTestai insertedTest = transTestRep.InsertTransTest(test);

                addTransTestData.Clear();
                addTransTestTransId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Succesfully inserted");
            getTransTest();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                TransportoTestai test = new TransportoTestai();
                DateTime testoData = DateTime.Parse(updateTransTestData.Text);
                test.test_Data = testoData.Date;
                test.trans_Id = int.Parse(updateTransTestTransId.Text);
                test.test_Id = int.Parse(updateTransTestTestId.Text);
                transTestRep.UpdateTransTest(test);

                updateTransTestData.Clear();
                updateTransTestTransId.Clear();
                updateTransTestTestId.Clear();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            MessageBox.Show("Succesfully updated");
            getTransTest();
        }

        private void AddTransportShow_Click(object sender, EventArgs e)
        {
            updateTransTestPanel.Visible = false;
            addTransTestPanel.Visible = true;

        }

        private void updateTransShow_Click(object sender, EventArgs e)
        {
            addTransTestPanel.Visible = false;
            updateTransTestPanel.Visible = true;
        }


        void getTransTest()
        {
            try
            {
                //FOR TESTS
                DataTable dta = transTestRep.displayTransTest();
                dataGridView1.DataSource = dta;

                //FOR TRANSPORT
                DataTable dta1 = transportRep.displayTransportas();
                dataGridView2.DataSource = dta1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void addGalimiTestShow_Click(object sender, EventArgs e)
        {
            updateGalimiTestPanel.Visible = false;
            addGalimiTestPanel.Visible = true;
        }

        private void updateGalimiTestShow_Click(object sender, EventArgs e)
        {
            addGalimiTestPanel.Visible = false;
            updateGalimiTestPanel.Visible = true;
        }

        private void getGalimiTest_Click(object sender, EventArgs e)
        {
            try
            {
                getGalimiTestDisplay();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void addGalimiTest_Click(object sender, EventArgs e)
        {
            try
            {
                GalimiTestai gt = new GalimiTestai();
                gt.testPav = addGalimiTestTestPav.Text;
                gt.testId = int.Parse(addGalimiTestTestId.Text);

                GalimiTestai insertedGalimiTest = galimiTestRep.InsertGalimiTestai(gt);
                if(insertedGalimiTest.testPav!=null && insertedGalimiTest.testPav != "")
                {
                    MessageBox.Show("Succesfully inserted");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            getGalimiTestDisplay();
        }

        private void updateGalimiTest_Click(object sender, EventArgs e)
        {
            try
            {
                GalimiTestai gt = new GalimiTestai();
                gt.testPav = updateGalimiTestTestPav.Text;
                gt.testId = int.Parse(updateGalimiTestTestId.Text);
                gt.testoKodas = int.Parse(updateGalimiTestTestoKodas.Text);

                galimiTestRep.UpdateGalimiTestai(gt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Succesfully updated");
            getGalimiTestDisplay();
        }


        void getGalimiTestDisplay()
        {
            try
            {
                //FOR TESTS
                DataTable dta = galimiTestRep.displayGalimiTestai();
                dataGridView4.DataSource = dta;

                //FOR TRANSPORT
                DataTable dta1 = transTestRep.displayTransTest();
                dataGridView3.DataSource = dta1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


    }
}
