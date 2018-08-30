using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GoogleMapServices.Models
{
   public class Stop
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public Coordinates Location { get; set; }
    }

}
