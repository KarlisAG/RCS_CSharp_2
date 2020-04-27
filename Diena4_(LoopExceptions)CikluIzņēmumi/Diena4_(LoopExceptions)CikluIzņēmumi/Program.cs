using System;

namespace Diena4__LoopExceptions_CikluIzņēmumi
{
    class Program
    {
        static void Main(string[] args)
        {
            TestParse();
            //WhileExample();
        }

        static void WhileExample()
        {
            String choice = "";

            while(choice != "n")
            {
                Console.WriteLine("ievadiet tekstu!");
                choice = Console.ReadLine();

                Console.WriteLine("yay");

            }

            do //do-while --> cikls garantēti vismaz 1 reizi iziet cauri
            {
                Console.WriteLine("ievadiet tekstu!");
                choice = Console.ReadLine();

                Console.WriteLine("yay");
            } while (choice != "n");


        }

        static void TestParse()
        {
            int sk;

            try //šo darīs līdz būs exception //// iziet cauri vienreiz - pa defu
            {
                Console.WriteLine("Ieavadiet skaitli");
                sk = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Tikām tālāk");
            }
            catch (Exception ex) //šajā gad. ķer visus expection, neatkarīgi ne no kā, bet var arī specifiskus)
            {//catch iziet vienreiz cauri un tad pasaka erro un programma beidz darbīu, ja netaisa izņēmumus taisīt kādu citu loop
                sk = 0;
                Console.WriteLine("Exceptions!");
                //TestParse(); --> šī ir rekursija - ja ir exception, tad iet atkal metode, bet tas ir mūžīgais cikls
            }

            Console.WriteLine("Succes " + sk); //ja ar rekursiju taisa, tad šo ieliek try blokā
        }
    }
}
