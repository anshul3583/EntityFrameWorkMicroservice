using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class Embargos
    {
        public long Index { get; set; }
        public string Airport { get; set; }
        public int Bags { get; set; }
        public bool Oversize { get; set; }
        public bool OverWeight { get; set; }
        public bool Boxs { get; set; }
    }
}
