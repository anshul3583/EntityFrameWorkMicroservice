using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class MarketInfo
    {
        public MarketInfo()
        {
            Market = new HashSet<Market>();
        }

        public int MarketId { get; set; }
        public string MarketName { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<Market> Market { get; set; }
    }
}
