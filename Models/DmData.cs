using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class DmData
    {
        public int DmDataId { get; set; }
        public int DmtierId { get; set; }
        public string DmNumber { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string AirlineCode { get; set; }
        public string Environment { get; set; }
        public int? Upgrade500Miles { get; set; }
        public bool Companion { get; set; }
        public int? PrizeMiles { get; set; }
        public string Address { get; set; }
        public int? MilesToExpire { get; set; }
        public string FullTier { get; set; }
    }
}
