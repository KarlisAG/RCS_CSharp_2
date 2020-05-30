using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Diena15_FileIO
{
    class Task1
    {

        public static void Menu()
        {
            String choice = "";
            while (choice != "0")
            {
                Console.WriteLine();
                Console.WriteLine("Jums ir iespejas faila");
                Console.WriteLine("1 - lasit failu");
                Console.WriteLine("2 - parrakstit failu ar jaunu tekstu");
                Console.WriteLine("3 - pierakstit klat tekstu faila beigas");
                Console.WriteLine("4 - rediget kadu konkretu liniju faila");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Read();
                        break;
                    case "2":
                        WriteOver();
                        break;
                    case "3":
                        WriteAdd();
                        break;
                    case "4":
                        WriteEdit();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Ievades kluda!");
                        break;
                }
            }
        }
        public static void Read()
        {
            
            String line;
            try
            {
                Console.WriteLine("Ievadiet .txt faila nosaukumu, kuru velaties lasti (default ir Text1)");
                String fileName = Console.ReadLine();
                StreamReader sr = new StreamReader(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\" + fileName + ".txt");
                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);

                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");
            }
        }
        public static void WriteOver()
        {
            try
            {
                if (Save())
                {
                    StreamWriter sw = new StreamWriter(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Text1.txt");
                    Console.WriteLine("Ierakstiet jauno tekstu");
                    bool stop = false;
                    while (!stop)
                    {
                        String newText = Console.ReadLine();
                        sw.WriteLine(newText);
                        Console.WriteLine("Ja velaties beigt rakstit klat, ievadiet STOP");
                        String choice = Console.ReadLine();
                        if (choice == "STOP")
                        {
                            stop = true;

                        }
                    }
                    sw.Close();
                }
                else
                {
                    Console.WriteLine("Ierakstiet jauna .txt faila nosaukumu");
                    String name = Console.ReadLine();
                    StreamWriter sw = new StreamWriter(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\" + name + ".txt", true);
                    Console.WriteLine("Ierakstiet jauno tekstu");
                    bool stop = false;
                    while (!stop)
                    {
                        String newText = Console.ReadLine();
                        sw.WriteLine(newText);
                        Console.WriteLine("Ja velaties beigt rakstit klat, ievadiet STOP");
                        String choice = Console.ReadLine();
                        if (choice == "STOP")
                        {
                            stop = true;

                        }
                    }
                    sw.Close();
                }
                Menu();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila");
            }
        }

        public static void WriteAdd()
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Text1.txt", Save());
                Console.WriteLine("Ierakstiet tekstu, kuru velaties pierakstit klat faila beigas!");
                bool stop = false;
                while (!stop)
                {
                    String newText = Console.ReadLine();
                    sw.WriteLine(newText);
                    Console.WriteLine("Ja velaties beigt rakstit klat, ievadiet STOP");
                    String choice = Console.ReadLine();
                    if (choice == "STOP")
                    {
                        stop = true;

                    }
                }
                sw.Close();
                Menu();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila");
            }
        }

        public static void WriteEdit()
        {
             Console.WriteLine("Ievadiet kuru teksta liniju velaties rediget!");
             String[] arrLine = File.ReadAllLines(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Text1.txt");
             int choice = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Ierakstiet jauno tekstu!");
             arrLine[choice - 1] = Console.ReadLine();
             File.WriteAllLines(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Text1.txt", arrLine);
        }

        private static bool Save()
        {
            Console.WriteLine("Vai jus gribesiet izmainas saglabat esosaja faila vai jauna?");
            Console.WriteLine("1 - taja pasa");
            Console.WriteLine("2 - jauna");
            String choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    return true;
                case "2":
                    return false;
                default:
                    Console.WriteLine("Ievades kluda");
                    Save();
                    return false;
            }
        }
    }
}
