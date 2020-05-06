using System;
using System.Collections.Generic;
using System.Text;

namespace Diena6__Classes_Klases
{
    public class Example
    {
        private static int a = 0;
        public static int b = 0;//vērtības atcerās visas metodes

        public static void Test()
        {
            Console.WriteLine("Šī ir testa metode");
            Privatetest();
        }

        private static void Privatetest()
        {
            Console.WriteLine("Šī ir privāta testa metode");
            
        }

        public static int ReturnPublic()
        {
            
            return 3 + 2;
        }

        public static void ParamPublic(int a, int b)//šos a un b var izmantot tikai tur iekšā
        {
            Console.WriteLine(a + b);
            
        }

    }
    // public -> metodē var tikt ne tikai no tās klases, bet arī no "ārpasaules"
    // private -> ārpus klases nevar redzēt?; to var izsaukt klases iekšienē
}
