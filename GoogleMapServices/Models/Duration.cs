using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GoogleMapServices.Models
{
    public class Duration : TextValuePair
    {
        [IgnoreDataMember]
        public virtual TimeSpan TimeSpanValue
        {
            get
            {

                try
                {
                    return TimeSpan.FromSeconds(value: Value);
                }
                catch (Exception e)
                {
                    return TimeSpan.FromSeconds(0);
                }
            }
        }

    }
}
