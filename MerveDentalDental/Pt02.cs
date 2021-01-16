using System;
using System.Collections.Generic;

namespace MerveDentalDental
{
    public partial class Pt02
    {
        public int Tid { get; set; }
        public string Pid { get; set; }
        public string Drid { get; set; }
        public string Tname { get; set; }
        public DateTime? Tdate { get; set; }
        public string Tsession { get; set; }

        public virtual Dr00 Dr { get; set; }
        public virtual Pt00 P { get; set; }
    }
}
