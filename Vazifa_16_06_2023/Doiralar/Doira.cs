using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa_16_06_2023.Doiralar
{
    public class Doira : Shakl
    {
        public Doira(double r)
        {
            R = r;

        }

        public const double PI = Math.PI;

        public double R { get; set; }

        public void Show()
        {
            Console.WriteLine($"Doira radiusi {R}");
        }

        public override double Perimetr()
        {
            return 2 * R * PI;
        }

        public override double Yuza()
        {
            return PI * R * R;
        }

    }
}
