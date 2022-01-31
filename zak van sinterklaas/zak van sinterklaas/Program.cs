using System;

namespace dezakvansinterklaas
{


    internal class Progam
    {
        
        static void Main(string[] args)
        {
            int Index = 1;
            int SkylanderAantal = 0;
            TheSkylanderBucket theSkylanderBucket = new TheSkylanderBucket();

            Skylander FireBreaths = new FireBreath("Fire Breath ", "Spuw vuur op wat Chompies");
            Skylander FireDashs = new FireDash("Fire Dash ", "Ga snel weg met de Fire Dash");
            Skylander FireTeleports = new FireTeleport("Fire Teleport", "teleporteer snel weg van chompies\n");

            theSkylanderBucket.AddSkylander(FireBreaths);
            theSkylanderBucket.AddSkylander(FireDashs);
            theSkylanderBucket.AddSkylander(FireTeleports);


            foreach (Skylander skylander in theSkylanderBucket.GetSkylanders())
            {
                Console.WriteLine(skylander.Skylandername + skylander.Skylanderdescription);
                SkylanderAantal = theSkylanderBucket.GetSkylandersCount();
            }

            foreach (Skylander skylander in theSkylanderBucket.GetSkylanders())
            {
                Console.WriteLine($"Opties: {Index} {skylander.Skylandername}");
                Index++;
            }

            while (true)
            {
                int deKeuze;
                string Input = Console.ReadLine();
                Int32.TryParse(Input, out deKeuze);
                Console.Clear();
                Index = 1;

                if (!Int32.TryParse(Input, out deKeuze))
                {
                    Console.WriteLine("invalide optie\n");
                    foreach (Skylander skylander in theSkylanderBucket.GetSkylanders())
                    {
                        Console.WriteLine($"Opties: {Index} {skylander.Skylandername}");
                        Index++;
                    }
                }

                if (Int32.TryParse(Input,out deKeuze) && deKeuze <= SkylanderAantal)
                {
                    theSkylanderBucket.Use(deKeuze);
                    Console.WriteLine("\n");
                    foreach (Skylander skylander in theSkylanderBucket.GetSkylanders())
                    {
                        Console.WriteLine($"Opties: {Index} {skylander.Skylandername}");
                        Index++;
                    }
                }

                if (deKeuze > SkylanderAantal)
                {
                    Console.WriteLine("invalide optie\n");
                    foreach (Skylander skylander in theSkylanderBucket.GetSkylanders())
                    {
                        Console.WriteLine($"Opties: {Index} {skylander.Skylandername}");
                        Index++;
                    }
                }
            }
        }
    }
}
 