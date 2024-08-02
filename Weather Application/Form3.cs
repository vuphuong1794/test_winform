using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp;

namespace AppWeather
{
    public partial class Form3 : Form
    {
        string date, mintemp, maxtemp, pressure, wind, humidity, message, picture, gust, rain;
        //long sunrise, sunset;

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pic_icon_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void temperatureL_Click(object sender, EventArgs e)
        {

        }

        private void minTemperatureLabel_Click(object sender, EventArgs e)
        {

        }

        // Hàm khởi tạo cho Form3 với các tham số bao gồm ngày, nhiệt độ thấp nhất, nhiệt độ cao nhất,
        // áp suất, gió, độ ẩm, thông điệp, hình ảnh, gió giật và mưa
        public Form3(string date, string mintemp, string maxtemp, string pressure, string wind, string humidity, string message, string picture, string gust, string rain)
        {
            // Gọi hàm khởi tạo của form
            InitializeComponent();

            // Gán giá trị của các tham số truyền vào cho các biến tương ứng trong lớp
            this.date = date;         // Ngày
            this.mintemp = mintemp;   // Nhiệt độ thấp nhất
            this.maxtemp = maxtemp;   // Nhiệt độ cao nhất
            this.pressure = pressure; // Áp suất
            this.wind = wind;         // Gió
            this.humidity = humidity; // Độ ẩm
            this.message = message;   // Thông điệp
            this.picture = picture;   // Hình ảnh
            this.gust = gust;         // Gió giật
            this.rain = rain;         // Mưa
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            dateLabel.Text = date;
            minnhiet.Text = mintemp + " °C";
            maxnhiet.Text = maxtemp + " °C";
            khiquyen.Text = pressure + " hPa";
            windSpeed.Text = wind + " m/s";
            doam.Text = humidity + " %";
            descriptionLabel.Text = message.ToUpper();
            string img = "http://openweathermap.org/img/w/" + picture + ".png";
            pic_icon.Load(img);
            windGust.Text = gust + " m/s";
            luongmua.Text = rain + " mm";
        }
    }
}