using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MySql.Data.MySqlClient;
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
    public partial class MainForm : Form
    {
        Klientas klientas;
        List<GMapMarker> gMapOverlayslist = new List<GMapMarker>();
        KlientoLokacijaRepository klientoLokacijaRepository;
        LokacijaRepository lokacijaRepository;
        

        public MainForm(Klientas klientas)
        {
            InitializeComponent();
            this.klientas = klientas;

            createClientMarker();
            loadMap();
        }
        void loadMap()
        {
            gmap.MapProvider = GMapProviders.GoogleMap;

            gmap.Position = new PointLatLng(54.678175, 25.279267);
            gmap.ShowCenter = false;
            gmap.MinZoom = 1;
            gmap.MaxZoom = 100;
            gmap.Zoom = 10;

            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(54.678175, 25.279267),
                    GMarkerGoogleType.green);

            marker.Tag = gMapOverlayslist.Count;
            gMapOverlayslist.Add(marker);
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
            marker.ToolTipText = "hello\nout there";
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;

        }


        public void createClientMarker()
        {


            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(54.679341, 25.279297),
                    GMarkerGoogleType.red);
            marker.Tag = gMapOverlayslist.Count;
            gMapOverlayslist.Add(marker);
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
            marker.ToolTipText = "hello " + klientas.vardas;
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
        }
        

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Console.WriteLine(String.Format("Marker {0} was clicked.", item.Tag));
        }
    }
}
