using System;
using System.Collections.Generic;

namespace Day7__Objects_Objekti
{
    class Program
    {
        static void Main(string[] args)
        {
            //IzvadeObject2();
            //Shape daudzstūris = new Shape(3,4,5, 6);
            //PasniedzējaTask2();
            //List();
            //ListTask1();
            //PasniedzējaList();
            Lists2();
            //PasniedzējaList2();
        }

        static void PasniedzējaList2()
        {
            Random random = new Random();

            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(100));
            }

            String choice = "";
            while (choice != "0")
            {
                Console.WriteLine("1 - izvadīt sarakstu");
                Console.WriteLine("2 - dzēst");
                Console.WriteLine("0 - iziet");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        foreach(int a in numbers)
                        {
                            Console.WriteLine(a);
                        }
                        break;
                        case "2":
                        Console.WriteLine("Kuru dzēst?");
                        int toDelete = Convert.ToInt32(Console.ReadLine());
                        numbers.RemoveAt(toDelete);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("nepareiza ievade!");
                        break;
                }
            }

        }

        static void Lists2()
        {
            List<int> l = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                l.Add(random.Next(51));

            }
            
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Sveiki! Ko Jūs vēlaties izdarīt?");
                Console.WriteLine("Uzspiežot 1 - izvadīt sarakstu");
                Console.WriteLine("Uzspiežot 2 - izdzēst kādu elementu no saraksta pēc indeksa");
                Console.WriteLine("Uzspiežot 3 - iziet no šīs programmas");
                
                String ievade = Console.ReadLine();
                if (ievade == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("Dotā brīža saraksts: ");
                    foreach (int a in l)
                    {
                        Console.WriteLine(a);
                    }

                }
                else if (ievade == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("Ievadiet, kāda indeksa skaitli Jūs vēlaties izdzēst");
                    
                    try
                    {
                        int remove = Convert.ToInt32(Console.ReadLine());
                        l.RemoveAt(remove);
                    }
                    catch(ArgumentOutOfRangeException)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Norādītais indekss sarakstā nav pieejams!");
                    }
                }
                else if(ievade == "3")
                {
                    Console.WriteLine("Paldies, ka lietojā šo programmu!");
                    break;
                }
                else
                {
                    Console.WriteLine("Jūs esat ievadījuši nepareizu simbolu, lūdzu, ievadiet no 1 līdz 3!");
                    Console.WriteLine();
                }

                if(l.Count == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Saraksts ir tukšs!");
                    Console.WriteLine("Vai vēlaties programmu sākt no jauna? Ja vēlaties, tad uzrakstiet Y");
                    String ievadeBeigt = Console.ReadLine();
                    ievadeBeigt.ToLower();
                    if(ievadeBeigt == "y")
                    {
                        Lists2();
                    }
                    else
                    {
                        Console.WriteLine("Paldies, ka lietojā šo programmu!");
                        break;
                    }
                }
            }
        }

        static void PasniedzējaList()
        {
            List<String> a = new List<String>();

            while (true)
            {
                Console.WriteLine("Ievadiet elemtu");
                a.Add(Console.ReadLine());

                Console.WriteLine("Vai turpināt?");
                String choice = Console.ReadLine();

                if (choice == "n")
                {
                    break;
                }
            }

            foreach(String str in a)
            {
                Console.WriteLine(str);
            }
        }
        static void ListTask1()
        {
            List<String> list = new List<String>();
            Console.WriteLine("Ievadiet dažādas simbolu virknes, kad izvēlaties beigt, tad ievadiet STOP");
            bool ievadeSTOP = false;
            do
            {
                String ievade = Console.ReadLine();
                if (ievade == "STOP")
                {
                    ievadeSTOP = true;
                }
                else
                {
                    list.Add(ievade);
                }
            } while (ievadeSTOP == false);

            Console.WriteLine("Jūs ievadījāt: ");
            foreach(String a in list)
            {
                Console.WriteLine(a);
            }
        }

        static void List()
        {
            List<String> a = new List<String>();
            a.Add("aa");
            a.Add("bb");
            //a.RemoveAt(0);//ja izņem indx 1, tad jaunais garums ir 0; ja izdzēs 0 indx, tad jaunais 0 ir bb; nepalied tukšums, garums adaptējas

            for(int i = 0; i < a.Count; i++)
            {

            }

            foreach(String b in a)//nodefinē ele. tipu, kāds ir saraksts; un tas ir kā atsevišķs mainīgais -> b; in = kam mēs ejam cauri; iet cauri visam sarakstam un katrā iterācijā saglabājās vērtība iekš b
            {
                Console.WriteLine(b);
            }

        }

        static void NodarbībasSākums()
        {
            //ja ir static - tad objektu nelieto; statiskai vērtībai nevir piešķirt, to aks ir apredzēts objektam
            //statiskas metodes taisa, tad kad netaisa objektu??
            Trijsturis tr1 = new Trijsturis(1, 2, 3);//metodei jeb konstruktoram vajag tad uzreiz parametrus
            tr1.Print();//ja nav statiskas metodes, tad rakstot klasi un metodes, tad neko nevar izsaukt jeb Trijsturi. .. neder!
            //^^ bet rakstot objektu var tikt klāt!!

            Trijsturis tr2 = new Trijsturis(4, 5, 6);
            tr2.Print();


            Students st1 = new Students("Kārlis", "Gribulis", 2);
            st1.Print();

            Students st2 = new Students("Marija", "Soldatenko", 1);
            st2.Print();

            Students[] students = new Students[5];//katrā tad var 1 objektu; objekti klasē..?
            students[0] = new Students("Jānis", "Bērziņš", 3);


            List<Students> st = new List<Students>();//ja ir runa par objektiem, tad list ir daudz labāks
                                                     //ja uztaisa for ciklu uz i, ja arrayiem nav viss aizpildīs, tad crash
                                                     //listi nekrashos, garums pielāgosies; un var vienkārši add pie listes un būs ok
        }

        static int Input()
        {
            try
            {
                
                int ievade = Convert.ToInt32(Console.ReadLine());
                return ievade;
            }
            catch 
            {
                return 0;
            }

        }
        static void IzvadeObject2()
        {
            Console.WriteLine("Lūdzu, ievadiet sava daudzstūra vēlamo malu garumus! Jums ir jāievada 3-5 dažādi cipari. Ja gribat tikai trīsstūri vai četrstūri, tad ievadiet tik dažādu malu garumus un pārējās ievadēs (kopā 5) ievadet jebkuru citu simbolu, atskaitot ciparus!");
            Shape daudzstūrisArIevadi = new Shape(Input(), Input(), Input(), Input(), Input());
            daudzstūrisArIevadi.Print();
            daudzstūrisArIevadi.Perimeter();
        }

        static void PasniedzējaTask2()
        {
            Console.WriteLine("Kādu figūru vēlaties?");//ar cilvēka ievadi
            int choice = Convert.ToInt32(Console.ReadLine());

            PasniedzējaShape sh;

            if(choice == 3)
            {
                sh = new PasniedzējaShape(4, 5, 6);
                
            }else if (choice == 4)
            {
                sh = new PasniedzējaShape(4, 7, 3, 2);
            }
            else
            {
                return;
            }


                Console.WriteLine(sh.Perimeter());
                sh.Print();


            /*PasniedzējaShape tr = new PasniedzējaShape(4, 5, 6);
            Console.WriteLine(tr.Perimeter());
            tr.Print();

            PasniedzējaShape cetr = new PasniedzējaShape(4, 4, 4, 4);
            Console.WriteLine(cetr.Perimeter());
            cetr.Print();
            */
        }
    }
}
