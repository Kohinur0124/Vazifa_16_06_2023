using Vazifa_16_06_2023.Doiralar;

namespace Vazifa_16_06_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tortburchaklar t1= new Tortburchaklar(3,4);
            Kvadrat k1 = new Kvadrat(4);
            Paralelogram p1 = new Paralelogram(3, 4, 30);
            Trapetsiya tp1 = new Trapetsiya(4, 5, 3, 3);

            t1.Show();
            t1.Solve();
            k1.Show();
            k1.Solve();
            p1.Show();
            p1.Solve();
            tp1.Show();
            tp1.Solve();

            Console.WriteLine();

            Doira d1 = new Doira(4);
            Ellips e1 = new Ellips(3,4);

            d1.Show();
            d1.Solve();
            e1.Show();
            e1.Solve();




        }
    }
}