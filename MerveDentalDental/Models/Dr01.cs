using System;
using System.Collections.Generic;

namespace MerveDentalDental.Models
{
    public partial class Dr01
    {
        public int Cdrid { get; set; }
        public int? Cid { get; set; }
        public string Drid { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Finishdate { get; set; }

        public virtual Cl00 C { get; set; }
        public virtual Dr00 Dr { get; set; }
    }
}
