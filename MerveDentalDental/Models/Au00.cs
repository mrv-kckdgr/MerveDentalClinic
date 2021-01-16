using System;
using System.Collections.Generic;

namespace MerveDentalDental.Models
{
    public partial class Au00
    {
        public Au00()
        {
            Dr00 = new HashSet<Dr00>();
        }

        public int Auid { get; set; }
        public string Auname { get; set; }

        public virtual ICollection<Dr00> Dr00 { get; set; }
    }
}
