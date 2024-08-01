using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherApp
{
    internal class WeatherInfo
    {
        public class Main
        {
            [JsonProperty("temp")]
            public double Temp { get; set; }

            [JsonProperty("feels_like")]
            public double FeelsLike { get; set; }

            [JsonProperty("temp_min")]
            public double TempMin { get; set; }

            [JsonProperty("temp_max")]
            public double TempMax { get; set; }

            [JsonProperty("pressure")]
            public double Pressure { get; set; }

            [JsonProperty("humidity")]
            public int Humidity { get; set; }

            [JsonProperty("sea_level")]
            public double SeaLevel { get; set; }

            [JsonProperty("grnd_level")]
            public double GrndLevel { get; set; }

            [JsonProperty("temp_kf")]
            public double TempKf { get; set; }
        }

        public class Weather
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("main")]
            public string Main { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("icon")]
            public string Icon { get; set; }
        }

        public class Clouds
        {
            [JsonProperty("all")]
            public int All { get; set; }
        }

        public class Wind
        {
            [JsonProperty("speed")]
            public double Speed { get; set; }

            [JsonProperty("deg")]
            public double Deg { get; set; }

            [JsonProperty("gust")]
            public double? Gust { get; set; }
        }

        public class Rain
        {
            [JsonProperty("1h")]
            public double? Rain1h { get; set; }

            [JsonProperty("3h")]
            public double? Rain3h { get; set; }
        }

        public class Sys
        {
            [JsonProperty("pod")]
            public string Pod { get; set; }
        }

        public class Forecast
        {
            [JsonProperty("dt")]
            public long Dt { get; set; }

            [JsonProperty("main")]
            public Main Main { get; set; }

            [JsonProperty("weather")]
            public List<Weather> Weather { get; set; }

            [JsonProperty("clouds")]
            public Clouds Clouds { get; set; }

            [JsonProperty("wind")]
            public Wind Wind { get; set; }

            [JsonProperty("visibility")]
            public int Visibility { get; set; }

            [JsonProperty("pop")]
            public double Pop { get; set; }

            [JsonProperty("rain")]
            public Rain Rain { get; set; }

            [JsonProperty("sys")]
            public Sys Sys { get; set; }

            [JsonProperty("dt_txt")]
            public string DtTxt { get; set; }
        }

        public class Root
        {
            [JsonProperty("cod")]
            public string Cod { get; set; }

            [JsonProperty("message")]
            public double Message { get; set; }

            [JsonProperty("cnt")]
            public int Cnt { get; set; }

            [JsonProperty("list")]
            public List<Forecast> List { get; set; }
        }
    }
}
