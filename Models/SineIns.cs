using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class SineIns
    {
        public long Index { get; set; }
        public int Epr { get; set; }
        public string Passcode { get; set; }
        public string City { get; set; }
        public string Keywords { get; set; }
        public string Environment { get; set; }
    }
}
