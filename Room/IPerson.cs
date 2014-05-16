using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Room
{
    public abstract class IPerson
    {
        protected object box { get; set; }
        public void Post(IPerson dest) {
            dest.box = this.box;
            this.box = null;
        }
    }
}
