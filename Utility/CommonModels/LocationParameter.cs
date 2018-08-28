using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Utility.CommonModels
{
    public class LocationParameter
    {
        protected string _data;

        private string _address;

        public string Address
        {
            get { return _address; }
            set
            {
                _data = value.Replace(" ","+");
                _address = value;
            }
        }


        private string _placeId;

        public string PlaceId
        {
            get { return _placeId; }
            set
            {
                _placeId = value;
                _data = "place_id:" + value;
            }
        }

        private LatLongPair _latLongPair;

        public LatLongPair LatLongPair
        {
            get => _latLongPair;
            set
            {
                _latLongPair = value;
                _data = value.Latitude + "," + value.Longitude;
            }
        }

      


        public override string ToString()
        {
           
            return _data;
            
        }
    }
}