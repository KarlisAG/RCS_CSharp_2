using System;

namespace Diena5__Arrays_Masīvi
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayTask1();
            //ArraySample();
        }

        static void ArraySample() //primitīvākā datu struktūra
        {
            int[] a = new int[5]; //5 ir masīvu garums

            a[0] = 1;
            a[1] = 5;
            a[2] = 8;
            a[3] = 7;
            a[4] = 99;

            //Console.WriteLine(a); šādi izvadīs un teiks, ka tas ir int tipa masīvs
            Console.WriteLine(a[0]);

            int sum = a[0] + a[4];
            Console.WriteLine(sum);

            //a = new int[10]; //masīvam var pārdefinēt izmēru; tas ir konstruktors -> masīvs ir uztaisīts no jauna; 10 jaunas vērtības, viss iepriekšējais pazuda

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static void ArrayTask1()
        {
            int[] mas = new int[5];
            int summa = 0;
            Console.WriteLine("Lūdzu, ierakstiet 5 dažādus veselus ciparus!");
            for (int i = 0; i < 5; i++)
            {
                mas[i] = Pārveidošana();
            }

            /*mas[0] = Pārveidošana();
            mas[1] = Pārveidošana();
            mas[2] = Pārveidošana();
            mas[3] = Pārveidošana();
            mas[4] = Pārveidošana();
            */
            for (int i = 0; i < 5; i++)
            {
                summa = summa + mas[i];
            }
            Console.WriteLine();
            Console.WriteLine("Jūsu ievadīto ciparu summa ir " + summa);

        }

        static int Pārveidošana()
        {
            String ievade1 = Console.ReadLine();
            int ievade1C = Convert.ToInt32(ievade1);
            return ievade1C;
        }
    }

}
