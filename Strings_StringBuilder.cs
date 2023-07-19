using System.Text;

namespace check_String
{

    class Strings_StringBuilder
    {
        public static void Main(String[] args)
        {
            // string is in root nameSpace (System).
            string str = "abcbdeaf";         // Type of string Declearation. 
            //  string str = "abc";   ------> Also as we write because string is alias of String.
            Console.WriteLine(str);


            Char[] ch = { 'b', 'c' };                 // 2 Type of string decleartion. but generally above type is more better than this.
            String str2 = new String(ch);
            Console.WriteLine(str2);

            // SOME OPERATION ON STRING :-

            //SUBSTRING
            // String str3 = str.Substring(index,length);
            string str3 = str.Substring(3, 2);
            Console.WriteLine(str3);

            //FIND INDEX
            // int ind = str.IndexOf(char or string);     
            int ind = str.IndexOf('d');
            Console.WriteLine(ind);

            int ind2 = str.IndexOf("ef");   // if char or string  not present in a given string then return is -1.
            Console.WriteLine(ind2);

            int ind3 = str.LastIndexOf('a');
            Console.WriteLine(ind3);

            //For check string start or end with that given char or not.

            //START
            bool b = str.StartsWith('a');
            Console.WriteLine(b);
            bool b1 = str.StartsWith("ab");
            Console.WriteLine(b1);

            //END
            bool b2 = str.EndsWith('a');
            Console.WriteLine(b2);
            bool b3 = str.EndsWith("af");
            Console.WriteLine(b3);

            //SPLIT
            string sentence = "This is Visual Studio 2022";     // for break the string according to specific condition.
            string[] s = sentence.Split(" ");                   // ex-> This string is break between " ".
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

            //Convert int Array
            foreach (char c in str.ToCharArray())
            {
                Console.WriteLine(c);
            }

            // For convert into upper or lower case
            string str_upper = str.ToUpper();
            Console.WriteLine(str_upper);

            string str_lower = sentence.ToLower();
            Console.WriteLine(str_lower);


            //--------------------------------------------------------------------------------------------------------------------------------//

            // StringBuilder is in (System.Text).
            StringBuilder strb1 = new StringBuilder("D");
            Console.WriteLine(strb1);

            //Append
            strb1.Append('e');  // for adding char or string
            strb1.Append('e');
            strb1.Append('p');
            strb1.Append('a');
            strb1.Append('k');
            strb1.Append(" Kumar");

            Console.WriteLine(strb1);

            //For append in starting or particular index.
            strb1.Insert(0, "This is ");
            Console.WriteLine(strb1);

            //For Relace
            strb1.Replace("Kumar", "Sharma");
            Console.WriteLine(strb1);

            //For Remove
            strb1.Remove(5, 11);
            Console.WriteLine(strb1);

            //For Clear
            strb1.Clear();
            Console.WriteLine(strb1);
        }

    }
}