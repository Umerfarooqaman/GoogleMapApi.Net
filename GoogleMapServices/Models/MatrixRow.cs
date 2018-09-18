using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoogleMapServices.Models
{
    public class MatrixRow
    {
        [JsonProperty("elements")]
        public List<MatrixElement> Elements { get; set; }

        public string OriginAddress { get; set; }
    }
}