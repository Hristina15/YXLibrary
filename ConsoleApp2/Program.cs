using System;
using YXLibrary;

namespace ConsoleApp2
    //Баранец Юлия и Минеева Христина
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = YXLibrary.Arefm.Add(20, 4);
            Console.WriteLine(result);
            
            double result1 = YXLibrary.Arefm.Subtract(928, 265);
            Console.WriteLine(result1);

            double result2 = YXLibrary.Arefm.Multiplay(91, 3);
            Console.WriteLine(result2);

            double result3 = YXLibrary.Arefm.Divide(756, 6);
            Console.WriteLine(result3);
            Console.ReadLine();

            Konus k = new Konus();
            Console.Write("Введите радиус R= ");
            Konus.R = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту H= ");
            Konus.H = Convert.ToDouble(Console.ReadLine());

            Konus.PloshOsn(Konus.R);
            Konus.Objem(Konus.H, Konus.R);

            Console.ReadLine();

            Tocheka h = new Tocheka();
            Tocheka cl1 = new Tocheka(8, 13);
            Tocheka cl2 = new Tocheka(62, 2);

            Console.WriteLine(cl1 * cl2);
            Console.WriteLine(cl1 / cl2);
            Console.ReadLine();
        }
    }
}
