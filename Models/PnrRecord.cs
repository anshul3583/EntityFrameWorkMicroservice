using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class PnrRecord
    {
        public int Index { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightNumber { get; set; }
        public string Paxpnr { get; set; }
        public int MultiPax { get; set; }
        public bool SameName { get; set; }
        public string Environment { get; set; }
        public bool Ticketed { get; set; }
        public bool CheckedIn { get; set; }
        public string Depart { get; set; }
        public string Arrive { get; set; }
        public string Body { get; set; }
        public string TestCase { get; set; }
    }
}
