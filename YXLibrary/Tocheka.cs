using System;
using System.Collections.Generic;
using System.Text;

namespace YXLibrary
//Баранец Юлия и Минеева Христина
{
    public class Tocheka
    {
        public int x, y;
        public Tocheka(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"Точка {x}.{y}";
        }

        public static Tocheka operator * (Tocheka cl1, Tocheka cl2)
        {
            Tocheka resultPont = new Tocheka();
            resultPont.x = cl1.x * cl2.x;
            resultPont.y = cl1.y * cl2.y;
            return resultPont;
        }

        public static Tocheka operator / (Tocheka cl1, Tocheka cl2)
        {
            Tocheka resultPont = new Tocheka();
            resultPont.x = cl1.x / cl2.x;
            resultPont.y = cl1.y / cl2.y;
            return resultPont;
        }
    }
}
