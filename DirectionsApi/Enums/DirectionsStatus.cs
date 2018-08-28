using System;
using System.Collections.Generic;
using System.Text;

namespace DirectionsApi.Enums
{
    public enum DirectionsStatus
    {
        OK,
        NOT_FOUND,
        ZERO_RESULTS,
        MAX_WAYPOINTS_EXCEEDED,
        MAX_ROUTE_LENGTH_EXCEEDED,
        INVALID_REQUEST,
        OVER_DAILY_LIMIT,
        OVER_QUERY_LIMIT,
        REQUEST_DENIED,
        UNKNOWN_ERROR


    }
}
