using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dezakvansinterklaas
{
    internal class dezakvansinterklaas
    {
        List<cadeautje> cadeautjes;
        public dezakvansinterklaas()
        {
            cadeautjes = new List<cadeautje>();
        }

        public void AddPresent(cadeautje eenCadeau)
        {
            cadeautjes.Add(eenCadeau);
        }

        public List<cadeautje> GetPresents()
        {
            return cadeautjes;
        }
    }
}
