using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class PassportSwipeData
    {
        public int Index { get; set; }
        public string DataScenario { get; set; }
        public string SwipeData { get; set; }
        public string CountryCode { get; set; }
    }
}
