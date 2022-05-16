using System;
using System.Collections.Generic;
using System.Text;

namespace YXLibrary
//Баранец Юлия и Минеева Христина
{
    public class Konus
    {
        public static double R;
        public static double H;
        public static double r;
        public static double h;

        public static void PloshOsn(double R)
        {
            double S = Math.PI * R * R;
            Console.WriteLine("Площадь основания конуса = {0}", S);
        }
        public static void Objem(double H, double R)
        {
            double V = (Math.PI * R * R * H) / 3;
            Console.WriteLine("Объём конуса = {0}", V);
        }
    }
}
