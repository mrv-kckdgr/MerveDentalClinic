using System;
using System.Collections.Generic;

namespace MerveDentalDental.Models
{
    public partial class Pt00
    {
        public Pt00()
        {
            Ap00 = new HashSet<Ap00>();
            Pt01 = new HashSet<Pt01>();
            Pt02 = new HashSet<Pt02>();
        }

        public string Pid { get; set; }
        public string Pname { get; set; }
        public string Psurname { get; set; }

        public virtual ICollection<Ap00> Ap00 { get; set; }
        public virtual ICollection<Pt01> Pt01 { get; set; }
        public virtual ICollection<Pt02> Pt02 { get; set; }
    }
}
