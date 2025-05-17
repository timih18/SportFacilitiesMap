namespace SportFacilitiesMap
{
    partial class MapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MapCtrl = new GMap.NET.WindowsForms.GMapControl();
            ZoomInBtn = new Button();
            ZoomOutBtn = new Button();
            FindGroupBox = new GroupBox();
            FindTextBox = new TextBox();
            FindBtn = new Button();
            FilterGroupBox = new GroupBox();
            UpdateBtn = new Button();
            FilterComboBox = new ComboBox();
            FacilityGroupBox = new GroupBox();
            StartLabel = new Label();
            SystemLabel = new Label();
            RatingGroupBox = new GroupBox();
            RatingLabel = new Label();
            DislikeBtn = new Button();
            LikeBtn = new Button();
            InfoPanel = new TableLayoutPanel();
            TypePictureBox = new PictureBox();
            AddressPictureBox = new PictureBox();
            WorkHoursPictureBox = new PictureBox();
            SportTypeLabel = new Label();
            WorkHoursLabel = new Label();
            AddressLabel = new Label();
            NamePanel = new TableLayoutPanel();
            NameLabel = new Label();
            FacilityPictureBox = new PictureBox();
            AuthorLinkLabel = new LinkLabel();
            FindGroupBox.SuspendLayout();
            FilterGroupBox.SuspendLayout();
            FacilityGroupBox.SuspendLayout();
            RatingGroupBox.SuspendLayout();
            InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TypePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddressPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WorkHoursPictureBox).BeginInit();
            NamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FacilityPictureBox).BeginInit();
            SuspendLayout();
            // 
            // MapCtrl
            // 
            MapCtrl.Bearing = 0F;
            MapCtrl.CanDragMap = true;
            MapCtrl.EmptyTileColor = Color.Navy;
            MapCtrl.GrayScaleMode = false;
            MapCtrl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            MapCtrl.LevelsKeepInMemory = 5;
            MapCtrl.Location = new Point(741, 12);
            MapCtrl.MarkersEnabled = true;
            MapCtrl.MaxZoom = 2;
            MapCtrl.MinZoom = 2;
            MapCtrl.MouseWheelZoomEnabled = true;
            MapCtrl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            MapCtrl.Name = "MapCtrl";
            MapCtrl.NegativeMode = false;
            MapCtrl.PolygonsEnabled = true;
            MapCtrl.RetryLoadTile = 0;
            MapCtrl.RoutesEnabled = true;
            MapCtrl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            MapCtrl.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            MapCtrl.ShowTileGridLines = false;
            MapCtrl.Size = new Size(729, 729);
            MapCtrl.TabIndex = 0;
            MapCtrl.Zoom = 0D;
            MapCtrl.Load += MapCtrl_Load;
            // 
            // ZoomInBtn
            // 
            ZoomInBtn.Font = new Font("Segoe UI", 9F);
            ZoomInBtn.Location = new Point(741, 347);
            ZoomInBtn.Name = "ZoomInBtn";
            ZoomInBtn.Size = new Size(30, 30);
            ZoomInBtn.TabIndex = 1;
            ZoomInBtn.Text = "+";
            ZoomInBtn.UseVisualStyleBackColor = true;
            ZoomInBtn.Click += ZoomInBtn_Click;
            // 
            // ZoomOutBtn
            // 
            ZoomOutBtn.Font = new Font("Segoe UI", 9F);
            ZoomOutBtn.Location = new Point(741, 377);
            ZoomOutBtn.Name = "ZoomOutBtn";
            ZoomOutBtn.Size = new Size(30, 30);
            ZoomOutBtn.TabIndex = 2;
            ZoomOutBtn.Text = "-";
            ZoomOutBtn.UseVisualStyleBackColor = true;
            ZoomOutBtn.Click += ZoomOutBtn_Click;
            // 
            // FindGroupBox
            // 
            FindGroupBox.Controls.Add(FindTextBox);
            FindGroupBox.Controls.Add(FindBtn);
            FindGroupBox.Location = new Point(12, 12);
            FindGroupBox.Name = "FindGroupBox";
            FindGroupBox.Size = new Size(358, 106);
            FindGroupBox.TabIndex = 3;
            FindGroupBox.TabStop = false;
            FindGroupBox.Text = "Поиск объекта";
            // 
            // FindTextBox
            // 
            FindTextBox.ForeColor = SystemColors.WindowText;
            FindTextBox.Location = new Point(6, 26);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(346, 27);
            FindTextBox.TabIndex = 1;
            FindTextBox.Enter += FindTextBox_Enter;
            FindTextBox.Leave += FindTextBox_Leave;
            // 
            // FindBtn
            // 
            FindBtn.Location = new Point(6, 59);
            FindBtn.Name = "FindBtn";
            FindBtn.Size = new Size(346, 29);
            FindBtn.TabIndex = 0;
            FindBtn.Text = "Найти объект";
            FindBtn.UseVisualStyleBackColor = true;
            FindBtn.Click += FindBtn_Click;
            // 
            // FilterGroupBox
            // 
            FilterGroupBox.Controls.Add(UpdateBtn);
            FilterGroupBox.Controls.Add(FilterComboBox);
            FilterGroupBox.Location = new Point(377, 12);
            FilterGroupBox.Name = "FilterGroupBox";
            FilterGroupBox.Size = new Size(358, 106);
            FilterGroupBox.TabIndex = 4;
            FilterGroupBox.TabStop = false;
            FilterGroupBox.Text = "Фильтр карты";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(6, 59);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(346, 29);
            UpdateBtn.TabIndex = 1;
            UpdateBtn.Text = "Обновить карту";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // FilterComboBox
            // 
            FilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Items.AddRange(new object[] { "Все", "Футбол", "Баскетбол", "Волейбол", "Теннис", "Настольный теннис", "Плавание", "Тренажеры", "Ледовые виды" });
            FilterComboBox.Location = new Point(6, 25);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(346, 28);
            FilterComboBox.TabIndex = 0;
            // 
            // FacilityGroupBox
            // 
            FacilityGroupBox.Controls.Add(StartLabel);
            FacilityGroupBox.Controls.Add(SystemLabel);
            FacilityGroupBox.Controls.Add(RatingGroupBox);
            FacilityGroupBox.Controls.Add(InfoPanel);
            FacilityGroupBox.Controls.Add(NamePanel);
            FacilityGroupBox.Controls.Add(FacilityPictureBox);
            FacilityGroupBox.Location = new Point(12, 153);
            FacilityGroupBox.Name = "FacilityGroupBox";
            FacilityGroupBox.Size = new Size(723, 560);
            FacilityGroupBox.TabIndex = 5;
            FacilityGroupBox.TabStop = false;
            FacilityGroupBox.Text = "Информация об объекте";
            // 
            // StartLabel
            // 
            StartLabel.Dock = DockStyle.Fill;
            StartLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StartLabel.Location = new Point(3, 23);
            StartLabel.Name = "StartLabel";
            StartLabel.Size = new Size(717, 534);
            StartLabel.TabIndex = 6;
            StartLabel.Text = "Выберите объект двойным нажатием на маркер либо через строку поиска";
            StartLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SystemLabel
            // 
            SystemLabel.AutoSize = true;
            SystemLabel.Location = new Point(694, 534);
            SystemLabel.Name = "SystemLabel";
            SystemLabel.Size = new Size(23, 20);
            SystemLabel.TabIndex = 5;
            SystemLabel.Text = "-1";
            // 
            // RatingGroupBox
            // 
            RatingGroupBox.Controls.Add(RatingLabel);
            RatingGroupBox.Controls.Add(DislikeBtn);
            RatingGroupBox.Controls.Add(LikeBtn);
            RatingGroupBox.Location = new Point(12, 443);
            RatingGroupBox.Name = "RatingGroupBox";
            RatingGroupBox.Size = new Size(250, 111);
            RatingGroupBox.TabIndex = 4;
            RatingGroupBox.TabStop = false;
            RatingGroupBox.Text = "Рейтинг объекта";
            // 
            // RatingLabel
            // 
            RatingLabel.Anchor = AnchorStyles.Top;
            RatingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RatingLabel.Location = new Point(6, 23);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(238, 28);
            RatingLabel.TabIndex = 2;
            RatingLabel.Text = "0 / 0";
            RatingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DislikeBtn
            // 
            DislikeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DislikeBtn.Location = new Point(131, 62);
            DislikeBtn.Name = "DislikeBtn";
            DislikeBtn.Size = new Size(40, 40);
            DislikeBtn.TabIndex = 1;
            DislikeBtn.Text = " :(";
            DislikeBtn.UseVisualStyleBackColor = true;
            DislikeBtn.Click += DislikeBtn_Click;
            // 
            // LikeBtn
            // 
            LikeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LikeBtn.Location = new Point(85, 62);
            LikeBtn.Name = "LikeBtn";
            LikeBtn.Size = new Size(40, 40);
            LikeBtn.TabIndex = 0;
            LikeBtn.Text = " :)";
            LikeBtn.UseVisualStyleBackColor = true;
            LikeBtn.Click += LikeBtn_Click;
            // 
            // InfoPanel
            // 
            InfoPanel.ColumnCount = 2;
            InfoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            InfoPanel.ColumnStyles.Add(new ColumnStyle());
            InfoPanel.Controls.Add(TypePictureBox, 0, 0);
            InfoPanel.Controls.Add(AddressPictureBox, 0, 1);
            InfoPanel.Controls.Add(WorkHoursPictureBox, 0, 2);
            InfoPanel.Controls.Add(SportTypeLabel, 1, 0);
            InfoPanel.Controls.Add(WorkHoursLabel, 1, 2);
            InfoPanel.Controls.Add(AddressLabel, 1, 1);
            InfoPanel.Location = new Point(9, 157);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.RowCount = 3;
            InfoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            InfoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            InfoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            InfoPanel.Size = new Size(346, 204);
            InfoPanel.TabIndex = 3;
            // 
            // TypePictureBox
            // 
            TypePictureBox.Image = Properties.Resources.sportType;
            TypePictureBox.Location = new Point(3, 3);
            TypePictureBox.Name = "TypePictureBox";
            TypePictureBox.Size = new Size(54, 54);
            TypePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TypePictureBox.TabIndex = 0;
            TypePictureBox.TabStop = false;
            // 
            // AddressPictureBox
            // 
            AddressPictureBox.Image = Properties.Resources.address;
            AddressPictureBox.Location = new Point(3, 70);
            AddressPictureBox.Name = "AddressPictureBox";
            AddressPictureBox.Size = new Size(54, 54);
            AddressPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            AddressPictureBox.TabIndex = 1;
            AddressPictureBox.TabStop = false;
            // 
            // WorkHoursPictureBox
            // 
            WorkHoursPictureBox.Image = Properties.Resources.workHours;
            WorkHoursPictureBox.Location = new Point(3, 137);
            WorkHoursPictureBox.Name = "WorkHoursPictureBox";
            WorkHoursPictureBox.Size = new Size(54, 54);
            WorkHoursPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            WorkHoursPictureBox.TabIndex = 2;
            WorkHoursPictureBox.TabStop = false;
            // 
            // SportTypeLabel
            // 
            SportTypeLabel.AutoSize = true;
            SportTypeLabel.Dock = DockStyle.Fill;
            SportTypeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SportTypeLabel.Location = new Point(63, 0);
            SportTypeLabel.Name = "SportTypeLabel";
            SportTypeLabel.Size = new Size(286, 67);
            SportTypeLabel.TabIndex = 3;
            SportTypeLabel.Text = "Спорт";
            // 
            // WorkHoursLabel
            // 
            WorkHoursLabel.Dock = DockStyle.Fill;
            WorkHoursLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WorkHoursLabel.Location = new Point(63, 134);
            WorkHoursLabel.Name = "WorkHoursLabel";
            WorkHoursLabel.Size = new Size(286, 70);
            WorkHoursLabel.TabIndex = 5;
            WorkHoursLabel.Text = "Часы работы";
            // 
            // AddressLabel
            // 
            AddressLabel.Dock = DockStyle.Fill;
            AddressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddressLabel.Location = new Point(63, 67);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(286, 67);
            AddressLabel.TabIndex = 6;
            AddressLabel.Text = "Адрес";
            // 
            // NamePanel
            // 
            NamePanel.ColumnCount = 1;
            NamePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            NamePanel.Controls.Add(NameLabel, 0, 0);
            NamePanel.Location = new Point(6, 26);
            NamePanel.Name = "NamePanel";
            NamePanel.RowCount = 1;
            NamePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            NamePanel.Size = new Size(346, 125);
            NamePanel.TabIndex = 2;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            NameLabel.Location = new Point(3, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(340, 125);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Название объетка";
            // 
            // FacilityPictureBox
            // 
            FacilityPictureBox.Anchor = AnchorStyles.None;
            FacilityPictureBox.BorderStyle = BorderStyle.FixedSingle;
            FacilityPictureBox.Image = Properties.Resources.loading;
            FacilityPictureBox.Location = new Point(365, 26);
            FacilityPictureBox.Name = "FacilityPictureBox";
            FacilityPictureBox.Size = new Size(352, 352);
            FacilityPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FacilityPictureBox.TabIndex = 1;
            FacilityPictureBox.TabStop = false;
            // 
            // AuthorLinkLabel
            // 
            AuthorLinkLabel.AutoSize = true;
            AuthorLinkLabel.Location = new Point(12, 721);
            AuthorLinkLabel.Name = "AuthorLinkLabel";
            AuthorLinkLabel.Size = new Size(80, 20);
            AuthorLinkLabel.TabIndex = 6;
            AuthorLinkLabel.TabStop = true;
            AuthorLinkLabel.Text = "О проекте";
            AuthorLinkLabel.LinkClicked += AuthorLinkLabel_LinkClicked;
            // 
            // MapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 753);
            Controls.Add(AuthorLinkLabel);
            Controls.Add(FacilityGroupBox);
            Controls.Add(FilterGroupBox);
            Controls.Add(FindGroupBox);
            Controls.Add(ZoomOutBtn);
            Controls.Add(ZoomInBtn);
            Controls.Add(MapCtrl);
            Name = "MapForm";
            Text = "Карта спортивных объектов";
            Load += MapForm_Load;
            Resize += MapForm_Resize;
            FindGroupBox.ResumeLayout(false);
            FindGroupBox.PerformLayout();
            FilterGroupBox.ResumeLayout(false);
            FacilityGroupBox.ResumeLayout(false);
            FacilityGroupBox.PerformLayout();
            RatingGroupBox.ResumeLayout(false);
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TypePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddressPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)WorkHoursPictureBox).EndInit();
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FacilityPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl MapCtrl;
        private Button ZoomInBtn;
        private Button ZoomOutBtn;
        private GroupBox FindGroupBox;
        private GroupBox FilterGroupBox;
        private GroupBox FacilityGroupBox;
        private TextBox FindTextBox;
        private Button FindBtn;
        private ComboBox FilterComboBox;
        private Button UpdateBtn;
        private LinkLabel AuthorLinkLabel;
        private PictureBox FacilityPictureBox;
        private TableLayoutPanel NamePanel;
        private Label NameLabel;
        private TableLayoutPanel InfoPanel;
        private PictureBox TypePictureBox;
        private PictureBox AddressPictureBox;
        private PictureBox WorkHoursPictureBox;
        private Label SportTypeLabel;
        private GroupBox RatingGroupBox;
        private Button LikeBtn;
        private Button DislikeBtn;
        private Label RatingLabel;
        private Label SystemLabel;
        private Label StartLabel;
        private Label WorkHoursLabel;
        private Label AddressLabel;
    }
}