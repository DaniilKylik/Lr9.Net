namespace Lr9.Net.Models
{
    public class WeatherData
    {
        public MainData Main { get; set; }
        public WindData Wind { get; set; }
        public string Name { get; set; }
        public List<WeatherDescription> Weather { get; set; }
    }

    public class MainData
    {
        public float Temp { get; set; }
        public int Humidity { get; set; } 
    }

    public class WindData
    {
        public float Speed { get; set; }
    }

    public class WeatherDescription
    {
        public string Description { get; set; }
    }
}
