using System;
using System.Collections.Generic;

namespace MerveDentalDental.Models
{
    public partial class Ap00
    {
        public int Aid { get; set; }
        public string Pid { get; set; }
        public string Drid { get; set; }
        public DateTime? Date { get; set; }

        public virtual Dr00 Dr { get; set; }
        public virtual Pt00 P { get; set; }
    }
}
