using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dezakvansinterklaas
{
    internal class TheSkylanderBucket
    {
        public List<Skylander> _skylander { get; private set; }
        public TheSkylanderBucket()
        {
            _skylander = new List<Skylander>();
        }

        public void AddSkylander(Skylander eenSkylander)
        {
            _skylander.Add(eenSkylander);
        }

        public List<Skylander> GetSkylanders()
        {
            return _skylander;
        }

        public int GetSkylandersCount()
        {
            return _skylander.Count;
        }
        public void Use(int Index)
        {
            _skylander[Index - 1].Useskylander();
        }
    }
}
