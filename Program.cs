using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace MarioKartCombinationTesting
{
    class Program
    {
     

        static void Main(string[] args)
        {
            
            string[] featherWeight = { "Baby Luigi", "Baby Mario", "Baby Peach", "Baby Daisy", "Baby Rosalina", "Lemmy", "Dry Bones" };
            string[] lightWeight = { "Toad", "Koopa", "Shy Guy", "Toadette", "Larry", "Wendy", "Bowser Jr", "Lakitu" };
            string[] medium1Weight = { "Peach", "Daisy", "Yoshi" };
            string[] medium2Weight = { "Mario", "Luigi", "Ludwig", "Iggy" };
            string[] cruiserWeight = { "Donkey Kong", "Waluigi", "Rosalina", "Roy" };
            string[] heavyWeight = { "Metal Mario", "Gold Peach" };
            string[] largeWeight = { "Bowser", "Wario" };
            string[] kartTypes = { "Kart", "Bike", "ATV" };

            string[] statTypes = { "Speed", "Acceleration", "Traction", "Handling", "Weight", "Turbo" };

            bool characterNameCheck = false;
            //bool maxStatCheck = true;




            List<string> featherWeightUpper = featherWeight.Select(x => x.ToUpper()).ToList();
            List<string> lightWeightUpper = lightWeight.Select(x => x.ToUpper()).ToList();
            List<string> medium1WeightUpper = medium1Weight.Select(x => x.ToUpper()).ToList();
            List<string> medium2WeightUpper = medium2Weight.Select(x => x.ToUpper()).ToList();
            List<string> cruiserWeightUpper = cruiserWeight.Select(x => x.ToUpper()).ToList();
            List<string> heavyWeightUpper = heavyWeight.Select(x => x.ToUpper()).ToList();
            List<string> largeWeightUpper = largeWeight.Select(x => x.ToUpper()).ToList();
            List<string> statTypesUpper = statTypes.Select(x => x.ToUpper()).ToList();
            List<string> kartTypesUpper = kartTypes.Select(x => x.ToUpper()).ToList();

            double speed = 0.0f;
            double acceleration = 0.0f;
            double traction = 0.0f;
            double handling = 0.0f;
            double weight = 0.0f;
            double turbo = 0.0f;



           /* Console.WriteLine("Please insert a character name");
            string characterName = Console.ReadLine(); */


            

            while (!characterNameCheck)
            {
                Console.WriteLine("Please insert a character name");
                string characterName = Console.ReadLine();
                string characterMatch = characterName.ToUpper();
                if (featherWeightUpper.Contains(characterMatch))
                {
                    speed += 2.25;
                    acceleration += 3.25;
                    weight += 2.25;
                    handling += 4.75;
                    traction += 4.5;
                    turbo += 3;

                    string stats = $"Speed: {speed}\n Acceleration: {acceleration}\n Traction: {traction}\n Handling: {handling}\n Weight: {weight}\n Turbo: {turbo}\n";
                    characterNameCheck = true;

                    Console.WriteLine($"{characterName} is a feather character, thus base stats are:\n {stats}");

                }

                else if (lightWeightUpper.Contains(characterMatch))
                {
                    speed += 2.75;
                    acceleration += 3.0;
                    weight += 2.75;
                    handling += 4.25;
                    traction += 4.25;
                    turbo += 2.75;

                    string stats = $"Speed: {speed}\n Acceleration: {acceleration}\n Traction: {traction}\n Handling: {handling}\n Weight: {weight}\n Turbo: {turbo}\n";
                    characterNameCheck = true;

                    Console.WriteLine($"{characterName} is a light character, thus base stats are:\n {stats}");
                }



                else if (medium1WeightUpper.Contains(characterMatch))
                {
                    speed += 3.25;
                    acceleration += 2.75;
                    weight += 3.25;
                    handling += 3.75;
                    traction += 4.0;
                    turbo += 2.5;

                    string stats = $"Speed: {speed}\n Acceleration: {acceleration}\n Traction: {traction}\n Handling: {handling}\n Weight: {weight}\n Turbo: {turbo}\n";
                    characterNameCheck = true;

                    Console.WriteLine($"{characterName} is a medium type 1 character, thus base stats are:\n {stats}");

                }
                else if (medium2WeightUpper.Contains(characterMatch))
                {
                    speed += 3.75;
                    acceleration += 2.5;
                    weight += 3.75;
                    handling += 3.25;
                    traction += 3.75;
                    turbo += 2.25;

                    string stats = $"Speed: {speed}\n Acceleration: {acceleration}\n Traction: {traction}\n Handling: {handling}\n Weight: {weight}\n Turbo: {turbo}\n";
                    characterNameCheck = true;

                    Console.WriteLine($"{characterName} is a medium type 2 character, thus base stats are:\n {stats}");

                }
                else if (cruiserWeightUpper.Contains(characterMatch))
                {
                    speed += 4.25;
                    acceleration += 2.25;
                    weight += 4.25;
                    handling += 2.75;
                    traction += 3.5;
                    turbo += 1.75;

                    string stats = $"Speed: {speed}\n Acceleration: {acceleration}\n Traction: {traction}\n Handling: {handling}\n Weight: {weight}\n Turbo: {turbo}\n";
                    characterNameCheck = true;

                    Console.WriteLine($"{characterName} is a cruiser character, thus base stats are:\n {stats}");

                }
                else if (heavyWeightUpper.Contains(characterMatch))
                {
                    speed += 4.25;
                    acceleration += 2;
                    weight += 4.75;
                    handling += 2.75;
                    traction += 3.25;
                    turbo += 1.75;

                    string stats = $"Speed: {speed}\n Acceleration: {acceleration}\n Traction: {traction}\n Handling: {handling}\n Weight: {weight}\n Turbo: {turbo}\n";
                    characterNameCheck = true;

                    Console.WriteLine($"{characterName} is a heavy character, thus base stats are:\n {stats}");

                }
                else if (largeWeightUpper.Contains(characterMatch))
                {
                    speed += 4.75;
                    acceleration += 2;
                    weight += 4.75;
                    handling += 2.25;
                    traction += 3.25;
                    turbo += 1.75;

                    string stats = $"Speed: {speed}\n Acceleration: {acceleration}\n Traction: {traction}\n Handling: {handling}\n Weight: {weight}\n Turbo: {turbo}\n";
                    characterNameCheck = true;

                    Console.WriteLine($"{characterName} is a large character, thus base stats are:\n {stats}");

                }
                else
                {
                    Console.WriteLine("This character does not exist in Mario Kart 8 Deluxe.");


                }
            }


            if (characterNameCheck)
            {
                bool maxStatCheck = true;
                bool minStatCheck = true;
                bool kartChoiceCheck = true;
                bool preference = false;
                string maxStat = "";
                string minStat = "";
                string kartChoice = "";
                while (maxStatCheck)
                {
                    Console.WriteLine("Choose your preferred stat to maximize");
                    maxStat = Console.ReadLine();
                    string maxStatMatch = maxStat.ToUpper();
                    if (statTypesUpper.Contains(maxStatMatch))
                        maxStatCheck = false;
                }
                while (minStatCheck)
                {
                    Console.WriteLine("Choose your least desired stat to minimize");
                    minStat = Console.ReadLine();
                    string minStatMatch = minStat.ToUpper();
                    if (statTypesUpper.Contains(minStatMatch))
                        minStatCheck = false;
                }
                while(kartChoiceCheck)
                {
                    Console.WriteLine("Do you prefer a kart, bike, ATV, or no preference?");
                    kartChoice = Console.ReadLine();
                    string kartChoiceMatch = kartChoice.ToUpper();
                    if (kartTypesUpper.Contains(kartChoiceMatch))
                        kartChoiceCheck = false;
                    else if (kartChoiceMatch == "NO PREFERENCE")
                        preference = true;
                        kartChoiceCheck = false;
                }
                if (preference)
                    Console.WriteLine($"Your best vehicle is WORK IN PROGRESS maximizing {maxStat} without caring for {minStat} is WORK IN PROGRESS with final stats WORK IN PROGRESS");
                else
                    Console.WriteLine($"Your choices for a(n) {kartChoice} maximizing { maxStat} without caring for { minStat} is WORK IN PROGRESS with final stats WORK IN PROGRESS");
            }

            /*

            switch (characterName)
            {
                case smallWeight.Contains(characterName):
                    Console.WriteLine($"{characterName} is a small character, thus");
                    break;
                case mediumWeight.Constains(characterName):
                    Console.WriteLine($"{characterName} is a medium character, thus");
                    break;
                case largeWeight.Contains(characterName):
                    Console.WriteLine($"{ characterName} is a small character, thus");
                    break;
                default:
                    Console.WriteLine($"{characterName} does not exist in Mario Kart 8 Deluxe");
                    break;

            
            
            
            }
            */

            //if (mediumWeight.Contains(characterName))
            //  Console.WriteLine($"{characterName} is a medium weight");

            // string[] kartNames = { "Standard Kart", "Pipe Frame", "Mach 8", "Steel Driver" };


        }




    }






}