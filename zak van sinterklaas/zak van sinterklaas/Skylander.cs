using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dezakvansinterklaas
{
    internal abstract class Skylander
    {
        public string Skylandername { get; private set; }

        public string Skylanderdescription { get; private set; }


        public Skylander(string name, string description)
        {
            this.Skylandername = name;
            this.Skylanderdescription = description; 
        }

        public abstract void Useskylander();

        //public string GetName()
        //{
        //    return name;
        //}
    }
}
