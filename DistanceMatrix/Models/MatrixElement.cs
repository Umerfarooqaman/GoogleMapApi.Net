using DistanceMatrix.Enums;
using Newtonsoft.Json;
using Utility.CommonModels;

namespace DistanceMatrix.Models
{
    public class MatrixElement
    {
        [JsonProperty("status")]
        public ElementLevelStatus Status { get; set; }
        [JsonProperty("duration")]
        public Duration Duration { get; set; }
        [JsonProperty("duration_in_traffic")]
        public Duration DurationInTraffic { get; set; }
        [JsonProperty("distance")]
        public Distance Distance { get; set; }
        [JsonProperty("fare")]
        public Fare Fare { get; set; }
    }
}