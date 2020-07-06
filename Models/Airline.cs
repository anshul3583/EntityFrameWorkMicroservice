using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class Airline
    {
        public int AirlineId { get; set; }
        public string Name { get; set; }
        public string FriendlyName { get; set; }
        public string Code { get; set; }
    }
}
