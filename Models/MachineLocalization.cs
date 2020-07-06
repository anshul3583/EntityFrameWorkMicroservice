using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class MachineLocalization
    {
        public long Index { get; set; }
        public string MachineName { get; set; }
        public string Squad { get; set; }
        public string Branch { get; set; }
        public string Version { get; set; }
        public string Liniata { get; set; }
        public string BagTag { get; set; }
        public string Decs { get; set; }
        public string Ticket { get; set; }
    }
}
