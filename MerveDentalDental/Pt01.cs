using System;
using System.Collections.Generic;

namespace MerveDentalDental
{
    public partial class Pt01
    {
        public int Eid { get; set; }
        public string Pid { get; set; }
        public string Drid { get; set; }
        public DateTime? Edate { get; set; }
        public string Decision { get; set; }

        public virtual Dr00 Dr { get; set; }
        public virtual Pt00 P { get; set; }
    }
}
