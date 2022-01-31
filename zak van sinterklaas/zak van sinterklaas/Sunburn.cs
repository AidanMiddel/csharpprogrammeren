using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dezakvansinterklaas
{
    public abstract class Sunburn
    {
        public string SunburnName { get; private set; }

        public string SunburnDescription { get; private set; }

        public Sunburn(string sunburnName, string sunburnDescription)
        {
            this.SunburnName = sunburnName;
            this.SunburnDescription = sunburnDescription;
        }

        public abstract void Useskylander();
    }
}
