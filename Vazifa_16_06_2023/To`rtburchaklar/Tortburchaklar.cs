using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazifa_16_06_2023
{
    public class Tortburchaklar : Shakl
    {
        public Tortburchaklar(double A, double B)
        {
            a = A; 
            b = B;
        }
        public double a { get; set; }
        public double b { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"To`rtburchak  tomonlari {a} {b}");
        }

        public override double Perimetr()
        {
            return (a + b) * 2;
        }
        public override double Yuza()
        {
            return a * b;
        }
    }
}
