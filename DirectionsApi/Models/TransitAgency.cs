using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DirectionsApi.Models
{
   public class TransitAgency
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }


        [JsonProperty("url")]
        public string URL { get; set; }
    }
}
