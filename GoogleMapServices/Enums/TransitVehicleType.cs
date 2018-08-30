using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GoogleMapServices.Enums
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransitVehicleType
    {
        RAIL,
        METRO_RAIL,
        SUBWAY,
        TRAM,
        MONORAIL,
        HEAVY_RAIL,
        COMMUTER_TRAIN,
        HIGH_SPEED_TRAIN,
        BUS,
        INTERCITY_BUS,
        TROLLEYBUS,
        SHARE_TAXI,
        FERRY,
        CABLE_CAR,
        GONDOLA_LIFT,
        FUNICULAR,
        OTHER

    }
}
