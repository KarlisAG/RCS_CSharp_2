using System;

namespace Diena5__Arrays_Masīvi
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayTask1();
            //ArraySample();
            //Task2();
            //Task3();
            PasniedzejaTask3();
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
            //a.Length // length ņem visu masīva garumu -- a ir masīva nosaukums
            /*
            mas[0] = Pārveidošana();
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

        static void PasniedzējaTask1()
        {
            int[] a = new int[5];
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
        }

        static void Task2()
        {
            int[] a = { 1, 6, 7, 12, 14, 9 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            int vidējais = sum / a.Length;
            Console.WriteLine("Masīvu ciparu vidējā vērtība ir " + vidējais);
        }

        static void Task3()
        {
            int[] mas = new int[10];
            Random rnd = new Random();
            int randomC;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(1, 10);
                Console.WriteLine(mas[i]);
            }

            Console.WriteLine("Ievadiet skaitli, kuru Jūs vēlaties atrast!");
            String ievade = Console.ReadLine();
            int ievadeC = Convert.ToInt32(ievade);
        }

        static void PasniedzejaTask3()
        {
            int[] mas = new int[10];
            Random random = new Random();
            bool ir;
            int cits = 0;

            for (int i = 0; i < 10; i++)
            {
                mas[i] = random.Next(1, 11);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine("Ievadiet skaitli, ko meklēt");
            int sk = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if (sk == mas[i])
                {
                    if (i == 1)
                    {
                        Console.WriteLine("Indeksi: ");
                    }
                    Console.Write(i + " ");
                }
                else
                {
                    cits++;
                }
                if (cits == 10)
                {
                    Console.Write("Jūsu ievadītais cipars nav atrodams masīvā!");
                }




            }
        }


    }

}
