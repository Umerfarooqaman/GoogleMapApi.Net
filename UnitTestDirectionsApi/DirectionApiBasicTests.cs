
using System;
using GoogleMapServices;
using GoogleMapServices.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestDirectionsApi
{
    [TestClass]
    public class DirectionApiBasicTests
    {
        [TestMethod]
        public void TestConnectivityWithNoKey()
        {
            DirectionsResponse directionsResponse = new DirectionsRequest()
            {
                Key = Environment.GetEnvironmentVariable("GOOGLE_MAP_KEY"),
                Origin = new LocationParameter()
                {
                    LatLongPair = new LatLongPair()
                    {
                        Latitude = 40.6700,
                        Longitude = -73.9400
                    }
                },
                Destination = new LocationParameter()
                {
                    LatLongPair = new LatLongPair()
                    {
                        Latitude = 40.6860,
                        Longitude = -73.9450
                    }
                },_DepartureTime = DateTime.Now+TimeSpan.FromDays(10)
            }.GetDirections();
            Assert.IsTrue(directionsResponse.Successfull);
        }

        [TestMethod]
        public void TestConnectivity2()
        {
            DirectionsResponse directionsResponse = new DirectionsRequest()
            {
                Key = Environment.GetEnvironmentVariable("GOOGLE_MAP_KEY"),
                Origin = new LocationParameter()
                { LatLongPair = new LatLongPair() { Latitude = 47.28154, Longitude = -122.56069 } },
                Destination = new LocationParameter()
                { LatLongPair = new LatLongPair() { Latitude = 47.27798, Longitude = -122.56082 } },
                _ArrivalTime = DateTime.Now+TimeSpan.FromDays(2)
            }.GetDirections();
            Assert.IsTrue(directionsResponse.Successfull);
        }

    }
}
