using System;

namespace Project_05_Random_Numbers_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ChooseLCG();
            ChooseXorshift();         
        }

        static int[] GetRange()
        {
            Console.Write("Left a space between minValue and maxValue: ");
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');
            if(inputArr.Length == 1)
            {
                return new int[1];
            }
            int[] range = new int[2] { int.Parse(inputArr[0]), int.Parse(inputArr[1]) };

            return range;
        }
       

        static void ChooseLCG()
        {
            Console.Clear();
            System.Console.WriteLine("\n -- Linear Congruential Generator -- \n");
            IRNG rng = new LCG();
            var range = GetRange();
            if (range.Length != 1)
            {
                rng.Visualize(range[0], range[1], 100000);
            }
            Console.ReadLine();
        }
       
        static void ChooseXorshift()
        {
            Console.Clear();
            System.Console.WriteLine("\n -- Xorshift Algorithm -- \n");
            IRNG rng = new Xorshift();
            var range = GetRange();
            if (range.Length != 1)
            {
                rng.Visualize(range[0], range[1], 100000);
            }
           
        }
        
    }
}