using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dezakvansinterklaas
{
    class FireBreath : Skylander
    {
        private int damage = 20;

        public FireBreath(string name, string description) : base(name, description)
        {
        }

        public override void Useskylander()
        {
            Console.WriteLine($"Jij gebruikt {Skylandername} op een chompy en deed {damage} schade!");
        }
    }
}
