using Newtonsoft.Json;

namespace GoogleMapServices.Models
{
    public class Fare :TextValuePair
    {

        [JsonProperty("currency")]
        public string Currency { get; set; }

        
    }
}
