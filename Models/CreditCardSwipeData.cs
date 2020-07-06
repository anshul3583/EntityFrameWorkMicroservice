using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class CreditCardSwipeData
    {
        public int Index { get; set; }
        public string DataScenario { get; set; }
        public string CardSwipeData { get; set; }
        public string CardType { get; set; }
    }
}
