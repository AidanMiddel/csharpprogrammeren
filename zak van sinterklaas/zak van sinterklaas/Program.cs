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

            
            
            

            
            
            


            bool bshouldRun = true;
            while (bshouldRun)
            {
                int inputNumber;
                string input = Console.ReadLine();
                if (int.TryParse(input, out inputNumber))
                {
                    switch (inputNumber)
                    {
                        case 0:
                            Console.WriteLine("Programma is zelfmoord aan het plegen");
                            bshouldRun = false;
                            break;

                        case 1:
                            Skylander FireBreaths = new FireBreath("Fire Breath ", "Spuw vuur op wat Chompies");
                            theSkylanderBucket.AddSkylander(FireBreaths);
                            Console.WriteLine($"Jij gebruikt Fire Breath op een chompy en deed 20 schade!");
                            break;

                        case 2:
                            Skylander FireDashs = new FireDash("Fire Dash ", "Ga snel weg met de Fire Dash");
                            theSkylanderBucket.AddSkylander(FireDashs);
                            Console.WriteLine("Jij gebruikt Fire Dash om te vluchten!");
                            break;

                        case 3:
                            Skylander FireTeleports = new FireTeleport("Fire Teleport", "teleporteer snel weg van chompies\n");
                            theSkylanderBucket.AddSkylander(FireTeleports);
                            Console.WriteLine("Jij gebruikt Fire Teleport om weg te teleporteren!");
                            break;

                        case 6:
                            int amountOfFireBreath = 0;
                            int amountOfFireDash = 0;
                            int amountOfFireTeleport = 0;
                            foreach (var item in theSkylanderBucket.GetSkylanders())
                            {
                                if (item is FireBreath)
                                {
                                    amountOfFireBreath++;
                                }
                                if (item is FireDash)
                                {
                                    amountOfFireDash++;
                                }
                                if (item is FireTeleport)
                                {
                                    amountOfFireTeleport++;
                                }
                            }
                            Console.WriteLine($"Gebruikte fireBrearths: {amountOfFireBreath} Gebruikte Fire Dashes: {amountOfFireDash} Gebruikte Fire teleports: {amountOfFireTeleport}");
                            //Console.WriteLine("heal value = {0}", userinput);
                            break;

                        default:
                            Console.WriteLine("wrong number");
                            bshouldRun = true;
                            break;
                    }
                }

            }




            //foreach (Skylander skylander in theSkylanderBucket.GetSkylanders())
            //{
            //Console.WriteLine(skylander.Skylandername + skylander.Skylanderdescription);
            //SkylanderAantal = theSkylanderBucket.GetSkylandersCount();
            //}

            //foreach (Skylander skylander in theSkylanderBucket.GetSkylanders())
            //{
            //Console.WriteLine($"Opties: {Index} {skylander.Skylandername}");
            //Index++;
            //}

            //while (true)
            //int deKeuze;
            //{
            //string Input = Console.ReadLine();
            //Int32.TryParse(Input, out deKeuze);
            //Console.Clear();
            //Index = 1;

            //if (!Int32.TryParse(Input, out deKeuze))
            //{
            //Console.WriteLine("invalide optie\n");
            //foreach (Skylander skylander in theSkylanderBucket.GetSkylanders())
            //{
            //Console.WriteLine($"Opties: {Index} {skylander.Skylandername}");
            //Index++;
            //}
            //}

            //if (Int32.TryParse(Input,out deKeuze) && deKeuze <= SkylanderAantal)
            //{
            //theSkylanderBucket.Use(deKeuze);
            //Console.WriteLine("\n");
            //foreach (Skylander skylander in theSkylanderBucket.GetSkylanders())
            //{
            //Console.WriteLine($"Opties: {Index} {skylander.Skylandername}");
            //Index++;
            //}
            //}

            //if (deKeuze > SkylanderAantal)
            //{
            //Console.WriteLine("invalide optie\n");
            //foreach (Skylander skylander in theSkylanderBucket.GetSkylanders())
            //{
            //Console.WriteLine($"Opties: {Index} {skylander.Skylandername}");
            //Index++;
            //}
            //}
            //}
        }
    }
}
 