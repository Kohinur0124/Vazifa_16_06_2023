using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa_16_06_2023
{
    public class Kvadrat : Tortburchaklar
    {
        public Kvadrat(double A) : base(A, A)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"Kvadrat  tomoni {a}");
        }

    }
}
