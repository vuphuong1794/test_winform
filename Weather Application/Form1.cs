using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using static WeatherApp.WeatherInfo;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private Size originalSize;
        private string APIKey = "4359ef1cd11b4c97b0da50cce76d01e7";

        public Form1()
        {
            InitializeComponent();
            originalSize = this.Size; // Save the original size of the form
            HideControls();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void lb03_Click(object sender, EventArgs e)
        {
            // Xử lý khi label "Tốc độ gió" được click
            // Bạn có thể để trống nếu không cần xử lý gì
        }

        private void getWeather()
        {
            try
            {
                using (WebClient web = new WebClient())
                {
                    string cityName = Uri.EscapeDataString(tbCity.Text);
                    string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&appid={1}&units=metric", cityName, APIKey);

                    var json = web.DownloadString(url);

                    WeatherInfo.Root info = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);

                    if (info != null && info.List != null && info.List.Count > 0)
                    {
                        // Assuming we want to display the first forecast entry
                        var forecast = info.List[0];

                        string iconUrl = "https://openweathermap.org/img/w/" + forecast.Weather[0].Icon + ".png";
                        LoadAndResizeImage(iconUrl);

                        lab_ngay01.Text = DateTime.Now.ToString("dd MMMM yyyy");
                        lab_thoigian.Text = DateTime.Now.ToString("dddd HH:mm:ss");

                        // Translate and display weather information
                        lab_tinhtrang.Text = WeatherTranslator.TranslateMain(forecast.Weather[0].Main);
                        lab_chitiet.Text = WeatherTranslator.TranslateDescription(forecast.Weather[0].Description);

                        ShowControls();

                        // Display temperature in Celsius
                        double tempCelsius = forecast.Main.Temp;
                        lab_nhietdo.Text = $"{tempCelsius.ToString("0.0")} °C";

                        // Display humidity
                        lab_doam.Text = $"{forecast.Main.Humidity} %";

                        // Display pressure
                        lab_apsuat.Text = $"{forecast.Main.Pressure} hPa";

                        // Display wind gust
                        lab_giogiat.Text = $"{forecast.Wind.Gust?.ToString("0.00") ?? "N/A"} m/s";

                        // Display wind speed
                        lab_tdgio.Text = $"{forecast.Wind.Speed:0.00} m/s";

                        // Display rainfall
                        lab_luongmua.Text = $"{forecast.Rain?.Rain1h?.ToString("0.0") ?? "0.0"} mm";

                        // Adjust form size
                        this.Size = originalSize;
                    }
                    else
                    {
                        MessageBox.Show("Weather data is not available or incomplete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving weather data: " + ex.Message);
            }
        }

        private void HideControls()
        {
            lab_nhietdo.Visible = false;
            lab_luongmua.Visible = false;
            lab_tdgio.Visible = false;
            lab_doam.Visible = false;
            lab_apsuat.Visible = false;
            lab_giogiat.Visible = false;

            lb02.Visible = false;
            lab_chitiet.Visible = false;
            lb03.Visible = false;
            lb04.Visible = false;
            lb05.Visible = false;
            lb06.Visible = false;
            lb07.Visible = false;
           
            lab_tinhtrang.Visible = false;
            lab_giogiat.Visible = false;
            lab_luongmua.Visible = false;
            lab_apsuat.Visible = false;
            lab_doam.Visible = false;
            lab_tdgio.Visible = false;
            lab_nhietdo.Visible = false;
           
            btn_chitiet01.Visible = false;

            pic_icon.Visible = false;
        }

        private void ShowControls()
        {
            lab_nhietdo.Visible = true;
            lab_luongmua.Visible = true;
            lab_tdgio.Visible = true;
            lab_doam.Visible = true;
            lab_apsuat.Visible = true;
            lab_giogiat.Visible = true;

            lb02.Visible = true;
            lab_chitiet.Visible = true;
            lb03.Visible = true;
            lb04.Visible = true;
            lb05.Visible = true;
            lb06.Visible = true;
            lb07.Visible = true;
           
            lab_tinhtrang.Visible = true;
            lab_giogiat.Visible = true;
            lab_luongmua.Visible = true;
            lab_apsuat.Visible = true;
            lab_doam.Visible = true;
            lab_tdgio.Visible = true;
            lab_nhietdo.Visible = true;
       
            btn_chitiet01.Visible = true;
            

            pic_icon.Visible = true;
        }

        private void LoadAndResizeImage(string url)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData(url);
                    using (MemoryStream stream = new MemoryStream(imageBytes))
                    {
                        using (Image originalImage = Image.FromStream(stream))
                        {
                            // Resize the image to fit the PictureBox
                            pic_icon.Image = ResizeImage(originalImage, pic_icon.Width, pic_icon.Height);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }
        public static class WeatherTranslator
        {
            private static readonly Dictionary<string, string> WeatherMainDescriptions = new Dictionary<string, string>
            {
                { "Thunderstorm", "Dông bão" },
                { "Drizzle", "Mưa phùn" },
                { "Rain", "Mưa" },
                { "Snow", "Tuyết" },
                { "Mist", "Sương mù" },
                { "Smoke", "Khói" },
                { "Haze", "Sương mù" },
                { "Dust", "Bụi" },
                { "Fog", "Sương mù" },
                { "Sand", "Cát" },
                { "Ash", "Tro" },
                { "Squall", "Gió mạnh" },
                { "Tornado", "Lốc xoáy" },
                { "Clear", "Trời quang" },
                { "Clouds", "Mây" }
            };

            private static readonly Dictionary<string, string> WeatherDetailDescriptions = new Dictionary<string, string>
            {
                { "light rain", "Mưa nhẹ" },
                { "moderate rain", "Mưa vừa" },
                { "heavy intensity rain", "Mưa lớn" },
                { "very heavy rain", "Mưa rất lớn" },
                { "extreme rain", "Mưa cực lớn" },
                { "freezing rain", "Mưa đá" },
                { "light intensity shower rain", "Mưa rào nhẹ" },
                { "shower rain", "Mưa rào" },
                { "heavy intensity shower rain", "Mưa rào lớn" },
                { "ragged shower rain", "Mưa rào không đều" },
                { "light snow", "Tuyết nhẹ" },
                { "snow", "Tuyết" },
                { "heavy snow", "Tuyết lớn" },
                { "sleet", "Mưa tuyết" },
                { "light shower sleet", "Mưa tuyết nhẹ" },
                { "shower sleet", "Mưa tuyết" },
                { "light rain and snow", "Mưa và tuyết nhẹ" },
                { "rain and snow", "Mưa và tuyết" },
                { "light shower snow", "Tuyết rơi nhẹ" },
                { "shower snow", "Tuyết rơi" },
                { "heavy shower snow", "Tuyết rơi lớn" },
                { "mist", "Sương mù" },
                { "smoke", "Khói" },
                { "haze", "Sương mù" },
                { "sand/dust whirls", "Bụi cát" },
                { "fog", "Sương mù" },
                { "sand", "Cát" },
                { "dust", "Bụi" },
                { "volcanic ash", "Tro núi lửa" },
                { "squalls", "Gió mạnh" },
                { "tornado", "Lốc xoáy" },
                { "clear sky", "Bầu trời quang đãng" },
                { "few clouds", "Ít mây" },
                { "scattered clouds", "Mây rải rác" },
                { "broken clouds", "Mây đứt đoạn" },
                { "overcast clouds", "Mây bao phủ" }
            };

            public static string TranslateMain(string main)
            {
                if (WeatherMainDescriptions.TryGetValue(main, out string description))
                {
                    return description;
                }
                return "Không xác định";
            }

            public static string TranslateDescription(string description)
            {
                if (WeatherDetailDescriptions.TryGetValue(description, out string translatedDescription))
                {
                    return translatedDescription;
                }
                return "Không xác định";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideControls();
            this.Size = new Size(791, 140); // Set initial small size
        }

        private void tbCity_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add logic to handle text changes in the city name textbox
        }

        private void btn_chitiet01_Click(object sender, EventArgs e)
        {
            string city = tbCity.Text;
            Form2 form2 = new Form2(city);
            form2.Show();
        }

        private void pic_icon_Click(object sender, EventArgs e)
        {
            // Optional: Add logic for icon click event if needed
        }

        private void lb02_Click(object sender, EventArgs e)
        {

        }
    }
}