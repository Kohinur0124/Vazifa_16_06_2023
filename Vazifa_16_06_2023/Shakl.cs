using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa_16_06_2023
{
    public abstract class Shakl
    {
        public abstract double Yuza();
        public abstract double Perimetr();

        public void Solve()
        {
            Console.WriteLine($"Perimetr : {Perimetr()}  Yuza : {Yuza()}");
        }

    }
}
