using System;

namespace dezakvansinterklaas
{


    internal class Progam
    {
        
        static void Main(string[] args)
        {
            dezakvansinterklaas deZak = new dezakvansinterklaas();

            cadeautje eenCadeau = new cadeautje("skylander");

            deZak.AddPresent(eenCadeau);

            foreach(cadeautje c in deZak.GetPresents())
            {
                Console.WriteLine(c.GetName());
            }
        }
    }
}
