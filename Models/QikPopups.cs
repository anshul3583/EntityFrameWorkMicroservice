using System;
using System.Collections.Generic;

namespace SecondMicorService.Models
{
    public partial class QikPopups
    {
        public QikPopups()
        {
            QikPopupProperties = new HashSet<QikPopupProperties>();
        }

        public long Index { get; set; }
        public string PopupTitle { get; set; }
        public string FirstControl { get; set; }
        public int Ups { get; set; }
        public bool Slow { get; set; }
        public bool Difficult { get; set; }
        public string Version { get; set; }
        public string Program { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<QikPopupProperties> QikPopupProperties { get; set; }
    }
}
