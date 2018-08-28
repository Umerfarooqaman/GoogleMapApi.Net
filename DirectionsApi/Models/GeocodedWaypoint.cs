﻿using System;
using System.Collections.Generic;
using System.Text;
using DirectionsApi.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DirectionsApi.Models
{

    public class GeocodedWaypoint
    {

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("geocoder_status")]
        public GeoCoderStatus Status { get; set; }

        [JsonProperty("place_id")]
        public string PlaceId { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("types")]
        public IList<AddressTypes> Types { get; set; }

        [JsonProperty("partial_match")]
        public bool PartialMatch { get; set; }
    }

}