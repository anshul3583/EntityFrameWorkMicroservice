using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class FlightLibrary
    {
        public int Index { get; set; }
        public int FlightNo { get; set; }
        public string OriginAirportCode { get; set; }
        public string DestinationAirportCode { get; set; }
        public TimeSpan DepartTime { get; set; }
        public TimeSpan DepartTimePhx { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public TimeSpan ArrivalTimePhx { get; set; }
        public string Classes { get; set; }
        public string AirlineCode { get; set; }
        public int MarketId { get; set; }
        public string OriginCountry { get; set; }
        public string DestinationCountry { get; set; }
        public int FlightLegCount { get; set; }
        public string Aircraft { get; set; }
        public DateTime? UpdateDate { get; set; }
        public double? Miles { get; set; }
    }
}
