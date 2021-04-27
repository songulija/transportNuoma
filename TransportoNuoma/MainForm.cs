using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
            List<GMapOverlay> gMapOverlayslist = new List<GMapOverlay>();
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(54.678175, 25.279267),
                    GMarkerGoogleType.green);
            marker.Tag = gMapOverlayslist.Count;
            markers.Markers.Add(marker);
            gmap.Overlays.Add(markers);
        }
    }
}
