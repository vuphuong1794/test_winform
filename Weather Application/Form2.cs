using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppWeather;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class Form2 : Form
    {
        private WeatherInfo.Root data;
        private string cityName;
        private const string APIKey = "4359ef1cd11b4c97b0da50cce76d01e7";

        public Form2(string City)
        {
            InitializeComponent();
            this.cityName = City;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            await prepareForecastToDisplay(cityName);
            displayWeather();
        }

        public async Task prepareForecastToDisplay(string City)
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&cnt=8&appid={1}", Uri.EscapeDataString(City), APIKey);
                    var json = await web.DownloadStringTaskAsync(url);
                    data = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving weather data: {ex.Message}");
            }
        }

        public void displayWeather()
        {
            if (data != null && data.List != null && data.List.Count > 0)
            {
                var weatherList = data.List;

                // Filter the data for the next 3 hours from now
                var now = DateTime.UtcNow;
                var nextThreeIntervals = weatherList
                    .Where(w => DateTime.Parse(w.DtTxt) > now)
                    .Take(3)
                    .ToList();

                if (nextThreeIntervals.Count > 0)
                {
                    dateLabel1.Text = nextThreeIntervals[0].DtTxt;
                    temperatureLabel1.Text = nextThreeIntervals[0].Main.Temp.ToString("F1") + " °C";
                    string imgUrl1 = "http://openweathermap.org/img/w/" + nextThreeIntervals[0].Weather[0].Icon + ".png";
                    LoadImage(weatherIconBox1, imgUrl1);
                }

                if (nextThreeIntervals.Count > 1)
                {
                    dateLabel2.Text = nextThreeIntervals[1].DtTxt;
                    temperatureLabel2.Text = nextThreeIntervals[1].Main.Temp.ToString("F1") + " °C";
                    string imgUrl2 = "http://openweathermap.org/img/w/" + nextThreeIntervals[1].Weather[0].Icon + ".png";
                    LoadImage(weatherIconBox2, imgUrl2);
                    dateLabel2.Visible = true;
                    temperatureLabel2.Visible = true;
                    weatherIconBox2.Visible = true;
                    detalisBtn2.Visible = true;
                }

                if (nextThreeIntervals.Count > 2)
                {
                    dateLabel3.Text = nextThreeIntervals[2].DtTxt;
                    TemperatureLabel3.Text = nextThreeIntervals[2].Main.Temp.ToString("F1") + " °C";
                    string imgUrl3 = "http://openweathermap.org/img/w/" + nextThreeIntervals[2].Weather[0].Icon + ".png";
                    LoadImage(weatherIconBox3, imgUrl3);
                    dateLabel3.Visible = true;
                    TemperatureLabel3.Visible = true;
                    weatherIconBox3.Visible = true;
                    detalisBtn3.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Weather data is not available.");
            }
        }

        private void LoadImage(PictureBox pictureBox, string url)
        {
            using (WebClient client = new WebClient())
            {
                byte[] imageData = client.DownloadData(url);
                using (var ms = new System.IO.MemoryStream(imageData))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
        }

        private void detalisBtn1_Click(object sender, EventArgs e)
        {
            ShowDetails(0);
        }

        private void detalisBtn2_Click(object sender, EventArgs e)
        {
            ShowDetails(1);
        }

        private void detalisBtn3_Click(object sender, EventArgs e)
        {
            ShowDetails(2);
        }

        private void ShowDetails(int index)
        {
            if (data != null && data.List != null && data.List.Count > index)
            {
                var weatherDetails = data.List[index];

                Form3 form = new Form3(
                    weatherDetails.DtTxt,
                    weatherDetails.Main.TempMin.ToString("F1"),
                    weatherDetails.Main.TempMax.ToString("F1"),
                    weatherDetails.Main.Pressure.ToString(),
                    weatherDetails.Wind.Speed.ToString(),
                    weatherDetails.Main.Humidity.ToString(),
                    weatherDetails.Weather[0].Description,
                    weatherDetails.Weather[0].Icon,
                    weatherDetails.Wind.Gust?.ToString("0.00") ?? "N/A",
                    weatherDetails.Rain?.Rain3h?.ToString("0.0") ?? "N/A"
                );
                form.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void temperatureL_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }
    }
}
