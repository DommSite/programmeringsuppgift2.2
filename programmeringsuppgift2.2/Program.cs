using System;

namespace övning2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Alma?");
            float almahopp = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt hoppade Elin?");
            float elinhopp = float.Parse(Console.ReadLine());
            float skillnad = almahopp - elinhopp;
            Console.WriteLine("Alma hoppade " + skillnad + " meter längre än Elin");
            Console.ReadKey();
        }
    }
}