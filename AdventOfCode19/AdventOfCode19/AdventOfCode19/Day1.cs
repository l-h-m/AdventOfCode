using System;
namespace AdventOfCode19
{
    public class Day1
    {
        static void Main(string[] args)
        {
            var input = System.IO.File.ReadAllLines(@"/Users/Lewis/Documents/GitHub/AdventOfCode/Inputs/Day1Input");

            var totalMass = 0m;

            foreach (var line in input)
            {
                totalMass = CalculateMass(totalMass, line);
            }

            Console.WriteLine(totalMass);
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
    }
}
