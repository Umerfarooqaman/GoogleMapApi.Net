using System;
using System.Collections.Generic;
using System.Text;
using Utility.CommonModels;

namespace DirectionsApi.Models
{
   public class WayPointParameter :LocationParameter
    {
        private List<string> _polyline;

        public List<string> Polylines
        {
            get
            {

                if (Polylines is null)
                {
                    _polyline = new List<string>();
                }
                return _polyline;
            }

            private set => _polyline = value;
        }

        public new string ToString()
        {
            if (_polyline == null) return base.ToString();

            var firstSkipped = false;
            foreach (var item in Polylines)
            {
                if (firstSkipped)
                {
                    _data = _data + "|";
                }
                _data = _data + "enc:" + item + ":";
                firstSkipped = true;
            }
            return _data;

        }
    }
}
