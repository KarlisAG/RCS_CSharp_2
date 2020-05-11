using System;
using System.Collections.Generic;
using System.Text;

namespace Day7__Objects_Objekti
{
    class PasniedzējaShape
    {
        private double a, b, c, d, e;

        public PasniedzējaShape(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = 0;
            this.e = 0;
        }
        public PasniedzējaShape(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = 0;
        }
        public PasniedzējaShape(double a, double b, double c, double d, double e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.Write(a + "," + b + "," + c);//WriteLine atsarpi liek pēc ierakstītā, ne pirms tā
            if (d > 0)
            {
                Console.Write("," + d);
            }

            if (e > 0)
            {
                Console.Write("," + e);
            }
        }

        public double Perimeter()//ne tikai izvada perimetru (ja būtu void), bet to atgriež [labāk lietojama progr]; labāk klasē; un GUI
        {
            return a + b + c + d + e;
        }
    }
}
