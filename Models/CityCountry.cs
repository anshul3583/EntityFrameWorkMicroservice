using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class CityCountry
    {
        public int Id { get; set; }
        public string CityCode { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public int TimeOffsetPhx { get; set; }
    }
}
