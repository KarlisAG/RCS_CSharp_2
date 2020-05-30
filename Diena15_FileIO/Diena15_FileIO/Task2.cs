using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Diena15_FileIO
{
    class Task2
    {
        public static void Reverse()
        {
            String[] text = File.ReadAllLines(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Task2\Test.txt");

            Array.Reverse(text);
            File.WriteAllLines(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Task2\Test_new2.txt", text);
        }

        public static void Run()
        {
            List<String> lines = new List<String>();
            Read(lines, "Test.txt");
            Write(lines);
            Console.WriteLine("--------");
            lines.Clear();
            Read(lines, "Test2_new.txt");
            //kkas nestrādā, pačeko pasniedzēja variantu githubā!
        }

        public static void Read(List<String> lines, String file)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Task2\" + file);

                line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    lines.Add(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");
            }
        }
        public static void Write(List<String> lines)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\akots\Desktop\Programmesana_StreamReadWrite\Task2\Test2_new.txt");

                //lines.Reverse();
                List<String> reversed = new List<string>();
                for(int i = lines.Count - 1; i >= 0; i--)
                {
                    reversed.Add(lines[i]);
                }

                foreach(String line in lines)
                {
                    sw.WriteLine(reversed);
                }
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila");
            }
        }
    }
}
