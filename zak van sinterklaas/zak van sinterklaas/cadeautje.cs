using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dezakvansinterklaas
{
    internal class cadeautje
    {
        private string name;


        public cadeautje(string aName)
        {
            name = aName;
        }

        public string GetName()
        {
            return name;
        }
    }
}
