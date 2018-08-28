using DirectionsApi.Models;
using  DirectionsApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utility.CommonModels;

namespace UnitTestDirectionsApi
{
    [TestClass]
    public class DirectionApiBasicTests
    {
        
        [TestMethod]
        public void TestConnectivityWithNoKey()
        {
            var directionsResponse = new DirectionsRequest()
            {
                Key = "AIzaSyBmVNjj2wxiLjkFbbXfiuaH36kFJttvVhs",
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
                }
            }.GetDirections();
            Assert.IsTrue(directionsResponse.Successfull);
        }
    }
}
