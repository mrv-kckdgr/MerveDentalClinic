using System;
using System.Collections.Generic;

namespace MerveDentalDental.Models
{
    public partial class Dr00
    {
        public Dr00()
        {
            Ap00 = new HashSet<Ap00>();
            Dr01 = new HashSet<Dr01>();
            Pt01 = new HashSet<Pt01>();
            Pt02 = new HashSet<Pt02>();
        }

        public string Drid { get; set; }
        public int? Auid { get; set; }
        public string Drname { get; set; }
        public string Drsurname { get; set; }
        public string Drbranch { get; set; }

        public virtual Au00 Au { get; set; }
        public virtual ICollection<Ap00> Ap00 { get; set; }
        public virtual ICollection<Dr01> Dr01 { get; set; }
        public virtual ICollection<Pt01> Pt01 { get; set; }
        public virtual ICollection<Pt02> Pt02 { get; set; }
    }
}
