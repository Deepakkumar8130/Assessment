using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assessment02
{
    internal class Class1
    {
        public static void Q1()
        {
            Console.WriteLine("Enter any four numbers:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            int s1 = a < b ? a : b;
            int s2 = c < d ? c : d;

            int s = s1 < s2 ? s1 : s2;
            Console.WriteLine("Smallest Number is : " + s);
        }

        // --------------------------------------------------------------------------------------------------------------------//

        public static void Q2()
        {
            Console.WriteLine("Enter any three numbers:- ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int a1 = Math.Min(Math.Min(a, b), c);
            int c1 = Math.Max(Math.Max(a, b), c);

            int b1 = (a + b + c) - (a1 + c1);
            Console.WriteLine("Before Sortng :- " + a + " " + b + " " + c);
            Console.WriteLine("After Sortng :- " + a1 + " " + b1 + " " + c1);

        }

        // --------------------------------------------------------------------------------------------------------------------//


        public static void Q3()
        {
            Console.Write("ENTER YOUR NAME :- ");
            string name = Console.ReadLine();

            Console.WriteLine("***************ENTER THE MARKS***************");
            Console.Write("PHYSICS         :- ");
            decimal p = Convert.ToDecimal(Console.ReadLine());

            Console.Write("CHEMISTRY       :- ");
            decimal c = Convert.ToDecimal(Console.ReadLine());

            Console.Write("MATHEMATICS     :- ");
            decimal m = Convert.ToDecimal(Console.ReadLine());

            Console.Write("ENGLISH         :- ");
            decimal e = Convert.ToDecimal(Console.ReadLine());

            Console.Write("PHYSICAL Ed.    :- ");
            decimal pe = Convert.ToDecimal(Console.ReadLine());
            
            Console.Write("TOTAL MARKS.    :- ");
            decimal TM = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();


            decimal marks_obtained = p + c + m + e + pe;

            decimal percentage =  (marks_obtained*100)/ TM;
            if (percentage >= 90) Console.WriteLine("NAME           : " + name + Environment.NewLine + "TOTAL MARKS    : " +TM+Environment.NewLine+"MARKS OBTAINED : "+marks_obtained+Environment.NewLine+"PERCENTAGE     : "+percentage+Environment.NewLine+"GRADE          : A");
            else if (percentage >= 75) Console.WriteLine("NAME           : " + name + Environment.NewLine + "TOTAL MARKS    : " + TM + Environment.NewLine + "MARKS OBTAINED : " + marks_obtained + Environment.NewLine + "PERCENTAGE     : " + percentage + Environment.NewLine + "GRADE          : B");
            else if (percentage >= 55) Console.WriteLine("NAME           : " + name + Environment.NewLine + "TOTAL MARKS    : " + TM + Environment.NewLine + "MARKS OBTAINED : " + marks_obtained + Environment.NewLine + "PERCENTAGE     : " + percentage + Environment.NewLine + "GRADE          : C");
            else if (percentage >= 40) Console.WriteLine("NAME           : " + name + Environment.NewLine + "TOTAL MARKS    : " + TM + Environment.NewLine + "MARKS OBTAINED : " + marks_obtained + Environment.NewLine + "PERCENTAGE     : " + percentage + Environment.NewLine + "GRADE          : D");
            else if (percentage >= 33) Console.WriteLine("NAME           : " + name + Environment.NewLine + "TOTAL MARKS    : " + TM + Environment.NewLine + "MARKS OBTAINED : " + marks_obtained + Environment.NewLine + "PERCENTAGE     : " + percentage + Environment.NewLine + "GRADE          : E");
            else Console.WriteLine("NAME          : " + name + Environment.NewLine + "TOTAL MARKS    : " + TM + Environment.NewLine + "MARKS OBTAINED : " + marks_obtained + Environment.NewLine + "PERCENTAGE : " + percentage + Environment.NewLine + "GRADE          : FAIL");


        }


        // --------------------------------------------------------------------------------------------------------------------//

        public static void Q4()
        {
            Console.Write("Enter a Number :- ");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 0:
                    Console.WriteLine("MALE");
                    break;
                case 1:
                    Console.WriteLine("FEMALE");
                    break;
                case 2:
                    Console.WriteLine("OTHERS");
                    break;
                default:
                    Console.WriteLine("INVALID INPUT");
                    break;
            }
        }


        // --------------------------------------------------------------------------------------------------------------------//

        public static void Q5()
        {
            Console.Write("Enter a number:- ");
            int n = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            while (n != 0)
            {
                fact *= n;
                n--;
            }
            Console.WriteLine("Factorial is :- " + fact);
        }

        // --------------------------------------------------------------------------------------------------------------------//

        public static void Q6()
        {
            Console.Write("Enter a starting point : - ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a ending point : - ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            while (n1 <= n2)
            {
                if (n1 % 7 == 0) Console.WriteLine(n1);
                n1++;
            }
        }

        // --------------------------------------------------------------------------------------------------------------------//

        public static void Q7()
        {
            Console.Write("Enter a Number : - ");
            int n = Convert.ToInt32(Console.ReadLine());

            int rev = 0;
            while (n != 0)
            {
                int d = n % 10;
                rev = rev * 10 + d;
                n /= 10;
            }
           // Console.WriteLine("Reverse number is :- "+rev);
           // Console.WriteLine("Reverse number is :- {0}",rev);
            Console.WriteLine($"Reverse number is :- {rev}");   // Anyone you can use .
        }

        // --------------------------------------------------------------------------------------------------------------------//

        public static void Q8()
        {
            Console.WriteLine("Enter a Number :-");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            int a = 0;
            int b = 1;

            if (n == 0) return;
            else if (n == 1) Console.WriteLine(a);
            else if (n == 2) Console.WriteLine(a + " , " + b);
            else
            {
                Console.Write(a + " , " + b);
                int i = 2;
                while (i < n)
                {
                    int c = a + b;
                    Console.Write(" , " + c);
                    a = b;
                    b = c;
                    i++;
                }
            }
        }


        // --------------------------------------------------------------------------------------------------------------------//

        static bool PrimeCheck(int n)
        {
            if (n == 0 || n == 1) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void Q9()
        {
            Console.Write("Enter a first number : - ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number : - ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            while (n1 <= n2)
            {
                if(PrimeCheck(n1)) Console.Write(n1+" ");
                n1++;
            }
        }


        // --------------------------------------------------------------------------------------------------------------------//

        static void table(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(n * i + " ");
            }
            Console.WriteLine();
        }
        public static void Q10()
        {
            Console.Write("Enter a first number : - ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number : - ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            while (n1 <= n2)
            {
                table(n1);
                n1++;
            }
        }


        // --------------------------------------------------------------------------------------------------------------------//


        public static void Q11()
        {
            Console.Write("Enter a first number : - ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number : - ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            while (n2 != 0)
            {
                int temp = n2;
                n2 = n1 % n2;
                n1 = temp;
            }
            Console.WriteLine(n1);

        }


        // --------------------------------------------------------------------------------------------------------------------//


        public static void Pattern1()
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }

        /* OUTPUT :-
                        1 2 3 4 5
                        1 2 3 4
                        1 2 3
                        1 2
                        1
        */


        // --------------------------------------------------------------------------------------------------------------------//


        public static void Pattern2()
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }

        /* OUTPUT :-
                        5 4 3 2 1
                        5 4 3 2
                        5 4 3
                        5 4
                        5
        */


        // --------------------------------------------------------------------------------------------------------------------//


        public static void Pattern3()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if(j == i) Console.Write(i+ " ");
                    else Console.Write("*"+" ");
                }
                Console.WriteLine();
            }

        }

        /* OUTPUT :-
                        1 * * * *
                        * 2 * * *
                        * * 3 * *
                        * * * 4 *
                        * * * * 5
        */


        // --------------------------------------------------------------------------------------------------------------------//


        public static void Pattern4()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if(j+i == n+1) Console.Write(j+ " ");
                    else Console.Write("*"+" ");
                }
                Console.WriteLine();
            }

        }

        /* OUTPUT :-
                        * * * * 5
                        * * * 4 *
                        * * 3 * *
                        * 2 * * *
                        1 * * * *
        */


        // --------------------------------------------------------------------------------------------------------------------//


        public static void Pattern5()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write(k + " "); ;
                }
                Console.WriteLine();
            }

        }

        /* OUTPUT :-
                            1
                           1 2
                          1 2 3
                         1 2 3 4
                        1 2 3 4 5
        */


        // --------------------------------------------------------------------------------------------------------------------//


        public static void Pattern6()
        {
            int n = 5;

            for (int i = n; i >= 1; i--)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write(k + " "); ;
                }
                Console.WriteLine();
            }

        }

        /* OUTPUT :-
                        1 2 3 4 5
                         1 2 3 4
                          1 2 3
                           1 2
                            1
        */


        // --------------------------------------------------------------------------------------------------------------------//


        public static void Pattern7()
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*" + " "); ;
                }
                Console.WriteLine();
            }

        }

        /* OUTPUT :-
                            *
                           * *
                          * * *
                         * * * *
                        * * * * * 
        */


         // --------------------------------------------------------------------------------------------------------------------//


        public static void Pattern8()
        {
            int n = 5;

            for (int i = n; i >= 1; i--)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write("*" + " "); ;
                }
                Console.WriteLine();
            }

        }

        /* OUTPUT :-
                        * * * * * 
                         * * * *
                          * * *
                           * *
                            *
        */


        // --------------------------------------------------------------------------------------------------------------------//


        public static void Pattern9()
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i+1; j++)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }

        }

        /* OUTPUT :-
                        * * * * * 
                        * * * *
                        * * *
                        * *
                        *    
                        * *
                        * * *
                        * * * *
                        * * * * *
        */
    }
}
