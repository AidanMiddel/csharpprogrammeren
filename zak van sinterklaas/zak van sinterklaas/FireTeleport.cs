using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dezakvansinterklaas
{
    class FireTeleport : Skylander
    {
        public FireTeleport(string name, string description) : base(name, description)
        {

        }

        public override void Useskylander()
        {
            Console.WriteLine($"Jij gebruikt {Skylandername} om weg te teleporteren!");
        }
    }
}
