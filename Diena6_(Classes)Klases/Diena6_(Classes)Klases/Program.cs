using System;

namespace Diena6__Classes_Klases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet divus skaitļus!");
            int ievade1 = Convert.ToInt32(Console.ReadLine());
            int ievade2 = Convert.ToInt32(Console.ReadLine());

            int summa = Tasks.VērtībaA(ievade1) + Tasks.VērtībaB(ievade2);
            Console.WriteLine("Abus skaitļu summa ir " + summa);
            /*Console.WriteLine("Lūdzu, ievadiet vienu skaitli!");
            int ievadeC = Convert.ToInt32(Console.ReadLine());
            Tasks.Task1(ievadeC);
            */
            /*
             * Example.Test(); //sākumā klases nos. un tad metodes nos; no kurienes ko sauc -> tas ir ja metode ir statiska
            int a = Example.ReturnPublic();
            Console.WriteLine(a);

            Example.ParamPublic(4, 6);

            Example.b = 8;
            */
        }


    }
}
