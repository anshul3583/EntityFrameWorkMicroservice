using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class QikLocationType
    {
        public int QikLocationTypeId { get; set; }
        public string LocationType { get; set; }
        public string Description { get; set; }
    }
}
