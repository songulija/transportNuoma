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
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
namespace TransportoNuoma
{
    public partial class MainFormWorker : Form
    {
        Klientas klientas;
        KlientoLokacija klientoLokacija = new KlientoLokacija();
        List<GMapMarker> gMapOverlayslist = new List<GMapMarker>();
        KlientoLokacijaRepository klientoLokacijaRepository = new KlientoLokacijaRepository();
        LokacijaRepository lokacijaRepository = new LokacijaRepository();
        TransportRepository transportRepository = new TransportRepository();
        NuomaRepository nuomaRepository = new NuomaRepository();
        List<Transportas> transportList = new List<Transportas>();
        Lokacija transportoLokacija = new Lokacija();
        
        Transportas rezervuotasTransportas = new Transportas();
        RezervacijaRepository rezervacijaRepository = new RezervacijaRepository();
        Rezervacija rezervacija = new Rezervacija();
        Nuoma nuoma = new Nuoma();

        public MainFormWorker(Klientas klientas)
        {
            InitializeComponent();
            this.klientas = klientas;
            transportList = transportRepository.getTransportList();
            LoadMap();
            createClientMarker();
            addTransMarkers();
        }
        void LoadMap()
        {
            gmap.Overlays.Clear();
            gmap.MapProvider = GMapProviders.GoogleMap;

            gmap.Position = new PointLatLng(54.678175, 25.279267);
            gmap.ShowCenter = false;
            gmap.MinZoom = 1;
            gmap.MaxZoom = 100;
            gmap.Zoom = 14;

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
        void addTransMarkers()
        {
            foreach (Transportas transportas in transportList)
            {
                transportoLokacija = lokacijaRepository.getTransportoLokacija(transportas);
                
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
}
