using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using TransportoNuoma.Classes;
using TransportoNuoma.Repositories;
namespace TransportoNuoma
{
    public partial class MainForm : Form
    {
        int h, m, s;
        Klientas klientas;
        KlientoLokacija klientoLokacija;
        List<GMapMarker> gMapOverlayslist = new List<GMapMarker>();
        KlientoLokacijaRepository klientoLokacijaRepository;
        LokacijaRepository lokacijaRepository = new LokacijaRepository();
        TransportRepository transportRepository = new TransportRepository();
        List<Transportas> transportList = new List<Transportas>();
        Lokacija transportoLokacija;
        CancellationTokenSource cts;
        Thread th;
        delegate void CancellationThreadHandler();
        System.Timers.Timer t;
        Transportas rezervuotasTransportas;
        RezervacijaRepository rezervacijaRepository;
       
        public MainForm(Klientas klientas)
        {
            InitializeComponent();
            this.klientas = klientas;
            klientoLokacijaRepository = new KlientoLokacijaRepository();
            rezervuotasTransportas = new Transportas();
            rezervacijaRepository = new RezervacijaRepository();
           
            Console.WriteLine(klientas.klientoNr);
            createClientMarker();
            transportList = transportRepository.getTransportList();
            Console.WriteLine(transportList.Count);

            loadMap();
        }
        void loadMap()
        {
            gmap.Refresh();
            gmap.MapProvider = GMapProviders.GoogleMap;

            gmap.Position = new PointLatLng(54.678175, 25.279267);
            gmap.ShowCenter = false;
            gmap.MinZoom = 1;
            gmap.MaxZoom = 100;
            gmap.Zoom = 10;

            addTransMarkers();
        }
        void addTransMarkers()
        {
            foreach (Transportas transportas in transportList)
            {
                transportoLokacija = lokacijaRepository.getTransportoLokacija(transportas);
                if(rezervacijaRepository.isTransportasTaken(transportas) == false)
                {
                    GMapOverlay markers = new GMapOverlay("markers");
                    GMapMarker marker = new GMarkerGoogle(
                    new PointLatLng(transportoLokacija.koordinatesX, transportoLokacija.koordinatesY),
                        GMarkerGoogleType.green);

                    marker.Tag = transportas.transporto_Id;
                    gMapOverlayslist.Add(marker);
                    markers.Markers.Add(marker);
                    gmap.Overlays.Add(markers);
                    marker.ToolTipText = String.Format("\nPaspirtuko numeris: {0}\nPaspirtuko spalva: {1}\nPaspirtuko kaina: {2}", transportas.transporto_Nr, transportas.spalva, transportas.kaina);
                    marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                }
            }
        }

        public void createClientMarker()
        {
            klientoLokacija = klientoLokacijaRepository.GetKlientoLokacija(klientas);

            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(
               new PointLatLng(klientoLokacija.koorindatesX, klientoLokacija.koorindatesY),
                    GMarkerGoogleType.red);
            marker.Tag = gMapOverlayslist.Count;
            gMapOverlayslist.Add(marker);
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
            marker.ToolTipText = "hello " + klientas.vardas;
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
        }
        //new PointLatLng(54.679341, 25.279297)


        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (Convert.ToInt32(item.Tag) != 0)
            {
                Console.WriteLine(String.Format("Marker {0} was clicked.", item.Tag));
                
                
                switch (MessageBox.Show("Ar norite užsirezervuoti šį paspirtuką?",
                  "Vroom vroom.. :)",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        
                        rezervuotasTransportas = transportRepository.getTransportasByID(Convert.ToInt32(item.Tag));
                        cts = new CancellationTokenSource();
                        //kuriame cancelation token
                        CancellationToken ct = cts.Token;

                        if (rezervacijaRepository.addNewRezervacija(klientas, rezervuotasTransportas, transportoLokacija) == true)
                        {
                            rezervacijosPanel.Visible = true;
                            th = new Thread(() => { CountDownMethod(ct, CancellationMethod); });
                            th.Start();
                            MessageBox.Show("Rezervacija sekmynga!");
                            
                            loadMap();
                        }
                        else { MessageBox.Show("Rezervacija nepavyko :("); }
                        break;

                    case DialogResult.No:

                        break;


                }
            }

        }

        private void CountDownMethod(CancellationToken ct, CancellationThreadHandler handler)
        {
            int m, s;


            for (int i = 900; i >= 0; i--)
            {
                try
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        m = i / 60;
                        s = i % 60;

                        timeLabel.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                    });

                    Thread.Sleep(1000);
                    if (ct.IsCancellationRequested)//jeigu buvo signalas nutraukti tada funkcija yra cancelenima
                    {
                        if (handler != null)
                        {
                            handler();//iskvieciam metoda handler, kuris pakvies Cancellation metoda

                            return;//padarome return, veiksmas bus atsaukiamas
                                   //mes perduosime viska kitai gijai. kuri atliks visus tuos cancelation dalyduks
                        }
                    }

                }
                catch(Exception ex) { Console.WriteLine(ex.Message); }
                
            }
        }
        private void CancellationMethod()
        {
            //atsaukimas ant kitos gijos. tada ta gija savo darba pabaigs
            Thread th = new Thread(() =>
            {
                Console.WriteLine(Thread.CurrentThread.Name + ": " + "cancelling...");
                Console.WriteLine(Thread.CurrentThread.Name + ": " + "cancelled.");
            });
            th.Name = "CancellationThread";
            th.Start();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            cts.Cancel();
            rezervacijosPanel.Visible = false;
            rezervacijaRepository.CancelRezervacija(klientas);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cts != null) { cts.Cancel();}            
        }

        private void unlockButton_Click(object sender, EventArgs e)
        {
            cts.Cancel();
            priceLabel.Text = string.Format("0.00€");
            t = new System.Timers.Timer();
            t.Interval = 1000; // sec
            t.Elapsed += OnTimeEvent;
            t.Start();
            
        }
        
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {

            s += 1;
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            if (m == 60)
            {
                m = 0;
                h += 1;
            }
            this.BeginInvoke((MethodInvoker)delegate { timeLabel.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0')); });
            
        }
    }
}
