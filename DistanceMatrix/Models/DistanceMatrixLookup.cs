using System;
using System.Collections.Generic;
using System.Text;
using Utility.CommonModels;

namespace DistanceMatrix.Models
{
    public class DistanceMatrixLookup
    {

        public DistanceMatrixLookup(LocationParameter originParametre, LocationParameter destinationProperty, string originAddress, string destinationAddress, MatrixElement element)
        {
            OriginParametre = originParametre;
            DestinationProperty = destinationProperty;
            OrigineAddress = originAddress;
            DestinationAddress = destinationAddress;
            Element = element;
        }

        public LocationParameter OriginParametre { get;private set; }

        public LocationParameter DestinationProperty { get; private set; }
        public string OrigineAddress { get;private set; } 
        
        public string DestinationAddress { get;private set; }

        public MatrixElement Element { get;private set;}

    }
}
