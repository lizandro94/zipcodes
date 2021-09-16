using System;
using System.Collections.Generic;
using System.Text;

namespace Zipcodes.Domain.Entities
{
    public class PostalRecord
    {
        public string Department { get; set; }
        public string Municipality { get; set; }
        public string Zipcode { get; set; }
        public string Neighbourhood { get; set; }
    }
}
