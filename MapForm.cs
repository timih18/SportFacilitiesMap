using GMap.NET.WindowsForms.Markers;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Configuration;

namespace SportFacilitiesMap
{

    public partial class MapForm : Form
    {
        private GMap.NET.WindowsForms.GMapOverlay overlayFootball;
        private GMap.NET.WindowsForms.GMapOverlay overlayBasketball;
        private GMap.NET.WindowsForms.GMapOverlay overlayTennis;
        private GMap.NET.WindowsForms.GMapOverlay overlayIceSports;
        private GMap.NET.WindowsForms.GMapOverlay overlayVolleyball;
        private GMap.NET.WindowsForms.GMapOverlay overlaySwimming;
        private GMap.NET.WindowsForms.GMapOverlay overlayGYM;
        private GMap.NET.WindowsForms.GMapOverlay overlayTableTennis;
        private int facilitiesCount;
        int[] rated;
        Dictionary<Control, Rectangle> originalSizes;
        System.Drawing.Size originalFormSize;

        public MapForm()
        {
            InitializeComponent();
            overlayFootball = new GMap.NET.WindowsForms.GMapOverlay("Футбол");
            overlayBasketball = new GMap.NET.WindowsForms.GMapOverlay("Баскетбол");
            overlayTennis = new GMap.NET.WindowsForms.GMapOverlay("Теннис");
            overlayIceSports = new GMap.NET.WindowsForms.GMapOverlay("Ледовые виды");
            overlayVolleyball = new GMap.NET.WindowsForms.GMapOverlay("Волейбол");
            overlaySwimming = new GMap.NET.WindowsForms.GMapOverlay("Плавание");
            overlayGYM = new GMap.NET.WindowsForms.GMapOverlay("Тренажеры");
            overlayTableTennis = new GMap.NET.WindowsForms.GMapOverlay("Настольный теннис");

            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            ArrayList sportTypes = new ArrayList();
            Connection.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM facilities", Connection.getConnection());
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    sportTypes.Add(reader["name"].ToString());
                    ++facilitiesCount;
                }
            }
            rated = new int[facilitiesCount];
            Connection.closeConnection();
            source.AddRange((string[])sportTypes.ToArray(typeof(string)));
            FindTextBox.AutoCompleteCustomSource = source;
            FindTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            FindTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            FindTextBox.Text = "Введите название объекта";
            FindTextBox.ForeColor = Color.Gray;
        }

        private void FindTextBox_Enter(object sender, EventArgs e)
        {
            if (FindTextBox.Text == "Введите название объекта")
            {
                FindTextBox.Text = "";
                FindTextBox.ForeColor = Color.Black;
            }
        }

        private void FindTextBox_Leave(object sender, EventArgs e)
        {
            if (FindTextBox.Text == "")
            {
                FindTextBox.Text = "Введите название объекта";
                FindTextBox.ForeColor = Color.Gray;
            }
        }

        private void MapForm_Load(object sender, EventArgs e)
        {
            FindGroupBox.Controls.Add(FindTextBox);
            FindGroupBox.Controls.Add(FindBtn);
            FilterGroupBox.Controls.Add(FilterComboBox);
            FilterGroupBox.Controls.Add(UpdateBtn);
            FacilityGroupBox.Controls.Add(NamePanel);
            FacilityGroupBox.Controls.Add(FacilityPictureBox);
            FacilityGroupBox.Controls.Add(NamePanel);
            NamePanel.Controls.Add(NameLabel);
            FacilityGroupBox.Controls.Add(InfoPanel);
            InfoPanel.Controls.Add(TypePictureBox);
            InfoPanel.Controls.Add(AddressPictureBox);
            InfoPanel.Controls.Add(WorkHoursPictureBox);
            InfoPanel.Controls.Add(SportTypeLabel);
            InfoPanel.Controls.Add(AddressLabel);
            InfoPanel.Controls.Add(WorkHoursLabel);
            FacilityGroupBox.Controls.Add(RatingGroupBox);
            RatingGroupBox.Controls.Add(LikeBtn);
            RatingGroupBox.Controls.Add(DislikeBtn);
            RatingGroupBox.Controls.Add(RatingLabel);

            FilterComboBox.SelectedIndex = 0;
            SystemLabel.Visible = false;
            RatingGroupBox.Visible = false;
            FacilityPictureBox.Visible = false;
            NamePanel.Visible = false;
            InfoPanel.Visible = false;

            originalSizes = new Dictionary<Control, Rectangle>();
            foreach (Control control in this.Controls)
            {
                originalSizes.Add(control, new Rectangle(
                    control.Location.X, control.Location.Y,
                    control.Width, control.Height));
            }
            originalFormSize = this.Size;
        }

        private void AddMarkers()
        {
            for (int i = 1; i <= facilitiesCount; ++i)
            {
                Facility facility = new Facility(i);
                GMarkerGoogle marker = new GMarkerGoogle(new GMap.NET.PointLatLng(facility.Latitude, facility.Longtitude), GMarkerGoogleType.red);
                marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                marker.ToolTipText = facility.Name;
                marker.ToolTipMode = GMap.NET.WindowsForms.MarkerTooltipMode.OnMouseOver;
                marker.Tag = facility.Id;

                string? type = facility.Type;
                if (type == "Футбол") overlayFootball.Markers.Add(marker);
                else if (type == "Баскетбол") overlayBasketball.Markers.Add(marker);
                else if (type == "Теннис") overlayTennis.Markers.Add(marker);
                else if (type == "Ледовые виды") overlayIceSports.Markers.Add(marker);
                else if (type == "Волейбол") overlayVolleyball.Markers.Add(marker);
                else if (type == "Плавание") overlaySwimming.Markers.Add(marker);
                else if (type == "Тренажеры") overlayGYM.Markers.Add(marker);
                else overlayTableTennis.Markers.Add(marker);
            }

            MapCtrl.Overlays.Add(overlayFootball);
            MapCtrl.Overlays.Add(overlayBasketball);
            MapCtrl.Overlays.Add(overlayTennis);
            MapCtrl.Overlays.Add(overlayIceSports);
            MapCtrl.Overlays.Add(overlayVolleyball);
            MapCtrl.Overlays.Add(overlaySwimming);
            MapCtrl.Overlays.Add(overlayGYM);
            MapCtrl.Overlays.Add(overlayTableTennis);
        }

        private void MapCtrl_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            MapCtrl.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;

            MapCtrl.MinZoom = 2;
            MapCtrl.MaxZoom = 20;
            MapCtrl.Zoom = 15;
            MapCtrl.Position = new GMap.NET.PointLatLng(55.604930, 37.539886);

            MapCtrl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            MapCtrl.CanDragMap = true;
            MapCtrl.DragButton = MouseButtons.Left;
            MapCtrl.ShowCenter = false;
            MapCtrl.ShowTileGridLines = false;

            AddMarkers();
            MapCtrl.MouseDoubleClick += MapMouseDoubleClick;
        }

        private void FacilityInfo(Facility facility)
        {
            NameLabel.Text = facility.Name;
            SystemLabel.Text = facility.Id.ToString();
            SportTypeLabel.Text = facility.Type;
            AddressLabel.Text = facility.Address;
            WorkHoursLabel.Text = facility.Work_hours;
            RatingLabel.Text = facility.Likes.ToString() + '/' + facility.Dislikes.ToString();
            FacilityPictureBox.Image = Image.FromFile(facility.Photo);

            if (rated[facility.Id - 1] == 1) { LikeBtn.Visible = false; DislikeBtn.Visible = false; }
            else { LikeBtn.Visible = true; DislikeBtn.Visible = true; }
            RatingGroupBox.Visible = true;
            FacilityPictureBox.Visible = true;
            NamePanel.Visible = true;
            InfoPanel.Visible = true;
            StartLabel.Visible = false;
        }

        private void MapMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (var overlay in MapCtrl.Overlays)
                {
                    foreach (var marker in overlay.Markers)
                    {
                        if (IsClickOnMarker(marker, e.X, e.Y))
                        {
                            Facility facility = new Facility(Convert.ToInt32(marker.Tag));
                            FacilityInfo(facility);
                            return;
                        }
                    }
                }
            }
        }

        private bool IsClickOnMarker(GMap.NET.WindowsForms.GMapMarker marker, int x, int y)
        {
            var markerPosition = MapCtrl.FromLatLngToLocal(marker.Position);
            int possibleMistake = 10;
            return Math.Abs(markerPosition.X - x) <= possibleMistake && Math.Abs(markerPosition.Y - y - 15) <= possibleMistake;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string? selection = FilterComboBox.SelectedItem.ToString();
            MapCtrl.Overlays.Clear();
            if (selection == "Все")
            {
                MapCtrl.Overlays.Add(overlayFootball);
                MapCtrl.Overlays.Add(overlayBasketball);
                MapCtrl.Overlays.Add(overlayTennis);
                MapCtrl.Overlays.Add(overlayIceSports);
                MapCtrl.Overlays.Add(overlayVolleyball);
                MapCtrl.Overlays.Add(overlaySwimming);
                MapCtrl.Overlays.Add(overlayGYM);
                MapCtrl.Overlays.Add(overlayTableTennis);
            }
            else if (selection == "Футбол")
            {
                MapCtrl.Overlays.Add(overlayFootball);
            }
            else if (selection == "Баскетбол")
            {
                MapCtrl.Overlays.Add(overlayBasketball);
            }
            else if (selection == "Теннис")
            {
                MapCtrl.Overlays.Add(overlayTennis);
            }
            else if (selection == "Ледовые виды")
            {
                MapCtrl.Overlays.Add(overlayIceSports);
            }
            else if (selection == "Волейбол")
            {
                MapCtrl.Overlays.Add(overlayVolleyball);
            }
            else if (selection == "Плавание")
            {
                MapCtrl.Overlays.Add(overlaySwimming);
            }
            else if (selection == "Тренажеры")
            {
                MapCtrl.Overlays.Add(overlayGYM);
            }
            else
            {
                MapCtrl.Overlays.Add(overlayTableTennis);
            }
        }

        private void ZoomInBtn_Click(object sender, EventArgs e) { ++MapCtrl.Zoom; }
        private void ZoomOutBtn_Click(object sender, EventArgs e) { --MapCtrl.Zoom; }

        private void LikeBtn_Click(object sender, EventArgs e)
        {
            Facility facility = new Facility(Convert.ToInt32(SystemLabel.Text));
            RatingLabel.Text = (++facility.Likes).ToString() + '/' + facility.Dislikes.ToString();
            Connection.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE facilities SET likes = @likes WHERE id = @id", Connection.getConnection());
            command.Parameters.AddWithValue("@likes", facility.Likes);
            command.Parameters.AddWithValue("@id", facility.Id);
            command.ExecuteNonQuery();
            rated[facility.Id - 1] = 1;
            LikeBtn.Visible = false;
            DislikeBtn.Visible = false;
            Connection.closeConnection();
        }

        private void DislikeBtn_Click(object sender, EventArgs e)
        {
            Facility facility = new Facility(Convert.ToInt32(SystemLabel.Text));
            RatingLabel.Text = facility.Likes.ToString() + '/' + (++facility.Dislikes).ToString();
            Connection.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE facilities SET dislikes = @dislikes WHERE id = @id", Connection.getConnection());
            command.Parameters.AddWithValue("@dislikes", facility.Dislikes);
            command.Parameters.AddWithValue("@id", facility.Id);
            command.ExecuteNonQuery();
            rated[facility.Id - 1] = 1;
            LikeBtn.Visible = false;
            DislikeBtn.Visible = false;
            Connection.closeConnection();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            using (MySqlCommand command = new MySqlCommand("SELECT COUNT(1) FROM facilities WHERE name_lower = @name_lower", Connection.getConnection()))
            {
                command.Parameters.AddWithValue("@name_lower", FindTextBox.Text.ToLower());
                Connection.openConnection();
                flag = Convert.ToInt32(command.ExecuteScalar()) > 0;
                Connection.closeConnection();
            }

            if (flag)
            {
                Facility facility = new Facility(FindTextBox.Text.ToLower());
                FacilityInfo(facility);
            }
            else { MessageBox.Show("Объекта с таким именем нет в базе!"); }
        }

        private void AuthorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var process = new ProcessStartInfo
                {
                    FileName = "https://github.com/timih18/SportFacilitiesMap",
                    UseShellExecute = true
                };
                Process.Start(process);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void MapForm_Resize(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (originalSizes != null && originalSizes.ContainsKey(control))
                {
                    Rectangle originalRect = originalSizes[control];

                    float xRatio = (float)this.Width / (float)originalFormSize.Width;
                    float yRatio = (float)this.Height / (float)originalFormSize.Height;

                    control.Location = new Point(
                        (int)(originalRect.X * xRatio),
                        (int)(originalRect.Y * yRatio));

                    control.Size = new Size(
                        (int)(originalRect.Width * xRatio),
                        (int)(originalRect.Height * yRatio));
                }
            }
        }
    }
}
