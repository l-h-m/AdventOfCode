using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode19
{
    class Program
    {
        static void Main(string[] args)
        {
            var day1input = System.IO.File.ReadAllLines(@"/Users/Lewis/Documents/GitHub/AdventOfCode/Inputs/Day1Input");

            var totalMass = 0m;

            foreach (var day1Line in day1input)
            {
                totalMass = CalculateMass(totalMass, day1Line);
            }

            Console.WriteLine($"Day 1 part 1: {totalMass}");

            totalMass = 0m;

            foreach (var day1Line in day1input)
            {
                totalMass = CalculateRealMass(totalMass, day1Line);
            }

            Console.WriteLine($"Day 1 part 2: {totalMass}");

            var day2input = System.IO.File.ReadAllText(@"/Users/Lewis/Documents/GitHub/AdventOfCode/Inputs/Day1Input");
            var day2Values = day2input.Split(',')
;           
        }

        private static decimal CalculateMass(decimal totalMass, string value)
        {
            if (Decimal.TryParse(value, out var mass))
            {
                mass = Math.Floor(mass / 3);
                mass -= 2;
                totalMass += mass;
            }

            return totalMass;
        }

        private static decimal CalculateRealMass(decimal totalMass, string value)
        {
            if (Decimal.TryParse(value, out var mass))
            {
                while (mass > 0)
                {
                    mass = Math.Floor(mass / 3);
                    mass -= 2;

                    if (mass > 0)
                    {
                        totalMass += mass;
                    }
                }
            }

            return totalMass;
        }
    }
}