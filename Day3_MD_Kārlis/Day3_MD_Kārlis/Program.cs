using System;
using System.Security.Cryptography.X509Certificates;

namespace Day3_MD_Kārlis
{
    class Program
    {
        static void Main(string[] args)
        {
            PasniedzejaWhileTask();
            PasniedzējaZvaigznītes();
            //ForLoopTask3Extra();
            //WhileLoopTask1();
        }

        static void ForLoopTask3Extra()
        {
            String maxZvaigznes = "*****";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 3; i > 0; i--)
            {
                maxZvaigznes = maxZvaigznes.Remove(i);
                
                Console.WriteLine(maxZvaigznes);
            }
        }
        static void WhileLoopTask1()
        {
            Console.WriteLine("Dotajā uzdevumā Jūs drīkstat ievadīd cik skaitļus vien vēlaties (vismaz divus), lai šo darbību beigtu un parādītu lielāko un mazāko ievadītos ciparus Jums ir jāuzraksta STOP");
            String ievadeStop;
            bool stopTrue = false;
            int lielākais = -2147483648;
            int mazākais = 2147483647;

            while (!stopTrue)
            {
                ievadeStop = Console.ReadLine();
                if (ievadeStop == "STOP")
                {
                    stopTrue = true;
                    break;
                }
                else
                {
                    stopTrue = false;

                }

                int ievadeC = Convert.ToInt32(ievadeStop);
                if (lielākais <= ievadeC)
                {
                    lielākais = ievadeC;
                }
                else if (mazākais >= ievadeC)
                {
                    mazākais = ievadeC;
                }


                /*while (!stopTrue) --> Šī versija nestrādāja.. kāpēc? Jo ir cits ReadLine un to nepiefiksē jeb neņem vērā bool gadījumā?
                {
                    String ievade = Console.ReadLine();
                    if (ievadeStop == "STOP")
                    {
                        stopTrue = true;
                        break;
                    }
                    else
                    {
                        stopTrue = false;
                        if (!stopTrue)
                        { 
                            int ievadeC = Convert.ToInt32(ievade);
                            if (lielākais <= ievadeC)
                            {
                                lielākais = ievadeC;
                            }
                            else if (mazākais >= ievadeC)
                            {
                                mazākais = ievadeC;
                            }
                        }
                    }
                  */
            }
            Console.WriteLine("Lielākais ievadītais cipars bija: " + lielākais);
            Console.WriteLine("Mazākais ievadītais cipars bija: " + mazākais);
        }

        static void PasniedzējaZvaigznītes()
        {
            for (int i = 0; i < 4; i++)
            {
                PrintStars(i);
            }
            for (int i = 2; i >= 0; i--)
            {
                PrintStars(i);
            }
        }

        static void PrintStars(int len)
        {
            for (int j = 0; j <= len; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }


        /*  for (int i = 0; i< 4; i++)
            {
                for (int j = 0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/

        static void PasniedzejaWhileTask()
        {
            String choice = "";
            int biggest = 0; // Int32.MinValue - uzreiz ir -max nevis jāraksta manuāli!!
            int smallest = 0; //Int32.MaxValue
            while (choice!="n")
            {
                Console.WriteLine("Ievadiet skaitli!");
                int sk = Convert.ToInt32(Console.ReadLine());

                if (sk > biggest)
                {
                    biggest = sk;
                }

                if (sk < smallest)
                {
                    smallest = sk;
                }
                Console.WriteLine("Vai vēlaties turpināt? Rakstat n, ja negribat");
                choice = Console.ReadLine();
                choice = choice.ToLower(); //lai arī ar N strādā --- visus burtus pārtaisa par mazajiem burtiem
                
            }
            Console.WriteLine("Lielākais: " + biggest);
            Console.WriteLine("Mazākais: " + smallest);
        }

        static void WhileOption2()
        {
            
            int biggest = 0; // Int32.MinValue - uzreiz ir -max nevis jāraksta manuāli!!
            int smallest = 0; //Int32.MaxValue
            while (true)
            {
                Console.WriteLine("Ievadiet skaitli!");
                int sk = Convert.ToInt32(Console.ReadLine());

                if (sk > biggest)
                {
                    biggest = sk;
                }

                if (sk < smallest)
                {
                    smallest = sk;
                }
                Console.WriteLine("Vai vēlaties turpināt? Rakstat n, ja negribat");
                String choice = Console.ReadLine();
                if (choice == "n")
                {
                    break;//liek beigās ja grib, lai cilvēks vismaz vienu ciparu ievada; sākumā liek ja grib iespēju uzreiz no loopa iziet, neierakstot ciparus
                }
                    //choice.ToLower(); //lai arī ar N strādā --- visus burtus pārtaisa par mazajiem burtiem

            }
            Console.WriteLine("Lielākais: " + biggest);
            Console.WriteLine("Mazākais: " + smallest);
        }

        static void Test()
        {
            String a = "12";
            String b = "aa";

            int number;

            bool success = Int32.TryParse(a, out number); //pārkonvertē, uztaisot referenci; principār pārbauda vai Stringu var pārlikt uz int

            if (success == true)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Parse neizdevās"); // principā ar šo var izvairīties no exceptioniem, bet viņs neieteica to izmantot...?
            }
        }


    }
}
