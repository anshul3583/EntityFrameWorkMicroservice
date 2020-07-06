using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class QikPopupProperties
    {
        public long IndexProp { get; set; }
        public string HumanName { get; set; }
        public string Qik16Name { get; set; }
        public string Qik32name { get; set; }
        public int MaxCharactors { get; set; }
        public long Index { get; set; }
        public int? TabIndex { get; set; }
        public int? Left { get; set; }
        public int? Top { get; set; }

        public virtual QikPopups IndexNavigation { get; set; }
    }
}
