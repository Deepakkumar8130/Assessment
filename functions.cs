namespace Functions
{
    class functions
    {
        static int multiplication(int a, int b, out bool ch)    // Call by value with out keyword.
        {
            if (a * b >= 100) ch = true;
            else ch = false;

            return a * b;
        }


        static void changes(ref int a, ref int b)   // Call by reference.
        {
            a = a + 6;
            b = b * 4;
        }

        static int FindMax(params int[] arr)        // Params
        {
            int max = 0;
            foreach (int i in arr)
            {
                if (max < i) max = i;
            }
            return max;
        }

        static int multiple(int a , int b = 5)      // For assign default value.
        {
            return a * b;
        }

        public static void Main(String[] args)
        {

              #region MATH

              decimal n = Convert.ToDecimal(Console.ReadLine());

              Console.WriteLine(Math.Abs(n));       // For getting Absolute Value like if n is -ve then value considered +ve.
              Console.WriteLine(Math.Ceiling(n));   // For getting choose highest Integer value like if n= 4.4 then they choose 5.
              Console.WriteLine(Math.Round(n));     // For getting choose highest near Integer value like if n= 4.4 then they choose 4.
              Console.WriteLine(Math.Floor(n));     // For getting choose Lower Integer value like if n= 4.7 then they choose 4.

              int a = 5, b = 7;
              Console.WriteLine(Math.Max(a,b));     // For getting a Maximun value of between two numbers.
              Console.WriteLine(Math.Min(a,b));     // For getting a Minimum value of between two numbers.
              Console.WriteLine(Math.Pow(a, b));    // For solve power expression like  2^5 = 32. So we write Math.Pow(2, 5).
              Console.WriteLine(Math.Sqrt(a));      // For solve Square root expression like  √100 = 10. So we write Math.Sqrt(100).
              #endregion

              #region RANDOM_&_GUID
              // RANDOM
              Random number = new Random();
              var otp= number.Next();               // for getting a random value.
              Console.WriteLine(otp);

              int otp1= number.Next(1000,9999);     // for getting a random value with bound conditions like number between only 1000 to 9999.
              Console.WriteLine(otp1);


              // GUID
              //This keyword used for getting a unique ID like - 5caaab6b-171d-4676-b02d-f440a3923898.
              Guid guid = Guid.NewGuid();
              Console.WriteLine(guid);
              #endregion

              #region DATETIME

              var today = DateTime.Now;           // For getting exact now time.
              Console.WriteLine(today);


              Console.WriteLine(today.Date);           // For getting date.


              Console.WriteLine(today.Day);           // For getting day 19 limit(1 to 29/30/31)
              Console.WriteLine(today.DayOfWeek);     // For getting day of week like - Monday.                                          
              Console.WriteLine(today.DayOfYear);     // For getting day of year like - 125 limit(1 to 366/365).


              Console.WriteLine(today.ToShortDateString());   // For get Only Date like 12-10-23.
              Console.WriteLine(today.ToShortTimeString());   // For get only Time like 12:48 PM.

              Console.WriteLine(today.ToLongDateString());    // For get Date like - Wednesday, July 19, 2023.
              Console.WriteLine(today.ToLongTimeString());    // For get Time like - 12:48:46 PM.
              #endregion

              #region CHARACTER HANDLING

              char ch = '5';

              Console.WriteLine(ch);

              Console.WriteLine(char.IsLower(ch));

              Console.WriteLine(char.IsUpper(ch));

              Console.WriteLine(char.IsLetter(ch));

              Console.WriteLine(char.IsLetterOrDigit(ch));

              Console.WriteLine(char.IsPunctuation(ch));

              Console.WriteLine(char.IsNumber(ch));

              Console.WriteLine(char.IsSeparator(ch));

              Console.WriteLine(char.IsWhiteSpace(ch));

              Console.WriteLine(char.IsDigit(ch));

              Console.WriteLine(char.IsControl(ch));

              #endregion

            #region USER DEFINE FUNCTION

            int n1 = 10, n2 = 12;
            bool check;
            Console.WriteLine(multiplication(n1, n2, out check)); // if we want to return more than one return statement from methods then we out keyword.
            Console.WriteLine(check);

            int n3 = 5, n4 = 3;
            Console.WriteLine($"{n3} and {n4}");
            changes(ref n3, ref n4);                              // Call by reference.
            Console.WriteLine($"{n3} and {n4}");

            Console.WriteLine(FindMax(1,2,8,6,10,15));
            Console.WriteLine(FindMax(1,2,10,15));
            Console.WriteLine(FindMax(1,10,15));
            Console.WriteLine(FindMax(10,15));

            Console.WriteLine(multiple(5, 10));
            Console.WriteLine(multiple(5));
            #endregion
        }
    }
}