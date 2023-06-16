using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa_16_06_2023
{
    public class Paralelogram : Tortburchaklar
    {
        public Paralelogram(double A, double B , double alpha) : base(A, B)
        {
            Alpha = alpha;
        }

        public double Alpha { get; set; }

        public override void Show()
        {
            Console.WriteLine($"Paralelogram  tomonlari {a} {b}  burchagi {Alpha}");
        }

        public override double Yuza()
        {
            return 0.5*a*b*Math.Sin(Alpha);
        }
    }
}
