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
using GMap.NET.WindowsForms.ToolTips;
using THT.OrderManagementSystem.Data.ModelView;
using THT.OrderManagementSystem.Framework;
using THT.OrderManagementSystem.Services;

namespace THT.OrderManagementSystem.Forms
{
    public partial class frmShopScan : DevExpress.XtraEditors.XtraForm
    {
        private List<ShopScanEntity> currentList;
        public frmShopScan()
        {   
            InitializeComponent();
            currentList = new List<ShopScanEntity>();
        }

        private void frmVisitLog_Load(object sender, EventArgs e)
        {
            try
            {
                filtercmbVisitor.Properties.DisplayMember = "Visitor_Name";
                filtercmbVisitor.Properties.ValueMember = "Visitor_Code";
                filtercmbVisitor.Properties.DataSource = GlobalService.Repository.GetAllVisitors();
                Activate();
                gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gMapControl1.Position = new PointLatLng(36.285359, 59.561576);
                gMapControl1.Zoom = 12;
                filtertbxFromTime.Value = filtertbxToTime.Value = DateTime.Now;
            }
            catch (Exception exception)
            {
                ErrorLog.SaveLog(exception);
            }
        }

        private void btnFilterSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int? fvisitorcode = null;
                if (filtercmbVisitor.EditValue != null)
                {
                    fvisitorcode = filtercmbVisitor.EditValue.ToInt();
                }

                currentList = GlobalService.Repository.GetAllShopScan(fvisitorcode,
                    filtertbxWorkingBrands.Text, filtertbxMemo.Text, filtertbxFromTime.Value,
                    filtertbxToTime.Value);
                dgvMain.DataSource = currentList;

                gMapControl1.Position = new PointLatLng(36.285359, 59.561576);
                gMapControl1.Zoom = 12;
                gMapControl1.Overlays.Clear();

                var markersOverlay = new GMapOverlay("markers");

                gMapControl1.Overlays.Add(markersOverlay);

                foreach (var item in currentList.Where(l =>
                    !string.IsNullOrWhiteSpace(l.Latitude) && !string.IsNullOrWhiteSpace(l.Longitude)))
                {

                    switch (item.MapColor)
                    {
                        case "white":
                            var marker = new GMarkerGoogle(new PointLatLng(item.Latitude.ToDouble(), item.Longitude.ToDouble()), GMarkerGoogleType.white_small);
                            marker.ToolTip = new GMapRoundedToolTip(marker);
                            marker.ToolTipText = item.VisitorName;
                            marker.Tag = item.ID;
                            markersOverlay.Markers.Add(marker);
                            break;
                        case "red":
                            var marker1 = new GMarkerGoogle(new PointLatLng(item.Latitude.ToDouble(), item.Longitude.ToDouble()), GMarkerGoogleType.red);
                            marker1.ToolTip = new GMapRoundedToolTip(marker1);
                            marker1.ToolTipText = item.VisitorName;
                            marker1.Tag = item.ID;
                            markersOverlay.Markers.Add(marker1);
                            break;
                        case "blue":
                            var marker2 = new GMarkerGoogle(new PointLatLng(item.Latitude.ToDouble(), item.Longitude.ToDouble()), GMarkerGoogleType.blue);
                            marker2.ToolTip = new GMapRoundedToolTip(marker2);
                            marker2.ToolTipText = item.VisitorName;
                            marker2.Tag = item.ID;
                            markersOverlay.Markers.Add(marker2);
                            break;
                        case "green":
                            var marker3 = new GMarkerGoogle(new PointLatLng(item.Latitude.ToDouble(), item.Longitude.ToDouble()), GMarkerGoogleType.green);
                            marker3.ToolTip = new GMapRoundedToolTip(marker3);
                            marker3.ToolTipText = item.VisitorName;
                            marker3.Tag = item.ID;
                            markersOverlay.Markers.Add(marker3);
                            break;
                        case "yellow":
                            var marker4 = new GMarkerGoogle(new PointLatLng(item.Latitude.ToDouble(), item.Longitude.ToDouble()), GMarkerGoogleType.yellow);
                            marker4.ToolTip = new GMapRoundedToolTip(marker4);
                            marker4.ToolTipText = item.VisitorName;
                            marker4.Tag = item.ID;
                            markersOverlay.Markers.Add(marker4);
                            break;
                        case "orange":
                            var marker5 = new GMarkerGoogle(new PointLatLng(item.Latitude.ToDouble(), item.Longitude.ToDouble()), GMarkerGoogleType.orange);
                            marker5.ToolTip = new GMapRoundedToolTip(marker5);
                            marker5.ToolTipText = item.VisitorName;
                            marker5.Tag = item.ID;
                            markersOverlay.Markers.Add(marker5);
                            break;
                        case "purple":
                            var marker6 = new GMarkerGoogle(new PointLatLng(item.Latitude.ToDouble(), item.Longitude.ToDouble()), GMarkerGoogleType.purple);
                            marker6.ToolTip = new GMapRoundedToolTip(marker6);
                            marker6.ToolTipText = item.VisitorName;
                            marker6.Tag = item.ID;
                            markersOverlay.Markers.Add(marker6);
                            break;
                        default:
                            var marker7 = new GMarkerGoogle(new PointLatLng(item.Latitude.ToDouble(), item.Longitude.ToDouble()), GMarkerGoogleType.black_small);
                            marker7.ToolTip = new GMapRoundedToolTip(marker7);
                            marker7.ToolTipText = item.VisitorName;
                            marker7.Tag = item.ID;
                            markersOverlay.Markers.Add(marker7);
                            break;
                    }

                }

                gMapControl1.Position = markersOverlay.Markers.Last(l => true).Position;

            }
            catch (Exception exception)
            {
                ErrorLog.SaveLog(exception);
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            try
            {
                filtercmbVisitor.EditValue = null;
                filtertbxMemo.Text  = filtertbxWorkingBrands.Text = string.Empty;
                filtertbxFromTime.Value = filtertbxToTime.Value = null;
                btnFilterSearch_Click(null, null);
            }
            catch (Exception exception)
            {
                ErrorLog.SaveLog(exception);
            }
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            try
            {
                var obj = currentList.FirstOrDefault(l => l.ID == item.Tag.ToInt());
                var str = new StringBuilder();
                if (obj != null)
                {
                    str.Append("ویزیتور : " + obj.VisitorName + Environment.NewLine);
                    str.Append("آدرس : " + obj.Address + Environment.NewLine);
                    str.Append("تاریخ اسکن : " + obj.SaveTimeFa + Environment.NewLine);
                    str.Append("توضیحات : " + obj.Memo + Environment.NewLine);
                    str.Append("Latitude : " + obj.Latitude + Environment.NewLine);
                    str.Append("Longitude : " + obj.Longitude + Environment.NewLine);
                }

                MessageBox.Show(str.ToString(), @"اطلاعات اسکن", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (Exception exception)
            {
                ErrorLog.SaveLog(exception);
            }
        }

        private void dgvMains_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (dgvMains.IsFilterRow(dgvMains.FocusedRowHandle)) return;
                var selected = dgvMains.GetSelectedRows();
                if (selected == null || selected.Length <= 0) return;
                var id = Convert.ToInt32(dgvMains.GetRowCellDisplayText(dgvMains.FocusedRowHandle, dgvMains.Columns["ID"]));
                if (!string.IsNullOrWhiteSpace(currentList.FirstOrDefault(l => l.ID == id)?.Latitude) &&
                    !string.IsNullOrWhiteSpace(currentList.FirstOrDefault(l => l.ID == id)?.Longitude))
                {
                    if (gMapControl1.Overlays.Count > 0 && gMapControl1.Overlays[0].Markers.Count > 0)
                    {
                        gMapControl1.Position = gMapControl1.Overlays[0].Markers.Last(l => l.Tag.ToInt() == id).Position;
                        gMapControl1.Zoom = 17;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void BtnResetFilters_Click(object sender, EventArgs e)
        {
            try
            {
                filtercmbVisitor.EditValue = null;
                filtertbxMemo.Text = filtertbxWorkingBrands.Text = string.Empty;
                filtertbxFromTime.Value = filtertbxToTime.Value = DateTime.Now;
                btnFilterSearch_Click(null, null);
            }
            catch (Exception exception)
            {
                ErrorLog.SaveLog(exception);
            }
        }

        private void tsMenuItemExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu1.Collapse(false);
            System.Windows.Forms.SaveFileDialog saveDlg = new System.Windows.Forms.SaveFileDialog();
            saveDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveDlg.Filter = "Excel files (*.xls)|*.xls";
            saveDlg.FilterIndex = 0;
            saveDlg.RestoreDirectory = true;
            saveDlg.Title = "Export Excel File To";
            if (saveDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = saveDlg.FileName;
                string FileName = path;
                dgvMain.ExportToXls(FileName);
            }
        }

        private void dgvMains_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (!dgvMains.IsFilterRow(dgvMains.FocusedRowHandle) || dgvMains.RowCount == 0)
            {
                e.Allow = false;
                radialMenu1.ShowPopup(dgvMain.PointToScreen(e.Point));
            }
            else
            {
                e.Allow = true;
            }
        }
    }
}