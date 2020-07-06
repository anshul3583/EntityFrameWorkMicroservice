using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class BuildPathLocations
    {
        public long Index { get; set; }
        public string Squad { get; set; }
        public string Branch { get; set; }
        public string Version { get; set; }
        public string Path { get; set; }
    }
}
