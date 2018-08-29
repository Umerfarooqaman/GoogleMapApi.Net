using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DistanceMatrix.Models
{
    public class MatrixRow
    {
        [JsonProperty("elements")]
        public List<MatrixElement> Elements { get; set; }

        public String OriginAddress { get; set; }
    }
}