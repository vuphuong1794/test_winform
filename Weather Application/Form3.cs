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

        public Form3(string date, string mintemp, string maxtemp, string pressure, string wind, string humidity, string message, string picture, string gust, string rain)
        {
            InitializeComponent();
            this.date = date;
            this.mintemp = mintemp;
            this.maxtemp = maxtemp;
            this.pressure = pressure;
            this.wind = wind;
            this.humidity = humidity;
            this.message = message;
            this.picture = picture;
            this.gust = gust;
            this.rain = rain;

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