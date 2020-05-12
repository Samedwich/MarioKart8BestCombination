using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
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
                string maxStatMatch = "";
                string minStatMatch = "";

                string kartChoice = "";
                string kartChoiceMatch = "";

                object[] baseData = { };
                object[] tireData = { };
                object[] gliderData = { };

                while (maxStatCheck)
                {
                    Console.WriteLine("Choose your preferred stat to maximize");
                    maxStat = Console.ReadLine();
                    maxStatMatch = maxStat.ToUpper();
                    if (statTypesUpper.Contains(maxStatMatch))
                        maxStatCheck = false;
                }
                while (minStatCheck)
                {
                    Console.WriteLine("Choose your least desired stat to minimize");
                    minStat = Console.ReadLine();
                    minStatMatch = minStat.ToUpper();
                    if (statTypesUpper.Contains(minStatMatch) && minStatMatch != maxStatMatch)
                        minStatCheck = false;
                }
                while (kartChoiceCheck)
                {
                    Console.WriteLine("Choose a Kart type(Kart, Bike,ATV), or choose no preference");
                    kartChoice = Console.ReadLine();
                    kartChoiceMatch = kartChoice.ToUpper();
                    if (kartTypesUpper.Contains(kartChoiceMatch))
                    {
                        kartChoiceCheck = false;
                    }
                    else if (kartChoiceMatch == "NO PREFERENCE")
                    {
                        kartChoiceCheck = false;
                    }
                }
                    
                switch (kartChoiceMatch)
                {
                    case "KART":
                        baseData = KartStatsCalculation(maxStatMatch, minStatMatch);
                        tireData = WheelStatCalculation(maxStatMatch, minStatMatch);
                        gliderData = GliderStatCalculation(maxStatMatch, minStatMatch);
                        break;
                    case "BIKE":
                        baseData = BikeStatsCalculation(maxStatMatch, minStatMatch);
                        tireData = WheelStatCalculation(maxStatMatch, minStatMatch);
                        gliderData = GliderStatCalculation(maxStatMatch, minStatMatch);
                        break;
                    case "ATV":
                        baseData = AtvStatsCalculation(maxStatMatch, minStatMatch);
                        tireData = WheelStatCalculation(maxStatMatch, minStatMatch);
                        gliderData = GliderStatCalculation(maxStatMatch, minStatMatch);
                        break;
                    case "NO PREFERENCE":
                        baseData = NoPreferenceCalculation(maxStatMatch, minStatMatch);
                        tireData = WheelStatCalculation(maxStatMatch, minStatMatch);
                        gliderData = GliderStatCalculation(maxStatMatch, minStatMatch);
                        preference = true;
                        break;
                    default:
                        break;


                }



                speed += ((double)baseData[1]+(double)tireData[1]+(double)gliderData[1]);
                acceleration += ((double)baseData[2] + (double)tireData[2] + (double)gliderData[2]);
                traction += ((double)baseData[3] + (double)tireData[3] + (double)gliderData[3]);
                handling += ((double)baseData[4]+(double)tireData[4] + (double)gliderData[4]);
                weight += ((double)baseData[5]+ (double)tireData[5] + (double)gliderData[5]);
                turbo += ((double)baseData[6] + (double)tireData[6] + (double)gliderData[6]);
                string stats = $"Speed: {speed}\n Acceleration: {acceleration}\n Traction: {traction}\n Handling: {handling}\n Weight: {weight}\n Turbo: {turbo}\n";
                /* switch (kartChoiceMatch)
                 {
                     case "KART":

                         break;
                     case "BIKE":
                         Console.WriteLine("You choose a bike");
                         break;
                     case "ATV":
                         Console.WriteLine("You choose an ATV");
                         break;
                     default:
                         Console.WriteLine("You didn't choose");
                         break;
                 } */






                if (preference)
                    Console.WriteLine($"Your best vehicle for maximizing {maxStat} without caring for {minStat} is \n Base: {baseData[0]}\n Tires: {tireData[0]}\n Glider: {gliderData[0]}\n with final stats \n {stats}");
                else
                    Console.WriteLine($"Your best choice for a(n) {kartChoice} maximizing { maxStat} without caring for { minStat} is \n Base: {baseData[0]}\n Tires: {tireData[0]}\n Glider: {gliderData[0]}\n with final stats \n {stats}");
            }





           


        }
        static object[] KartStatsCalculation(string maxStat, string minStat)
        {
            object[,] karts = new object[,] { { "Standard Kart", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                                                { "Pipe Frame", 0.0, 0.25, -0.25, 0.5, -0.5, 0.25 },
                                                { "Mach 8", 0.5, -0.25, 0.25, 0.0, -0.5, 0.5},
                                                { "Steel Driver", 0.0, -0.5, 0.5, -0.5, 0.5, -0.75 },
                                                {"Cat Cruiser",0.0,0.0,0.0,0.0,0.0,0.0 },
                                                {"Circuit Special",0.5,-0.25,0.25,0.0,-1.0,-0.5 },
                                                {"Tri-Speeder",0.0,-0.5,0.5,-0.5,0.5,-0.75 },
                                                {"Badwagon",0.0,-0.5,0.5,-0.5,0.5,-0.75 },
                                                {"Prancer",0.0,0.0,0.0,0.0,0.0,0.0 },
                                                {"BiddyBuggy",-0.75,1.25,-0.5,0.5,-0.25,1.0 },
                                                {"Landship",-0.75,1.25,-0.5,0.5,-0.25,1.0 },
                                                {"Sports Coupe",0.5,-0.25,0.25,0.0,-1.0,-0.5  } };
            object[] fullStatsForBase = new object[7];
            int maxStatIndex = 0;
            int minStatIndex = 0;
            double maximum = 0.0;
            double minimum = 0.0;
            string[] bestCombo = { "Base", "Wheels", "Glider" };
            string nameOfMaximumBase = "";


            switch (maxStat)
            {
                case "SPEED":
                    maxStatIndex = 1;
                    break;
                case "ACCELERATION":
                    maxStatIndex = 2;
                    break;
                case "WEIGHT":
                    maxStatIndex = 3;
                    break;
                case "HANDLING":
                    maxStatIndex = 4;
                    break;
                case "TRACTION":
                    maxStatIndex = 5;
                    break;
                case "TURBO":
                    maxStatIndex = 6;
                    break;
                default:
                    break;


            }

            switch (minStat)
            {
                case "SPEED":
                    minStatIndex = 1;
                    break;
                case "ACCELERATION":
                    minStatIndex = 2;
                    break;
                case "WEIGHT":
                    minStatIndex = 3;
                    break;
                case "HANDLING":
                    minStatIndex = 4;
                    break;
                case "TRACTION":
                    minStatIndex = 5;
                    break;
                case "TURBO":
                    minStatIndex = 6;
                    break;
                default:
                    break;


            }


            int i = 0;
            while (i < karts.GetLength(0))
            {
                //Console.WriteLine($"\n{karts[i, 0]} with stat {karts[i, maxStatIndex]}");

                if (maximum <= (double)karts[i, maxStatIndex] && minimum >= (double)karts[i, minStatIndex])
                {
                    int j = 0;
                    while (j < 7)
                    {
                        fullStatsForBase[j] = karts[i, j];
                        j++;
                    }

                    minimum = (double)karts[i, minStatIndex];
                    maximum = (double)karts[i, maxStatIndex];
                    nameOfMaximumBase = (string)karts[i, 0];
                }

                i += 1;

            }
            bestCombo[0] = nameOfMaximumBase;
           




            return fullStatsForBase;

        }

        static object[] BikeStatsCalculation(string maxStat, string minStat)
        {
            object[,] bikes = new object[,] { {"Standard Bike",0.0,0.25,-0.25,0.5,-0.5,0.25 },
                                               {"Comet",0.0,0.75,-0.25,0.75,-1.25,0.5 },
                                                {"Sports Bike",0.0,0.75,-0.25,0.75,-1.25,0.5 },
                                                {"The Duke",0.0,0.0,0.0,0.0,0.0,0.0 },
                                                {"Flame Rider",0.0,0.25,-0.25,0.5,-0.5,0.25 },
                                                {"Varmint",0.0,0.25,-0.25,0.5,-0.5,0.25 },
                                                {"Mr Scooty",-0.75,1.25,-0.5,0.5,-0.25,1.0 },
                                                {"Jet Bike",0.0,0.75,-0.25,0.75,-1.25,0.5 },
                                                {"Yoshi Bike",0.0,0.75,-0.25,0.75,-1.25,0.5 }};
            object[] fullStatsForBase = new object[7];
            int maxStatIndex = 0;
            int minStatIndex = 0;
            double maximum = 0.0;
            double minimum = 0.0;
            string[] bestCombo = { "Base", "Wheels", "Glider" };
            string nameOfMaximumBase = "";


            switch (maxStat)
            {
                case "SPEED":
                    maxStatIndex = 1;
                    break;
                case "ACCELERATION":
                    maxStatIndex = 2;
                    break;
                case "WEIGHT":
                    maxStatIndex = 3;
                    break;
                case "HANDLING":
                    maxStatIndex = 4;
                    break;
                case "TRACTION":
                    maxStatIndex = 5;
                    break;
                case "TURBO":
                    maxStatIndex = 6;
                    break;
                default:
                    break;


            }

            switch (minStat)
            {
                case "SPEED":
                    minStatIndex = 1;
                    break;
                case "ACCELERATION":
                    minStatIndex = 2;
                    break;
                case "WEIGHT":
                    minStatIndex = 3;
                    break;
                case "HANDLING":
                    minStatIndex = 4;
                    break;
                case "TRACTION":
                    minStatIndex = 5;
                    break;
                case "TURBO":
                    minStatIndex = 6;
                    break;
                default:
                    break;


            }


            int i = 0;
            while (i < bikes.GetLength(0))
            {
                //Console.WriteLine($"\n{karts[i, 0]} with stat {karts[i, maxStatIndex]}");

                if (maximum <= (double)bikes[i, maxStatIndex] && minimum >= (double)bikes[i, minStatIndex])
                {
                    int j = 0;
                    while (j < 7)
                    {
                        fullStatsForBase[j] = bikes[i, j];
                        j++;
                    }

                    minimum = (double)bikes[i, minStatIndex];
                    maximum = (double)bikes[i, maxStatIndex];
                    nameOfMaximumBase = (string)bikes[i, 0];
                }

                i += 1;

            }
            bestCombo[0] = nameOfMaximumBase;
           




            return fullStatsForBase;
        }

        static object[] AtvStatsCalculation(string maxStat, string minStat)
        {
            object[,] atvs = new object[,] { {"Standard ATV", 0.0, -0.5, 0.5, -0.5, 0.5, -0.75 },
                                                {"Wild Wiggler",0.0,0.25,-0.25,0.5,-0.5,0.25  },
                                                {"Teddy Buggy",0.0,0.0,0.0,0.0,0.0,0.0 } };
            object[] fullStatsForBase = new object[7];
            int maxStatIndex = 0;
            int minStatIndex = 0;
            double maximum = 0.0;
            double minimum = 0.0;
            string[] bestCombo = { "Base", "Wheels", "Glider" };
            string nameOfMaximumBase = "";


            switch (maxStat)
            {
                case "SPEED":
                    maxStatIndex = 1;
                    break;
                case "ACCELERATION":
                    maxStatIndex = 2;
                    break;
                case "WEIGHT":
                    maxStatIndex = 3;
                    break;
                case "HANDLING":
                    maxStatIndex = 4;
                    break;
                case "TRACTION":
                    maxStatIndex = 5;
                    break;
                case "TURBO":
                    maxStatIndex = 6;
                    break;
                default:
                    break;


            }

            switch (minStat)
            {
                case "SPEED":
                    minStatIndex = 1;
                    break;
                case "ACCELERATION":
                    minStatIndex = 2;
                    break;
                case "WEIGHT":
                    minStatIndex = 3;
                    break;
                case "HANDLING":
                    minStatIndex = 4;
                    break;
                case "TRACTION":
                    minStatIndex = 5;
                    break;
                case "TURBO":
                    minStatIndex = 6;
                    break;
                default:
                    break;


            }


            int i = 0;
            while (i < atvs.GetLength(0))
            {
                //Console.WriteLine($"\n{karts[i, 0]} with stat {karts[i, maxStatIndex]}");

                if (maximum <= (double)atvs[i, maxStatIndex] && minimum >= (double)atvs[i, minStatIndex])
                {
                    int j = 0;
                    while (j < 7)
                    {
                        fullStatsForBase[j] = atvs[i, j];
                        j++;
                    }

                    minimum = (double)atvs[i, minStatIndex];
                    maximum = (double)atvs[i, maxStatIndex];
                    nameOfMaximumBase = (string)atvs[i, 0];
                }

                i += 1;

            }
            bestCombo[0] = nameOfMaximumBase;
            




            return fullStatsForBase;



        }

        static object[] NoPreferenceCalculation(string maxStat, string minStat)
        {
            object[] kartCandidate = KartStatsCalculation(maxStat, minStat);
            object[] bikeCandidate = BikeStatsCalculation(maxStat, minStat);
            object[] atvCandidate = AtvStatsCalculation(maxStat, minStat);

            int maxStatIndex = 0;
            int minStatIndex = 0;

            switch (maxStat)
            {
                case "SPEED":
                    maxStatIndex = 1;
                    break;
                case "ACCELERATION":
                    maxStatIndex = 2;
                    break;
                case "WEIGHT":
                    maxStatIndex = 3;
                    break;
                case "HANDLING":
                    maxStatIndex = 4;
                    break;
                case "TRACTION":
                    maxStatIndex = 5;
                    break;
                case "TURBO":
                    maxStatIndex = 6;
                    break;
                default:
                    break;


            }

            switch (minStat)
            {
                case "SPEED":
                    minStatIndex = 1;
                    break;
                case "ACCELERATION":
                    minStatIndex = 2;
                    break;
                case "WEIGHT":
                    minStatIndex = 3;
                    break;
                case "HANDLING":
                    minStatIndex = 4;
                    break;
                case "TRACTION":
                    minStatIndex = 5;
                    break;
                case "TURBO":
                    minStatIndex = 6;
                    break;
                default:
                    break;


            }

            if ((double)kartCandidate[maxStatIndex] > (double)bikeCandidate[maxStatIndex] && (double)kartCandidate[maxStatIndex] > (double)atvCandidate[maxStatIndex])
            {
                return kartCandidate;
            }
            else if ((double)bikeCandidate[maxStatIndex] > (double)kartCandidate[maxStatIndex] && (double)bikeCandidate[maxStatIndex] > (double)atvCandidate[maxStatIndex])
            {
                return bikeCandidate;
            }
            else
                return atvCandidate;
        }

        static object[] WheelStatCalculation(string maxStat, string minStat)
        {
            object[,] tires = new object[,] { {"Standard", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                                                {"Monster",0.0,-0.5,0.5,-0.75,0.75,0.0  },
                                                {"Roller",-0.5,1.0,-0.5,0.25,-0.25,1.5 },
                                                {"Slim",0.25,-0.25,0.0,0.25,-0.5,0.25 },
                                                {"Slick",0.5,-0.25,0.25,0.0,-1.00,0.25 },
                                                {"Metal",0.25,-0.5,0.5,0.0,-0.5,0.0 },
                                                {"Button",-0.5,1.0,-0.5,0.25,-0.25,1.5 },
                                                {"Off-Road",0.0,0.0,0.0,0.0,0.0,0.0 },
                                                {"Sponge",-0.25,0.25,-0.25,-0.25,0.5,0.75 },
                                                {"Wood",-0.25,0.25,-0.25,-0.25,0.5,0.75 },
                                                {"Cushion",-0.25,0.25,-0.25,-0.25,0.5,0.75 },
                                                {"Blue Standard", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                                                {"Retro Off-Road", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                                                {"GLA Tires", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                                                {"Hot Monster",0.0,-0.5,0.5,-0.75,0.75,0.0 },
                                                {"Azure Roller",-0.5,1.0,-0.5,0.25,-0.25,1.5 },
                                                {"Crimson Slim",0.25,-0.25,0.0,0.25,-0.5,0.25 },
                                                {"Gold Tires",0.25,-0.5,0.5,0.0,-0.5,0.0 } };
            object[] fullStatsForTires = new object[7];
            int maxStatIndex = 0;
            int minStatIndex = 0;
            double maximum = 0.0;
            double minimum = 0.0;
            string[] bestCombo = { "Base", "Wheels", "Glider" };
            string nameOfMaximumBase = "";


            switch (maxStat)
            {
                case "SPEED":
                    maxStatIndex = 1;
                    break;
                case "ACCELERATION":
                    maxStatIndex = 2;
                    break;
                case "WEIGHT":
                    maxStatIndex = 3;
                    break;
                case "HANDLING":
                    maxStatIndex = 4;
                    break;
                case "TRACTION":
                    maxStatIndex = 5;
                    break;
                case "TURBO":
                    maxStatIndex = 6;
                    break;
                default:
                    break;


            }

            switch (minStat)
            {
                case "SPEED":
                    minStatIndex = 1;
                    break;
                case "ACCELERATION":
                    minStatIndex = 2;
                    break;
                case "WEIGHT":
                    minStatIndex = 3;
                    break;
                case "HANDLING":
                    minStatIndex = 4;
                    break;
                case "TRACTION":
                    minStatIndex = 5;
                    break;
                case "TURBO":
                    minStatIndex = 6;
                    break;
                default:
                    break;


            }


            int i = 0;
            while (i < tires.GetLength(0))
            {
                //Console.WriteLine($"\n{karts[i, 0]} with stat {karts[i, maxStatIndex]}");

                if (maximum <= (double)tires[i, maxStatIndex] && minimum >= (double)tires[i, minStatIndex])
                {
                    int j = 0;
                    while (j < 7)
                    {
                        fullStatsForTires[j] = tires[i, j];
                        j++;
                    }

                    minimum = (double)tires[i, minStatIndex];
                    maximum = (double)tires[i, maxStatIndex];
                    nameOfMaximumBase = (string)tires[i, 0];
                }

                i += 1;

            }
            bestCombo[0] = nameOfMaximumBase;
            




            return fullStatsForTires;

        }

        static object[] GliderStatCalculation(string maxStat, string minStat)
        {
            object[,] gliders = new object[,] { {"Super Glider", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                                                {"Wario Wing", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                                                {"Waddle Wing", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                                                {"Plane Glider", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                                                {"Gold Glider", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                                                {"Hot Monster",0.0,-0.5,0.5,-0.75,0.75,0.0 },
                                                {"Peach Parasol",0.0,0.25,-0.25,0.0,0.0,0.25 },
                                                {"Parachute",0.0,0.25,-0.25,0.0,0.0,0.25 },
                                                {"Parafoil",0.0,0.25,-0.25,0.0,0.0,0.25 },
                                                {"Flower Glider",0.0,0.25,-0.25,0.0,0.0,0.25 },
                                                {"Bowser Kite",0.0,0.25,-0.25,0.0,0.0,0.25 },
                                                {"MKTV Parafoil",0.0,0.25,-0.25,0.0,0.0,0.25 },
                                                {"Cloud Glider",0.0,0.25,-0.25,0.0,0.0,0.25 }};
            object[] fullStatsForGliders = new object[7];
            int maxStatIndex = 0;
            int minStatIndex = 0;
            double maximum = 0.0;
            double minimum = 0.0;
            string[] bestCombo = { "Base", "Wheels", "Glider" };
            string nameOfMaximumBase = "";


            switch (maxStat)
            {
                case "SPEED":
                    maxStatIndex = 1;
                    break;
                case "ACCELERATION":
                    maxStatIndex = 2;
                    break;
                case "WEIGHT":
                    maxStatIndex = 3;
                    break;
                case "HANDLING":
                    maxStatIndex = 4;
                    break;
                case "TRACTION":
                    maxStatIndex = 5;
                    break;
                case "TURBO":
                    maxStatIndex = 6;
                    break;
                default:
                    break;


            }

            switch (minStat)
            {
                case "SPEED":
                    minStatIndex = 1;
                    break;
                case "ACCELERATION":
                    minStatIndex = 2;
                    break;
                case "WEIGHT":
                    minStatIndex = 3;
                    break;
                case "HANDLING":
                    minStatIndex = 4;
                    break;
                case "TRACTION":
                    minStatIndex = 5;
                    break;
                case "TURBO":
                    minStatIndex = 6;
                    break;
                default:
                    break;


            }


            int i = 0;
            while (i < gliders.GetLength(0))
            {
                //Console.WriteLine($"\n{karts[i, 0]} with stat {karts[i, maxStatIndex]}");

                if (maximum <= (double)gliders[i, maxStatIndex] && minimum >= (double)gliders[i, minStatIndex])
                {
                    int j = 0;
                    while (j < 7)
                    {
                        fullStatsForGliders[j] = gliders[i, j];
                        j++;
                    }

                    minimum = (double)gliders[i, minStatIndex];
                    maximum = (double)gliders[i, maxStatIndex];
                    nameOfMaximumBase = (string)gliders[i, 0];
                }

                i += 1;

            }
            bestCombo[0] = nameOfMaximumBase;
            




            return fullStatsForGliders;

        } 

    }


}