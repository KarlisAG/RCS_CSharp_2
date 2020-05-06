using System;

namespace Diena6__Classes_Klases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lūdzu, ievadiet vienu skaitli!");
            int ievadeC = Convert.ToInt32(Console.ReadLine());
            Tasks.Task1(ievadeC);
            
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
