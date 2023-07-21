using System;
using System.Text;

namespace Assessment04
{
    class Assessment04
    {
        static void Q1()
        {
            Console.Write("Enter a String :- ");
            string s = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for(int i=0; i<s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z') sb.Append((char)(s[i]-32));
                else sb.Append(s[i]);
            }

            Console.Write($"String in Upper case :- {sb.ToString()}");
            Console.Write(s.ToUpper());
        }

        //------------------------------------------------------------------------------------------------------------------//

        static void Q2()
        {
            Console.Write("Enter The Name :- ");
            string name = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            string[] name_arr = name.Split(" ");

            for(int i=0; i< name_arr.Length; i++)
            {
                if(i == name_arr.Length-1) sb.Append(" "+name_arr[i]);
                else sb.Append(name_arr[i][0]+".");
            }
            Console.Write(sb.ToString());
        }

        //-------------------------------------------------------------------------------------------------------------------//

        static void Q3()
        {
            Console.Write("Enter The Mail Address :- ");
            string Email_org = Console.ReadLine();

            int Email_length = Email_org.Length;
            StringBuilder Email_mod = new StringBuilder();
            Email_mod.Append(Email_org.Substring(0,3));

            for(int  j=3; j<Email_length-10; j++)
            {
                Email_mod.Append("*");
            }
            Email_mod.Append(Email_org.Substring(Email_length-10));

            Console.Write(Email_mod.ToString());
        }

        //------------------------------------------------------------------------------------------------------------------//

        static bool search_word(string[] words, string word, int idx)
        {
            for(int i=idx+1; i<words.Length; i++)
            {
                if (words[i] == word) return true;
            }
            return false;
        }
        static void Q4()
        {
            Console.WriteLine("Enter a string :- ");
            string S = Console.ReadLine();

            string[] words = S.Split(" ");
            string[] duplicates_words = new string[S.Length/2];
            int temp = 0;
            
            for(int i=0;i< words.Length;i++)
            {
                if (search_word(words, words[i], i))
                {
                    if (temp == 0) duplicates_words[temp++] = words[i];
                    else if (!search_word(duplicates_words, words[i], -1)) duplicates_words[temp++] = words[i];
                }
            }

            for(int i=0; i<temp; i++)
            {
                Console.WriteLine(duplicates_words[i]);
            }
        }

        //------------------------------------------------------------------------------------------------------------------//

        static int search_word2(string[] words, string word, int start, int end)
        {
            int count = 0;
            for(int i=start; i<end; i++)
            {
                if (words[i] == word) count++;
            }
            return count;
        }
        static void Q5()
        {
            Console.WriteLine("Enter a string :- ");
            string S = Console.ReadLine();

            string[] words = S.Split(" ");
            string[] unique_words = new string[S.Length];
            int temp = 0;

            unique_words[temp++] = words[0];
            
            for(int i=1;i< words.Length;i++)
            {
                if (search_word2(unique_words, words[i],0,temp) == 0) unique_words[temp++] = words[i];
            }

            int[] occurance_word = new int[temp];
            for(int i=0; i<temp; i++)
            {
                occurance_word[i] = search_word2(words, unique_words[i],0,words.Length);
            }
            
            for(int i=0; i<temp; i++)
            {
                Console.WriteLine($"Word : {unique_words[i]}, Occurrance : {occurance_word[i]}");
            }
        }

        //-------------------------------------------------------------------------------------------------------------------//

        static int search_word3(string chars, char ch , int start, int end)
        {
            int count = 0;
            for (int i = start; i < end; i++)
            {
                if (chars[i] == ch) count++;
            }
            return count;
        }
        static void Q6()
        {
            Console.WriteLine("Enter a string :- ");
            string S = Console.ReadLine();

            StringBuilder unique_char = new StringBuilder();
            unique_char.Append(S[0]);

            for (int i = 1; i < S.Length; i++)
            {
                if (search_word3(unique_char.ToString(), S[i], 0, unique_char.Length) == 0) unique_char.Append(S[i]);
            }

            int[] occurance_char = new int[unique_char.Length];
            for (int i = 0; i < unique_char.Length; i++)
            {
                occurance_char[i] = search_word3(S, unique_char[i], 0, S.Length);
            }

            for (int i = 0; i < unique_char.Length; i++)
            {
                Console.WriteLine($"Character : {unique_char[i]}, Occurrance : {occurance_char[i]}");
            }
        }


        //-------------------------------------------------------------------------------------------------------------------//

        static void Q7()
        {
            Console.WriteLine("Enter a string :- ");
            string S = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for(int i=S.Length-1; i>=0; i--)
            {
                sb.Append(S[i]);
            }
            if(S.Equals(sb.ToString())) Console.WriteLine($"This is a Palindrome string : {sb.ToString()}");
            else Console.WriteLine($"This is not a Palindrome string : {sb.ToString()}");
        }
        
        
        //------------------------------------------------------------------------------------------------------------------//

        static void Q8()
        {
            Console.WriteLine("Enter a string :- ");
            string S = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for(int i=0;i< S.Length; i++)
            {
                if (S[i] >='a' && S[i] <= 'z' || S[i] >= 'A' && S[i] <= 'Z') sb.Append(S[i]);
            }

            Console.WriteLine(sb.ToString());
        }
        public static void Main(string[] args)
        {
           // Q1();
           // Q2();
           // Q3();
           // Q4();
           // Q5();
           // Q6();
           // Q7();
           // Q8();
        }
    }
}