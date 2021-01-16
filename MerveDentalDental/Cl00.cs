using System;
using System.Collections.Generic;

namespace MerveDentalDental
{
    public partial class Cl00
    {
        public Cl00()
        {
            Dr01 = new HashSet<Dr01>();
        }

        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Caddress { get; set; }
        public string Ctel { get; set; }

        public virtual ICollection<Dr01> Dr01 { get; set; }
    }
}
