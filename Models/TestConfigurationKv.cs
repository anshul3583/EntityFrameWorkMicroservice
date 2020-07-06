using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class TestConfigurationKv
    {
        public int VarId { get; set; }
        public string VarKey { get; set; }
        public string VarValue { get; set; }
        public string Description { get; set; }
    }
}
