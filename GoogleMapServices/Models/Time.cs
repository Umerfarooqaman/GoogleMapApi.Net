using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
 

namespace GoogleMapServices.Models
{
    public class Time :TextValuePair
    {
       

        [JsonProperty("time_zone ")]
        public string TimeZone { get; set; }



    }
}
