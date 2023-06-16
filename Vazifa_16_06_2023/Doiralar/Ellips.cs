using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa_16_06_2023.Doiralar
{
    public class Ellips : Doira
    {
        public Ellips(double r,double r2) : base(r)
        {
            R2 = r2;
        }

        public double R2 { get; set; }

        public new void Show()
        {
            Console.WriteLine($"Ellips  radiuslari {R} {R2}");
        }

        public override double Perimetr()
        {
            return 2 * PI * Math.Sqrt((R * 2 + R2 * R2) / 2);
        }

        public override double Yuza()
        {
            return PI*R*R2;
        }

    }
}
