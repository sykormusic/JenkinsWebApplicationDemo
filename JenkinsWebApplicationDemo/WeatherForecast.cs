namespace JenkinsWebApplicationDemo
{
    public class WeatherForecast
    {
        public String? test { get; set; }
        public string? abc { get; set; }
        public string? SamTest {  get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}