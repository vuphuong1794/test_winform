namespace AppWeather
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.WindSpeedL = new System.Windows.Forms.Label();
            this.pressureL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.lab_tieude = new System.Windows.Forms.Label();
            this.icon_logo = new System.Windows.Forms.PictureBox();
            this.minTemperatureLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.maxTempLabel = new System.Windows.Forms.Label();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.maxnhiet = new System.Windows.Forms.Label();
            this.luongmua = new System.Windows.Forms.Label();
            this.doam = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.khiquyen = new System.Windows.Forms.Label();
            this.windGust = new System.Windows.Forms.Label();
            this.minnhiet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // WindSpeedL
            // 
            this.WindSpeedL.AutoSize = true;
            this.WindSpeedL.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeedL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.WindSpeedL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WindSpeedL.Location = new System.Drawing.Point(604, 211);
            this.WindSpeedL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindSpeedL.Name = "WindSpeedL";
            this.WindSpeedL.Size = new System.Drawing.Size(135, 29);
            this.WindSpeedL.TabIndex = 11;
            this.WindSpeedL.Text = "Tốc độ gió:";
            // 
            // pressureL
            // 
            this.pressureL.AutoSize = true;
            this.pressureL.BackColor = System.Drawing.Color.Transparent;
            this.pressureL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.pressureL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pressureL.Location = new System.Drawing.Point(47, 140);
            this.pressureL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pressureL.Name = "pressureL";
            this.pressureL.Size = new System.Drawing.Size(206, 29);
            this.pressureL.TabIndex = 10;
            this.pressureL.Text = "Áp suất khí quyển:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(47, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nhiệt độ cao nhất:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(47, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Độ ẩm:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(604, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 63;
            this.label1.Text = "Nhiệt độ thấp nhất:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(47, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 64;
            this.label4.Text = "Lượng mưa:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(604, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 29);
            this.label7.TabIndex = 68;
            this.label7.Text = "Gió giật:";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(965, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(61, 37);
            this.btn_close.TabIndex = 69;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lab_tieude
            // 
            this.lab_tieude.AutoSize = true;
            this.lab_tieude.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lab_tieude.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lab_tieude.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_tieude.Location = new System.Drawing.Point(52, 0);
            this.lab_tieude.Name = "lab_tieude";
            this.lab_tieude.Size = new System.Drawing.Size(194, 29);
            this.lab_tieude.TabIndex = 2;
            this.lab_tieude.Text = "Dự báo thời tiết";
            // 
            // icon_logo
            // 
            this.icon_logo.BackColor = System.Drawing.Color.Transparent;
            this.icon_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.icon_logo.Image = ((System.Drawing.Image)(resources.GetObject("icon_logo.Image")));
            this.icon_logo.InitialImage = null;
            this.icon_logo.Location = new System.Drawing.Point(4, 0);
            this.icon_logo.Margin = new System.Windows.Forms.Padding(4);
            this.icon_logo.Name = "icon_logo";
            this.icon_logo.Size = new System.Drawing.Size(41, 27);
            this.icon_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_logo.TabIndex = 70;
            this.icon_logo.TabStop = false;
            // 
            // minTemperatureLabel
            // 
            this.minTemperatureLabel.AutoSize = true;
            this.minTemperatureLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTemperatureLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.minTemperatureLabel.Location = new System.Drawing.Point(500, 82);
            this.minTemperatureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minTemperatureLabel.Name = "minTemperatureLabel";
            this.minTemperatureLabel.Size = new System.Drawing.Size(0, 32);
            this.minTemperatureLabel.TabIndex = 12;
            this.minTemperatureLabel.Click += new System.EventHandler(this.minTemperatureLabel_Click);
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pressureLabel.Location = new System.Drawing.Point(487, 111);
            this.pressureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(0, 32);
            this.pressureLabel.TabIndex = 13;
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WindSpeedLabel.Location = new System.Drawing.Point(487, 153);
            this.WindSpeedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(0, 32);
            this.WindSpeedLabel.TabIndex = 14;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.descriptionLabel.Location = new System.Drawing.Point(616, 357);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(90, 29);
            this.descriptionLabel.TabIndex = 15;
            this.descriptionLabel.Text = "thời tiết";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.humidityLabel.Location = new System.Drawing.Point(487, 193);
            this.humidityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(0, 32);
            this.humidityLabel.TabIndex = 19;
            // 
            // maxTempLabel
            // 
            this.maxTempLabel.AutoSize = true;
            this.maxTempLabel.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTempLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.maxTempLabel.Location = new System.Drawing.Point(533, 75);
            this.maxTempLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxTempLabel.Name = "maxTempLabel";
            this.maxTempLabel.Size = new System.Drawing.Size(0, 32);
            this.maxTempLabel.TabIndex = 17;
            // 
            // pic_icon
            // 
            this.pic_icon.BackColor = System.Drawing.Color.Transparent;
            this.pic_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_icon.Location = new System.Drawing.Point(422, 344);
            this.pic_icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(89, 78);
            this.pic_icon.TabIndex = 72;
            this.pic_icon.TabStop = false;
            this.pic_icon.Click += new System.EventHandler(this.pic_icon_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dateLabel.Location = new System.Drawing.Point(37, 48);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(110, 29);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Ngày/giờ";
            // 
            // maxnhiet
            // 
            this.maxnhiet.AutoSize = true;
            this.maxnhiet.BackColor = System.Drawing.Color.Transparent;
            this.maxnhiet.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.maxnhiet.ForeColor = System.Drawing.Color.SlateBlue;
            this.maxnhiet.Location = new System.Drawing.Point(261, 302);
            this.maxnhiet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxnhiet.Name = "maxnhiet";
            this.maxnhiet.Size = new System.Drawing.Size(92, 32);
            this.maxnhiet.TabIndex = 73;
            this.maxnhiet.Text = "label5";
            // 
            // luongmua
            // 
            this.luongmua.AutoSize = true;
            this.luongmua.BackColor = System.Drawing.Color.Transparent;
            this.luongmua.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.luongmua.ForeColor = System.Drawing.Color.SlateBlue;
            this.luongmua.Location = new System.Drawing.Point(190, 245);
            this.luongmua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.luongmua.Name = "luongmua";
            this.luongmua.Size = new System.Drawing.Size(92, 32);
            this.luongmua.TabIndex = 74;
            this.luongmua.Text = "label5";
            // 
            // doam
            // 
            this.doam.AutoSize = true;
            this.doam.BackColor = System.Drawing.Color.Transparent;
            this.doam.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.doam.ForeColor = System.Drawing.Color.SlateBlue;
            this.doam.Location = new System.Drawing.Point(144, 193);
            this.doam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doam.Name = "doam";
            this.doam.Size = new System.Drawing.Size(92, 32);
            this.doam.TabIndex = 75;
            this.doam.Text = "label5";
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.BackColor = System.Drawing.Color.Transparent;
            this.windSpeed.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.windSpeed.ForeColor = System.Drawing.Color.SlateBlue;
            this.windSpeed.Location = new System.Drawing.Point(747, 208);
            this.windSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(92, 32);
            this.windSpeed.TabIndex = 76;
            this.windSpeed.Text = "label5";
            // 
            // khiquyen
            // 
            this.khiquyen.AutoSize = true;
            this.khiquyen.BackColor = System.Drawing.Color.Transparent;
            this.khiquyen.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.khiquyen.ForeColor = System.Drawing.Color.SlateBlue;
            this.khiquyen.Location = new System.Drawing.Point(261, 137);
            this.khiquyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.khiquyen.Name = "khiquyen";
            this.khiquyen.Size = new System.Drawing.Size(92, 32);
            this.khiquyen.TabIndex = 77;
            this.khiquyen.Text = "label5";
            // 
            // windGust
            // 
            this.windGust.AutoSize = true;
            this.windGust.BackColor = System.Drawing.Color.Transparent;
            this.windGust.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.windGust.ForeColor = System.Drawing.Color.SlateBlue;
            this.windGust.Location = new System.Drawing.Point(714, 137);
            this.windGust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windGust.Name = "windGust";
            this.windGust.Size = new System.Drawing.Size(92, 32);
            this.windGust.TabIndex = 78;
            this.windGust.Text = "label5";
            // 
            // minnhiet
            // 
            this.minnhiet.AutoSize = true;
            this.minnhiet.BackColor = System.Drawing.Color.Transparent;
            this.minnhiet.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.minnhiet.ForeColor = System.Drawing.Color.SlateBlue;
            this.minnhiet.Location = new System.Drawing.Point(825, 261);
            this.minnhiet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minnhiet.Name = "minnhiet";
            this.minnhiet.Size = new System.Drawing.Size(92, 32);
            this.minnhiet.TabIndex = 81;
            this.minnhiet.Text = "label5";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1027, 514);
            this.Controls.Add(this.minnhiet);
            this.Controls.Add(this.windGust);
            this.Controls.Add(this.khiquyen);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.doam);
            this.Controls.Add(this.luongmua);
            this.Controls.Add(this.maxnhiet);
            this.Controls.Add(this.pic_icon);
            this.Controls.Add(this.icon_logo);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lab_tieude);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxTempLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.WindSpeedLabel);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.minTemperatureLabel);
            this.Controls.Add(this.WindSpeedL);
            this.Controls.Add(this.pressureL);
            this.Controls.Add(this.dateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WindSpeedL;
        private System.Windows.Forms.Label pressureL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lab_tieude;
        private System.Windows.Forms.PictureBox icon_logo;
        private System.Windows.Forms.Label minTemperatureLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label maxTempLabel;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label maxnhiet;
        private System.Windows.Forms.Label luongmua;
        private System.Windows.Forms.Label doam;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.Label khiquyen;
        private System.Windows.Forms.Label windGust;
        private System.Windows.Forms.Label minnhiet;
    }
}