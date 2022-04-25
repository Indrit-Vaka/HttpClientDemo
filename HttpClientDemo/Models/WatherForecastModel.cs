using System.Text.Json.Serialization;

namespace HttpClientDemo.Models
{


    public class WatherForecastModel
    {
        [JsonPropertyName("Consolidated_weather")]
        public DayForecastModel[] ConsolidatedWeather { get; set; }
        public DateTime Time { get; set; }
        [JsonPropertyName("Sun_rise")]
        public DateTime SunRise { get; set; }
        [JsonPropertyName("Sun_set")]
        public DateTime SunSet { get; set; }
        [JsonPropertyName("Timezone_name")]
        public string? TimezoneName { get; set; }

        public string? Title { get; set; }

        public string? Timezone { get; set; }
    }

}
