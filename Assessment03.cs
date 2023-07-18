using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment03
{
    internal class Class1
    {
        public static void Q1()
        {
            Console.WriteLine("**************Enter The Books*************** ");
            string[] Books = new string[5];
            
            for(int i = 1; i <= Books.Length; i++)
            {
                Console.Write($"Enter Book Name {i} : ");
                Books[i-1] = Console.ReadLine();    // Insert book name in Array (string).
            }

            foreach(string Book in Books){
                Console.WriteLine(Book);            // Print the book names.
            }
        }

        // --------------------------------------------------------------------------------------------------------------------//


        public static void Q2()
        {   

            Console.Write("Enter The Number of Rows in Matrix : ");
            int rows = Convert.ToInt32(Console.ReadLine());             // Initialize the no. of Rows in matrix.
            Console.Write("Enter The Number of Columns in Matrix : ");
            int cols = Convert.ToInt32(Console.ReadLine());             // Initialize the no. of Columns in matrix.

            Console.WriteLine("Enter The First Matrix Element");
            int[,] matrix_1 = new int[rows,cols];

            for(int i=0; i<rows; i++)
            {
                for(int j=0; j < cols; j++)
                {
                    // Insert the element in matrix 1.
                    Console.Write($"Enter Element At Matrix_1 [{i},{j}] : ");
                    matrix_1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter The Second Matrix Element");
            int[,] matrix_2 = new int[rows,cols];

            for(int i=0; i<rows; i++)
            {
                for(int j=0; j < cols; j++)
                {
                    // Insert the element in matrix 2.
                    Console.Write($"Enter Element At Matrix_2 [{i},{j}] : ");
                    matrix_2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] matrix_sum = new int[rows,cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Sum of both matrixes element.
                    matrix_sum[i,j] = matrix_1[i,j] + matrix_2[i, j];
                }
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Print the sum_matrix's element.
                    Console.Write(matrix_sum[i, j]+" ");
                }
                Console.WriteLine();
            }
        }


        // --------------------------------------------------------------------------------------------------------------------//

        public static void Q3()
        {
            Console.Write("Enter the Row Size : ");
            int rows = Convert.ToInt32(Console.ReadLine());

            int[][] matrix_jagged = new int[rows][];
            int[] col_sizes = new int[rows];    // for save columns size for different-different rows.

            for(int i=0; i < rows; i++)
            {
                Console.Write($"Enter the Columns Size for {i+1} row : ");
                int col_size = Convert.ToInt32(Console.ReadLine());
                matrix_jagged[i] = new int[col_size];   // Initializes the column size for individuals rows.
                col_sizes[i] = col_size;
            }

            Console.WriteLine("************Enter the Matrix Elemnt************");

            for(int i = 0; i < rows; i++)
            {
                for(int j=0; j < col_sizes[i]; j++)
                {
                    //Insert element in an matrix.
                    Console.Write($"Matrix [{i},{j}] : ");
                    matrix_jagged[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            for(int i = 0; i < rows; i++)
            {
                for(int j=0; j < col_sizes[i]; j++)
                {
                    // Print the element of matrix
                    Console.Write(matrix_jagged[i][j]+" ");
                    
                }
                Console.WriteLine();
            }
        }


        // --------------------------------------------------------------------------------------------------------------------//

        static bool prime_check(int n)
        {
            if (n == 0 || n == 1) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void Q4()
        {
            Console.Write("Enter the number of element in an Array:- ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements");
            int[] arr = new int[n];

            for(int i=0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Prime Numbers : ");
            for(int i=0; i < n; i++)
            {
                // Element can pass to prime_check method for checking if return is true then print otherwise continue.
                if (prime_check(arr[i])) Console.Write(arr[i]+" ");
            }
        }
                                

        // --------------------------------------------------------------------------------------------------------------------//

        public static void Q5()
        {
            int n = 10;
            int[] arr_num = new int[n];
            Console.WriteLine("Enter The Numbers :- ");


            for(int i=0; i<n; i++)
            {
                arr_num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int largest_num = arr_num[0];   //Initialize the First element of array.
            int smallest_num = arr_num[0];
            int middle_num = arr_num[n / 2];

            for(int i=0; i<n; i++)
            {
                if (arr_num[i] > largest_num) largest_num = arr_num[i];
                if (arr_num[i] < smallest_num) smallest_num = arr_num[i];
            }

            Console.WriteLine($"Largest Number in array is : {largest_num}");
            Console.WriteLine($"Smallest Number in array is : {smallest_num}");
            Console.WriteLine($"Middle Number in array is : {middle_num}");
        }

        // --------------------------------------------------------------------------------------------------------------------//

        public static void Q6()
        {
            int n = 5;
            int[] arr_num = new int[n];
            Console.WriteLine("Enter The Numbers :- ");


            for (int i = 0; i < n; i++)
            {
                arr_num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array Elements in reverse order :- ");
            for (int i = n-1; i >= 0; i--)
            {
                // loop start from end to 0.
                 Console.Write(arr_num[i]+" ");
            }
        }

        // --------------------------------------------------------------------------------------------------------------------//


        static bool search_num(int[] arr_num,int num, int idx) {

            for(int i=idx+1; i<arr_num.Length; i++)
            {   // searched element in an array or not.
                if (arr_num[i] == num) return true;
            }
            return false;
        }
        public static void Q7()
        {
            int n = 10;         // Initialize the array size.
            int[] arr_num = new int[n];
            Console.WriteLine("Enter The Numbers :- ");

            for (int i = 0; i < n; i++)
            {    // Insert the element in an array.
                arr_num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] duplicate_num = new int[n];      // Initialize the array those can be store the duplicates element.
            int temp = 0;                       // Temporary variable for iterate the array [duplicates].

            for(int i=0; i < n; i++)
            {
                if(search_num(arr_num, arr_num[i], i))
                {
                    if(temp == 0) duplicate_num[temp++] = arr_num[i];      // First duplicate element store in duplicate array.
                         // next duplicates checking that element already present in duplicate array or not.
                    else if(!search_num(duplicate_num, arr_num[i], -1)) duplicate_num[temp++] = arr_num[i];
                }
            }

            for(int i = 0; i < temp; i++)
            {   // Print the Array.
                Console.Write(duplicate_num[i]+" ");
            }
        }


        // --------------------------------------------------------------------------------------------------------------------//


        static int search_num2(int[] arr_num, int num, int start, int end)
        {
            int count = 0;
            for (int i = start; i < end; i++)
            {   // searched element in an array or not.
                if (arr_num[i] == num) count++;
            }
            return count;
        }
        public static void Q8()
        {
            int n = 10;         // Initialize the array size.
            int[] arr_num = new int[n];
            Console.WriteLine("Enter The Numbers :- ");

            for (int i = 0; i < n; i++)
            {   // Insert the element in an array.
                arr_num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] unique_num = new int[n];     // Initialized for that contains uniques element.
            int size_unique_num = 0;           // counts the no. of unique element.
            // Insert the First element.
            unique_num[size_unique_num++] = arr_num[0];

            for (int i = 1; i < n; i++)
            {   // checked the element that present in unique_num or not. if not then insert in it.
                if(search_num2(unique_num, arr_num[i], 0, size_unique_num) == 0) unique_num[size_unique_num++] = arr_num[i];
            }
            
            int[] num_occurance = new int[size_unique_num]; // Initialized for stored occurance for unique element.

            for (int i = 0; i < size_unique_num; i++)
            {   // counting the unique element that present in arr_num.
                num_occurance[i] = search_num2(arr_num, unique_num[i], 0, arr_num.Length);
            }
            
            for (int i = 0; i < size_unique_num; i++)
            {   // Print the element with their occurance.
                Console.WriteLine($"Element : {unique_num[i]}, Occurance : {num_occurance[i]}");
            }
        }


        // --------------------------------------------------------------------------------------------------------------------//

        static void bubble_sorting(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {   // swappinf element if arr[j] is greater than arr[j+1].
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public static void Q9()
        {
            int n = 10;         // Initialize the array size.
            int[] arr_num = new int[n];
            Console.WriteLine("Enter The Numbers :- ");

            for (int i = 0; i < n; i++)
            {   // Insert the element in an array.
                arr_num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("BEFORE SORTING :- ");
            for (int i = 0; i < arr_num.Length; i++)
            {   // Print the Array.
                Console.Write(arr_num[i] + " ");
            }

            bubble_sorting(arr_num);

            Console.Write("AFTER SORTING :- ");
            for (int i = 0; i < arr_num.Length; i++)
            {   // Print the Array.
                Console.Write(arr_num[i] + " ");
            }
        }
        
        
        // --------------------------------------------------------------------------------------------------------------------//

        static int binary_search(int[] arr, int target)
        {
            bubble_sorting(arr);    // for sorting the array in asscending order.

            int left = 0, right = arr.Length - 1;

            while(left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target) return mid;

                if (arr[mid] < target) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
        public static void Q10()
        {
            int n = 10;         // Initialize the array size.
            int[] arr_num = new int[n];
            Console.WriteLine("Enter The Numbers :- ");

            for (int i = 0; i < n; i++)
            {   // Insert the element in an array.
                arr_num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the Number Do you want to searched :- ");
            int target = Convert.ToInt32((Console.ReadLine()));
                     // pass the arr with target element and return the index of target element otherwise -1.
            int idx = binary_search(arr_num, target);
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr_num[i] + " ");
            }
            Console.WriteLine();
            Console.Write($"{target} Element present at index {idx}");
 
        }
    }
}
