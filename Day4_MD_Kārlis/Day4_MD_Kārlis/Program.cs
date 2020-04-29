using System;
using System.Dynamic;

namespace Day4_MD_Kārlis
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomNumber();
            Console.WriteLine("\n");
            Console.WriteLine("Ierakstiet, lūdzu, divus dažādus ciparus, kurus vēlaties kāpināt. Pirmais cipars ir bāzes un otrais kāpinātāja vērtība!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kāpināšanas vērtība ir: " + KāpināšanaFinal(a, b));
            Console.WriteLine("\n");
            Console.WriteLine("Zemāk ir apskatāma īsa ciparu piramīda!");
            Piramīda();
        }

        static void RandomNumber()
        {
            Random rnd = new Random();
            
            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine("Cenšaties uzminēt random skaitli diapazonā no 1 līdz 20!");
                String ievade = Console.ReadLine();
                int ievadeC = Convert.ToInt32(ievade);
                int randomC = rnd.Next(1, 20);
                //Console.WriteLine(randomC);
                if(ievadeC == randomC)
                {
                    Console.WriteLine("Apsveicam, Jūs uzminējāt pareizo ciparu!");
                    break;
                }
                else
                {
                    Console.WriteLine("Jūs diemžēl neuzminējāt, Jums vēl ir palikuši " + i + " mēģinājumi!");
                    if (i == 0)
                    {
                        Console.WriteLine("Jūsu mēģinājumi ir diemžēl beigušies, lai mēģinātu atkal pārrestartējiet programmu!");
                    }
                }

            }
        }

        static int KāpināšanaFinal(int a, int b)
        {
            double jaunaisA = Convert.ToDouble(a);
            double jaunaisB = Convert.ToDouble(b);
            double result;
            result = Math.Pow(jaunaisA, jaunaisB);
            int resultI = Convert.ToInt32(result);
            return resultI;

        }

        /*puspabeigts kods, jo nesanāca vēlamais rezultāts.. Vai ir iespēja mainīt mainīgā vērtības pārejot no if uz else statement? Jo mana ideja bija 1. reizē a*a un tad tālāk reizilāt to rezultātu ar tik reizes cik nepieciešams, bet vienmēr saskāros ar problēmu, ka mainīgajam vērtība nav atjaunota.. Kā būtu bijis labāk darīt?
         * static int Kāpināšana(int a, int b)
        {
            int pēdējais;
            
            //Math mat = new Math();
            //int kap = Math.Exp(b);
            //Console.WriteLine(kap);
            //return kap;
            for(int i = 0; i == b; i++)
            {
                
                if (i == 0)
                {
                    Kāpināšana2(a);
                }
                else 
                {    
                    pēdējais = Kāpināšana2(a) * a;
                    Console.WriteLine(pēdējais);
                    return pēdējais;
                }

            }
            return pēdējais;
        }

        static int Kāpināšana2(int a)
        {
            int jaunaisA = a * a;
            return jaunaisA;
        }
        */
        static void Piramīda()
        {
            int cipars = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(++cipars + " ");
                }
                Console.WriteLine();
            }
        }
    }
}