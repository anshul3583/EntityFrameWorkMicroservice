using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class CcInfo
    {
        public int CcId { get; set; }
        public string CcType { get; set; }
        public string Number { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string TestCcType { get; set; }
        public string Cid { get; set; }
        public int? Limit { get; set; }
        public string UseCase { get; set; }
    }
}
