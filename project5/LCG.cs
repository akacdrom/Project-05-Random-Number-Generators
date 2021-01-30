using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Project_05_Random_Numbers_Generator
{
    class LCG : IRNG
    {
        private const long increment = 1013904223;
        private const long multiplier = 1664525;
        private long seed;

        public LCG(long seed = 110103)
        {
            this.seed = seed;
        }
        public long Next()
        {
            seed = ((multiplier * seed) + increment) % 4294967296;
            return seed;
        }

        public long Next(int maxValue)
        {
            return Next() % maxValue;
        }
        public long Next(int minValue, int maxValue)
        {   
            return minValue + Next() % (maxValue - minValue);
        }

        public void Visualize(int minValue, int maxValue, int n)
        {
            Stopwatch sw = new Stopwatch();
            int[] counter = new int[maxValue - minValue];
            sw.Restart();
            for (int i = 0; i < n; i++)
            {
                long number = Next(minValue, maxValue);
                counter[number - minValue]++;
            }
            sw.Stop();
            int id = 0;
            int diez_counter=0;
            Console.WriteLine("Results: ");
            for (int i = minValue; i < maxValue; i++)
            {
                Console.Write($"{i}: ");
                int diez = counter[diez_counter++] * 100 / n;
                for (int k = 0; k < diez; k++)
                {
                    Console.Write("#");
                }
                Console.Write($" {counter[id++] * 100.0 / n}% -- Time: {sw.ElapsedMilliseconds} ms.");
                Console.WriteLine();
            }
         }
    }
}
