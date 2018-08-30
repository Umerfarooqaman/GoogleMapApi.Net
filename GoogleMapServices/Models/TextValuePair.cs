using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GoogleMapServices.Models
{
   public class TextValuePair
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
