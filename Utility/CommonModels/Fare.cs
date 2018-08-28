using Newtonsoft.Json;

namespace Utility.CommonModels
{
    public class Fare :TextValuePair
    {

        [JsonProperty("currency")]
        public string Currency { get; set; }

        
    }
}
