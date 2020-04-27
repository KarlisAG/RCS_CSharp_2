using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Diena3__loops_cikli
{
    class Program
    {
        static void Main(string[] args)
        {
            //PasniedzējaTask1();
            //BiggestNumber();
            //ForExample();
            //Task2();
            //Task3();
            PasniedzējaTask3();
        }

        static void ForExample()
        {
            
            for (int i = 0; i < 10; i++) //i++, i = i + 1
            {
                  
               Console.WriteLine(1); // 1 būs 10 reizes; i iet fonā un katru reizi cikls atkārtojas, tpc tas viens arī ir
               // Console.WriteLine(i);
            }
               
            for (int i = 9; i >= 0; i--)
            {
                //tas pats, tikai pretēji
            }
        }
        static void BiggestNumber()
        {
            Console.WriteLine("Lūdzu, ievadiet 5 dažādus ciparus!");
            String ievade;
            int lielākais = 0;
                for (int i = 0; i < 5; i++)
                {
                    ievade = Console.ReadLine();
                    int ievadeC = Convert.ToInt32(ievade);
               
                   if (ievadeC > lielākais)
                   {
                        lielākais = ievadeC;
                   }

                }

            Console.WriteLine("Lielākais ievadītais cipars bija " + lielākais);
            
            
        }

        static void PasniedzējaTask1() //viņa piemērs
        {
            int biggest = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                int nr = Convert.ToInt32(Console.ReadLine());

                if (biggest < nr)
                {
                    biggest = nr;
                }
            }

            Console.WriteLine("Lielākais skaitlis ir " + biggest);
        }



        static void Task2()
        {
            Console.WriteLine("Lūdzu, ievadiet 10 dažādus veselus ciparus!");
            String ievade;
            int nulle = 0;
            int negatīvs = -1;
            int pozitīvs = 1;
            int kopumāPoz = 0;
            int kopumāNeg = 0;
            int kopumāNulles = 0;
            int cikPoz = 0;
            int cikNeg = 0;
            int cikNulles = 0;

            for (int i = 0; i < 10; i++)
            {
                ievade = Console.ReadLine();
                int ievadeC = Convert.ToInt32(ievade);

                if (ievadeC >= pozitīvs)
                {
                    cikPoz = kopumāPoz + 1;
                }
                else if (ievadeC <= negatīvs)
                {
                    cikNeg = kopumāNeg + 1;
                }
                else if (ievadeC == nulle)
                {
                    cikNulles = kopumāNulles + 1;
                }

            }

            Console.WriteLine("Jūs ievadījuši " + cikPoz + " pozitīvus skaitļus, " + cikNeg + " negatīvus skaitļus un " + cikNulles + " nulles!");
        }

        static void PasniedzejaTask2()
        {
            int pos = 0;
            int neg = 0;
            int zero = 0;
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                int nr = Convert.ToInt32(Console.ReadLine());

                if (nr > 0)
                {
                    pos++;
                }
                else if(nr < 0)
                {
                    neg++;
                }
                else
                {
                    zero++;
                }
            }

            Console.WriteLine("Pozitīvas: " + pos);
            Console.WriteLine("Negatīas: " + neg);
            Console.WriteLine("Nulles: " + zero);

        }

        static void Task3()
        {
            String zvaigznītes = "*";

            for (int i = 0; i < 4; i++)
            {
                for (int y = 0; y <= i; y++)
                {
                    Console.Write(zvaigznītes);
                }

                Console.WriteLine();
            }
        }

        static void PasniedzējaTask3()
        {
            String zvaigznes = "";

            for (int i = 0; i < 4; i++)
            {
                zvaigznes = zvaigznes + "*";
                Console.WriteLine(zvaigznes);
            }
        }

        static void PasniedzējaTask3_2v()
        {
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < i; j++) //katru reizi iet tik reizes vairāk cik 1.for
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}