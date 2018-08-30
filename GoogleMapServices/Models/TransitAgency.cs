using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GoogleMapServices.Models
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
