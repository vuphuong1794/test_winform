namespace WeatherApp
{
    partial class Form1
    {
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


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_close = new System.Windows.Forms.Button();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lab_tieude = new System.Windows.Forms.Label();
            this.lb01 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.icon_logo = new System.Windows.Forms.PictureBox();
            this.lb02 = new System.Windows.Forms.Label();
            this.lab_chitiet = new System.Windows.Forms.Label();
            this.lb03 = new System.Windows.Forms.Label();
            this.lb04 = new System.Windows.Forms.Label();
            this.lb05 = new System.Windows.Forms.Label();
            this.lb06 = new System.Windows.Forms.Label();
            this.lb07 = new System.Windows.Forms.Label();
            this.lab_ngay01 = new System.Windows.Forms.Label();
            this.lab_tinhtrang = new System.Windows.Forms.Label();
            this.lab_giogiat = new System.Windows.Forms.Label();
            this.lab_luongmua = new System.Windows.Forms.Label();
            this.lab_apsuat = new System.Windows.Forms.Label();
            this.lab_doam = new System.Windows.Forms.Label();
            this.lab_tdgio = new System.Windows.Forms.Label();
            this.lab_nhietdo = new System.Windows.Forms.Label();
            this.lab_thoigian = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btn_chitiet01 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(756, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(46, 30);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tbCity
            // 
            this.tbCity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tbCity.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(257, 64);
            this.tbCity.Margin = new System.Windows.Forms.Padding(2);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(320, 30);
            this.tbCity.TabIndex = 1;
            // 
            // lab_tieude
            // 
            this.lab_tieude.AutoSize = true;
            this.lab_tieude.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lab_tieude.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lab_tieude.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_tieude.Location = new System.Drawing.Point(37, 5);
            this.lab_tieude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_tieude.Name = "lab_tieude";
            this.lab_tieude.Size = new System.Drawing.Size(153, 22);
            this.lab_tieude.TabIndex = 2;
            this.lab_tieude.Text = "Dự báo thời tiết";
            // 
            // lb01
            // 
            this.lb01.AutoSize = true;
            this.lb01.BackColor = System.Drawing.Color.Transparent;
            this.lb01.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
            this.lb01.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lb01.Location = new System.Drawing.Point(76, 64);
            this.lb01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb01.Name = "lb01";
            this.lb01.Size = new System.Drawing.Size(180, 27);
            this.lb01.TabIndex = 3;
            this.lb01.Text = "Tìm thành phố:";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Gray;
            this.btn_search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.AliceBlue;
            this.btn_search.Location = new System.Drawing.Point(577, 64);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(105, 30);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pic_icon
            // 
            this.pic_icon.BackColor = System.Drawing.Color.Transparent;
            this.pic_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_icon.Location = new System.Drawing.Point(54, 119);
            this.pic_icon.Margin = new System.Windows.Forms.Padding(2);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(155, 140);
            this.pic_icon.TabIndex = 6;
            this.pic_icon.TabStop = false;
            this.pic_icon.Click += new System.EventHandler(this.pic_icon_Click);
            // 
            // header
            // 
            this.header.Controls.Add(this.icon_logo);
            this.header.Controls.Add(this.btn_close);
            this.header.Controls.Add(this.lab_tieude);
            this.header.Location = new System.Drawing.Point(0, -1);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(804, 30);
            this.header.TabIndex = 17;
            // 
            // icon_logo
            // 
            this.icon_logo.BackColor = System.Drawing.Color.Transparent;
            this.icon_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.icon_logo.Image = ((System.Drawing.Image)(resources.GetObject("icon_logo.Image")));
            this.icon_logo.InitialImage = null;
            this.icon_logo.Location = new System.Drawing.Point(0, 0);
            this.icon_logo.Name = "icon_logo";
            this.icon_logo.Size = new System.Drawing.Size(40, 30);
            this.icon_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_logo.TabIndex = 34;
            this.icon_logo.TabStop = false;
            // 
            // lb02
            // 
            this.lb02.AutoSize = true;
            this.lb02.BackColor = System.Drawing.Color.Transparent;
            this.lb02.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.lb02.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lb02.ForeColor = System.Drawing.Color.Black;
            this.lb02.Location = new System.Drawing.Point(7, 104);
            this.lb02.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb02.Name = "lb02";
            this.lb02.Size = new System.Drawing.Size(230, 32);
            this.lb02.TabIndex = 19;
            this.lb02.Text = "Thời tiết hiện tại";
            this.lb02.Click += new System.EventHandler(this.lb02_Click);
            // 
            // lab_chitiet
            // 
            this.lab_chitiet.AutoSize = true;
            this.lab_chitiet.BackColor = System.Drawing.Color.Transparent;
            this.lab_chitiet.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_chitiet.ForeColor = System.Drawing.Color.DarkBlue;
            this.lab_chitiet.Location = new System.Drawing.Point(63, 273);
            this.lab_chitiet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_chitiet.Name = "lab_chitiet";
            this.lab_chitiet.Size = new System.Drawing.Size(0, 36);
            this.lab_chitiet.TabIndex = 21;
            // 
            // lb03
            // 
            this.lb03.AutoSize = true;
            this.lb03.BackColor = System.Drawing.Color.Transparent;
            this.lb03.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb03.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb03.Location = new System.Drawing.Point(422, 153);
            this.lb03.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb03.Name = "lb03";
            this.lb03.Size = new System.Drawing.Size(139, 28);
            this.lb03.TabIndex = 22;
            this.lb03.Text = "Tốc độ gió:";
            this.lb03.Click += new System.EventHandler(this.lb03_Click);
            // 
            // lb04
            // 
            this.lb04.AutoSize = true;
            this.lb04.BackColor = System.Drawing.Color.Transparent;
            this.lb04.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb04.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb04.Location = new System.Drawing.Point(424, 183);
            this.lb04.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb04.Name = "lb04";
            this.lb04.Size = new System.Drawing.Size(92, 28);
            this.lb04.TabIndex = 23;
            this.lb04.Text = "Độ ẩm:";
            // 
            // lb05
            // 
            this.lb05.AutoSize = true;
            this.lb05.BackColor = System.Drawing.Color.Transparent;
            this.lb05.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb05.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb05.Location = new System.Drawing.Point(424, 213);
            this.lb05.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb05.Name = "lb05";
            this.lb05.Size = new System.Drawing.Size(225, 28);
            this.lb05.TabIndex = 24;
            this.lb05.Text = "Áp suất khí quyển:";
            // 
            // lb06
            // 
            this.lb06.AutoSize = true;
            this.lb06.BackColor = System.Drawing.Color.Transparent;
            this.lb06.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb06.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb06.Location = new System.Drawing.Point(424, 243);
            this.lb06.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb06.Name = "lb06";
            this.lb06.Size = new System.Drawing.Size(155, 28);
            this.lb06.TabIndex = 25;
            this.lb06.Text = "Lượng mưa:";
            // 
            // lb07
            // 
            this.lb07.AutoSize = true;
            this.lb07.BackColor = System.Drawing.Color.Transparent;
            this.lb07.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb07.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lb07.Location = new System.Drawing.Point(423, 272);
            this.lb07.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb07.Name = "lb07";
            this.lb07.Size = new System.Drawing.Size(109, 28);
            this.lb07.TabIndex = 26;
            this.lb07.Text = "Gió giật:";
            // 
            // lab_ngay01
            // 
            this.lab_ngay01.AutoSize = true;
            this.lab_ngay01.BackColor = System.Drawing.Color.Transparent;
            this.lab_ngay01.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.lab_ngay01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.lab_ngay01.Location = new System.Drawing.Point(8, 34);
            this.lab_ngay01.Name = "lab_ngay01";
            this.lab_ngay01.Size = new System.Drawing.Size(0, 28);
            this.lab_ngay01.TabIndex = 1;
            // 
            // lab_tinhtrang
            // 
            this.lab_tinhtrang.AutoSize = true;
            this.lab_tinhtrang.BackColor = System.Drawing.Color.Transparent;
            this.lab_tinhtrang.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tinhtrang.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lab_tinhtrang.Location = new System.Drawing.Point(63, 236);
            this.lab_tinhtrang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_tinhtrang.Name = "lab_tinhtrang";
            this.lab_tinhtrang.Size = new System.Drawing.Size(0, 34);
            this.lab_tinhtrang.TabIndex = 36;
            // 
            // lab_giogiat
            // 
            this.lab_giogiat.AutoSize = true;
            this.lab_giogiat.BackColor = System.Drawing.Color.Transparent;
            this.lab_giogiat.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lab_giogiat.ForeColor = System.Drawing.Color.Indigo;
            this.lab_giogiat.Location = new System.Drawing.Point(660, 274);
            this.lab_giogiat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_giogiat.Name = "lab_giogiat";
            this.lab_giogiat.Size = new System.Drawing.Size(0, 29);
            this.lab_giogiat.TabIndex = 42;
            // 
            // lab_luongmua
            // 
            this.lab_luongmua.AutoSize = true;
            this.lab_luongmua.BackColor = System.Drawing.Color.Transparent;
            this.lab_luongmua.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lab_luongmua.ForeColor = System.Drawing.Color.Indigo;
            this.lab_luongmua.Location = new System.Drawing.Point(660, 245);
            this.lab_luongmua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_luongmua.Name = "lab_luongmua";
            this.lab_luongmua.Size = new System.Drawing.Size(0, 29);
            this.lab_luongmua.TabIndex = 41;
            // 
            // lab_apsuat
            // 
            this.lab_apsuat.AutoSize = true;
            this.lab_apsuat.BackColor = System.Drawing.Color.Transparent;
            this.lab_apsuat.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lab_apsuat.ForeColor = System.Drawing.Color.Indigo;
            this.lab_apsuat.Location = new System.Drawing.Point(660, 213);
            this.lab_apsuat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_apsuat.Name = "lab_apsuat";
            this.lab_apsuat.Size = new System.Drawing.Size(0, 29);
            this.lab_apsuat.TabIndex = 40;
            // 
            // lab_doam
            // 
            this.lab_doam.AutoSize = true;
            this.lab_doam.BackColor = System.Drawing.Color.Transparent;
            this.lab_doam.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lab_doam.ForeColor = System.Drawing.Color.Indigo;
            this.lab_doam.Location = new System.Drawing.Point(660, 185);
            this.lab_doam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_doam.Name = "lab_doam";
            this.lab_doam.Size = new System.Drawing.Size(0, 29);
            this.lab_doam.TabIndex = 39;
            // 
            // lab_tdgio
            // 
            this.lab_tdgio.AutoSize = true;
            this.lab_tdgio.BackColor = System.Drawing.Color.Transparent;
            this.lab_tdgio.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lab_tdgio.ForeColor = System.Drawing.Color.Indigo;
            this.lab_tdgio.Location = new System.Drawing.Point(660, 155);
            this.lab_tdgio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_tdgio.Name = "lab_tdgio";
            this.lab_tdgio.Size = new System.Drawing.Size(0, 29);
            this.lab_tdgio.TabIndex = 38;
            // 
            // lab_nhietdo
            // 
            this.lab_nhietdo.AutoSize = true;
            this.lab_nhietdo.BackColor = System.Drawing.Color.Transparent;
            this.lab_nhietdo.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold);
            this.lab_nhietdo.ForeColor = System.Drawing.Color.Gold;
            this.lab_nhietdo.Location = new System.Drawing.Point(197, 167);
            this.lab_nhietdo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_nhietdo.Name = "lab_nhietdo";
            this.lab_nhietdo.Size = new System.Drawing.Size(0, 56);
            this.lab_nhietdo.TabIndex = 43;
            // 
            // lab_thoigian
            // 
            this.lab_thoigian.AutoSize = true;
            this.lab_thoigian.BackColor = System.Drawing.Color.Transparent;
            this.lab_thoigian.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.lab_thoigian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.lab_thoigian.Location = new System.Drawing.Point(593, 34);
            this.lab_thoigian.Name = "lab_thoigian";
            this.lab_thoigian.Size = new System.Drawing.Size(0, 28);
            this.lab_thoigian.TabIndex = 2;
            // 
            // btn_chitiet01
            // 
            this.btn_chitiet01.BackColor = System.Drawing.Color.Gray;
            this.btn_chitiet01.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_chitiet01.ForeColor = System.Drawing.Color.White;
            this.btn_chitiet01.Location = new System.Drawing.Point(283, 392);
            this.btn_chitiet01.Name = "btn_chitiet01";
            this.btn_chitiet01.Size = new System.Drawing.Size(270, 50);
            this.btn_chitiet01.TabIndex = 3;
            this.btn_chitiet01.Tag = "";
            this.btn_chitiet01.Text = "Thông tin thời tiết về 7 ngày tới";
            this.btn_chitiet01.UseVisualStyleBackColor = false;
            this.btn_chitiet01.Click += new System.EventHandler(this.btn_chitiet01_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.lab_thoigian);
            this.Controls.Add(this.btn_chitiet01);
            this.Controls.Add(this.lab_nhietdo);
            this.Controls.Add(this.lab_giogiat);
            this.Controls.Add(this.lab_luongmua);
            this.Controls.Add(this.lab_apsuat);
            this.Controls.Add(this.lab_doam);
            this.Controls.Add(this.lab_tdgio);
            this.Controls.Add(this.lab_tinhtrang);
            this.Controls.Add(this.lab_ngay01);
            this.Controls.Add(this.lb07);
            this.Controls.Add(this.lb06);
            this.Controls.Add(this.lb05);
            this.Controls.Add(this.lb04);
            this.Controls.Add(this.lb03);
            this.Controls.Add(this.lab_chitiet);
            this.Controls.Add(this.lb02);
            this.Controls.Add(this.header);
            this.Controls.Add(this.pic_icon);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lb01);
            this.Controls.Add(this.tbCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lab_tieude;
        private System.Windows.Forms.Label lb01;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lb02;
        private System.Windows.Forms.Label lab_chitiet;
        private System.Windows.Forms.Label lb03;
        private System.Windows.Forms.Label lb04;
        private System.Windows.Forms.Label lb05;
        private System.Windows.Forms.Label lb06;
        private System.Windows.Forms.Label lb07;
        private System.Windows.Forms.PictureBox icon_logo;
        private System.Windows.Forms.Label lab_ngay01;
        private System.Windows.Forms.Label lab_tinhtrang;
        private System.Windows.Forms.Label lab_giogiat;
        private System.Windows.Forms.Label lab_luongmua;
        private System.Windows.Forms.Label lab_apsuat;
        private System.Windows.Forms.Label lab_doam;
        private System.Windows.Forms.Label lab_tdgio;
        private System.Windows.Forms.Label lab_nhietdo;
        private System.Windows.Forms.Label lab_thoigian;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btn_chitiet01;
    }
}