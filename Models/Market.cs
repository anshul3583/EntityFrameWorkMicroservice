using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class Market
    {
        public int PairId { get; set; }
        public int MarketId { get; set; }
        public string ArrivalCountry { get; set; }
        public string DepartureCountry { get; set; }

        public virtual MarketInfo MarketNavigation { get; set; }
    }
}
