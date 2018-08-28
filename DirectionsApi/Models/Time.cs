using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Utility.CommonModels;

namespace DirectionsApi.Models
{
    public class Time :TextValuePair
    {
       

        [JsonProperty("time_zone ")]
        public string TimeZone { get; set; }



    }
}
