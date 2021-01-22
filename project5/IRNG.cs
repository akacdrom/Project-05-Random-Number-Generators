using System;
using System.Collections.Generic;
using System.Text;

namespace Project_05_Random_Numbers_Generator
{
    interface IRNG
    {
        public long Next();
        public long Next(int maxValue);
        public long Next(int minValue, int maxValue);
        public void Visualize(int minValue, int maxValue, int n);
    }
}