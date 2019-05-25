using System;

namespace HomeWork_20_05_2019
{
    class MainClass

    {
        public static double Task2() // делал Виктор
        {
            int a = 20, b = 3, c = 4, d = 5;
            return (a / c) * (b / d) - (((a * b) - c) / (c * d));
        }
        public static double Task4()
        {
            int e = 2, f = 3;
            return (e + f) / (f + 1) - (((e * f) - 12) / (34 + e));
        }
        public static double Task5()
        {
            double x = 20, y = 40, e = 60, t = 80, g = 100;
            return 1 + Math.Pow(x, 2) * (y - t * g * x) / (3 + Math.Pow(e, y - 1)); // y-1 отнимает до вычисления степени е, т.е. е идет в степени 3, а не у = 4
        }
        public static double Task6() 
        {
            int x = 20, x3, x5, x1 = 3, x2 = 5;
            x3 = (int)Math.Pow(x, x1);
            x5 = (int)Math.Pow(x, x2);
            return x - (x3 / 3) + (x5 / 5);
        }
        public static int Task10()
        {
            int x = 2, y = 2, y2, xx;
            xx = (int)Math.Pow(x, x) * ((x - 1) / (x + 1));
            y2 = 18 * x * (int)Math.Pow(y, x);
            return xx + y2;
        }
        public static int Task11() 
        {
            int x = 2, y = 4, x2, y2;
            x2 = (int)(1 + (1 / Math.Pow(x, x)));
            y2 = (int)(Math.Pow(x, x) * y) * 12;
            return x2 - y2; 
        }
        public static double Task12()
        {
            double x = 4, y, x2;
            x2 = Math.Pow(x, 4) - (10 + (7 * x)); // 256 - 38 = 218
            y = Math.Pow(x, 4) - ((8 * x) + 12);  // 256 - 44 = 212
            return x2 / y; // 218 / 212 = 1,028
        }
        public static double Task16() 
        {
            double x = 4, x2, x3;
            x2 = (uint)Math.Pow(x, 2) - Math.Pow(x, 3);
            x3 = 7 * x / (Math.Pow(x, 3) - (15 * x));
            return x2 - x3;
        }
        public static double Task23() 
        {
            double x = 4, y = 5, xx;
            return xx = Math.Pow(3, x) - Math.Pow(4, x) + (y - Math.Sqrt(x));
        }

        public static double Task29() 
        {
            int x1 = 4, x2 = 6;
            return Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2)); 
        }

        public static double Task41() 
        {
            double a = 2, b = 4, c = 6, d = 8;
            return a * d / (a * d + b * c);
        }

        public static double Task43() 
        {
            double x = 4, a = 6, b = 8, c = 10;
            return 1 / Math.Sqrt((a * Math.Pow(x, 2)) + (b * x) + c);
        }

        public static double Task44() 
        {
            int x = 4; // y, x1, x2, x3;
             /* y = 2 * Math.Sqrt(x);
            x1 = 1 - Math.Sqrt(x);
            x2 = 1 + Math.Sqrt(x);
            x3 = x1 + x2;
            return x3 / y;*/
            return ((1 + Math.Sqrt(x)) + (1 - Math.Sqrt(x))) / (2 * Math.Sqrt(x));
        }
        public static int Task46()
        {
            int x = 4;
            return x + x + 1;
        }


        public static void Main()
        {
            Console.WriteLine("Task 2: " + Task2());

            Console.WriteLine("Task 4: " + Task4());

            Console.WriteLine("Task 5: " + Task5());

            Console.WriteLine("Task 6: " + Task6());

            Console.WriteLine("Task 10: " + Task10());

            Console.WriteLine("Task 11: " + Task11());

            Console.WriteLine("Task 12: " + Task12());

            Console.WriteLine("Task 16: " + Task16());

            Console.WriteLine("Task 23: " + Task23());

            Console.WriteLine("Task 29: " + Task29());

            Console.WriteLine("Task 41: " + Task41());

            Console.WriteLine("Task 43: " + Task43());

            Console.WriteLine("Task 44: " + Task44());

            Console.WriteLine("Task 46: " + Task46());

        }
    }

}
