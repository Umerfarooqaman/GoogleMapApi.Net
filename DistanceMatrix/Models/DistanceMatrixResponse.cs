using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using DistanceMatrix.Enums;
using Newtonsoft.Json;

namespace DistanceMatrix.Models
{
    public class DistanceMatrixResponse
    {
        [JsonProperty("origin_addresses")]
        public List<string> DestinationAddresses { get; set; }

        [JsonProperty("destination_addresses")]
        public List<string> OriginAddresses { get; set; }

        [JsonProperty("status")]
        public Matrixstatus Status { get; set; }

        [JsonProperty("rows")]
        public List<MatrixRow> Rows { get; set; }

        [JsonProperty("error_message ")]
        public string ErrorMessage { get; set; }

        public bool Successfull { get; set; } = true;

        [IgnoreDataMember]
        public  List< DistanceMatrixLookup> LookUp { get; set; }=new List<DistanceMatrixLookup>();
    }
}
