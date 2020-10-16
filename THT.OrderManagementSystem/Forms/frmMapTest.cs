using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace THT.OrderManagementSystem.Forms
{
    public partial class frmMapTest : DevExpress.XtraEditors.XtraForm
    {
        public frmMapTest()
        {
            InitializeComponent();
        }

        private void frmMapTest_Load(object sender, EventArgs e)
        {
            Activate();
            TopMost = true;
            TopMost = false;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.Position = new PointLatLng(36.285359, 59.561576);
            gMapControl1.Zoom = 17;

            var markersOverlay = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(new PointLatLng(36.285359, 59.561576),
                GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markersOverlay);


            var markersOverlay1 = new GMapOverlay("markers");
            var marker1 = new GMarkerGoogle(new PointLatLng(36.285359, 59.562576),
                GMarkerGoogleType.blue);
            markersOverlay1.Markers.Add(marker1);
            gMapControl1.Overlays.Add(markersOverlay1);
        }
    }
}