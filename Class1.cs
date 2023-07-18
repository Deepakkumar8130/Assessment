using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment01
{
     class Class1
    {
        static void Discount(float amount, float dis)
        {

            float bill = (amount / 100) * dis;
            Console.WriteLine("Amount :- " + amount);
            Console.WriteLine("After " + dis + "% Discount :- " + (amount - bill));
        }
        public static void Q1()
        {
            Console.WriteLine("Enter the Amount :- ");
            float amt = float.Parse(Console.ReadLine());

            if (amt >= 1000) Discount(amt, 20);
            else if (amt >= 500 && amt < 1000) Discount(amt, 10);
            else if (amt >= 200 && amt < 500) Discount(amt, 4);
            else Discount(amt, 1.5f);
        }

        public static void Q2()
        {
            Console.WriteLine("Enter any Three Numbers :- ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int a1 = Math.Min(Math.Min(a, b), c);
            int c1 = Math.Max(Math.Max(a, b), c);
            int b1 = (a + b + c) - (a1 + c1);

            Console.WriteLine("Before Sorting :- " + a + " " + b + " " + c);
            Console.WriteLine("After Sorting :- " + a1 + " " + b1 + " " + c1);

        }

        public static void Q3()
        {
            Console.WriteLine("Enter any Number :- ");
            int n = int.Parse(Console.ReadLine());

            int reverse = 0;
            while (n != 0)
            {
                int d = n % 10;
                reverse = reverse * 10 + d;
                n /= 10;
            }

            Console.WriteLine("Reverse Number is :- " + reverse);
        }

        public static void Q4()
        {
            Console.WriteLine("Enter a Number :- ");
            int n = int.Parse(Console.ReadLine());

            int fact = 1;
            while (n != 0)
            {
                fact *= n;
                n--;
            }

            Console.WriteLine("Factorial is :- " + fact);
        }
    }
}
