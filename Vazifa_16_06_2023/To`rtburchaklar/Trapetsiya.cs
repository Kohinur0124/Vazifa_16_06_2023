using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa_16_06_2023
{
    public class Trapetsiya : Tortburchaklar
    {
        public Trapetsiya(double A, double B, double C, double D) : base(A, B)
        {
            c = C;
            d = D;
        }

        public double c { get; set; }
        public double d { get; set; }

        public override double Perimetr()
        {
            return a + b + c + d;
        }

        public override void Show()
        {
            Console.WriteLine($"Trapetsiya  tomonlari {a} {b} {c} {d}");
        }

        public override double Yuza()
        {
            return 0.5 * (a + b) * Math.Sqrt(c * c - Math.Pow(((a - b) * (a - b) + c * c - d * d) / (2 * (a - b)), 2));
        }

    }
}
