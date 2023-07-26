namespace Oops_Constructor
{

    class Customer
    {
        public string Name { get; set; }   // PROPERETY
        public long Phone_no { get; set; }
        private int Password { get; set; }

        // default or Non-Parameterised Constructor.
        public Customer()
        {

        }

        // Parameterised Constructor.
        public Customer(string name, long phone_no, int password)
        {
            this.Name = name;
            this.Phone_no = phone_no;
            new Customer(password);
        }

        // Copy Constructor Approach.
        public Customer(Customer cc)
        {
            this.Name = cc.Name;
            this.Phone_no = cc.Phone_no;
            this.Password = cc.Password;
        }

        // Private Constructor 
        /* This constructor will use only in own Class but one hacked is possible
           due to Constructor chaining.
           Constructor chaining is to access private constructor with the help another public construcor
           only if that public constructor call to PRIVATE CONSTRUCTOR.

        */
        private Customer(int password)
        {
            this.Password = password;
            Console.WriteLine("This is the Private constructor");
            Console.WriteLine($"Password is {Password}");
        }

        // Static Constructor
        /* The static constructor run first of all constructor when object is created or calling any constructor.*/
        static Customer()
        {
            Console.WriteLine("This is static constructor");
        }
    }

    //-----------------------------------------------------------------------------------------------------------------------------------------------//
    class Constructor
    {
        static void Main(string[] args)
        {
            // Access default constructor.
            Customer customer1 = new Customer();
            customer1.Name = "Deepak Kumar";
            customer1.Phone_no = 8130157588;

            Console.WriteLine($"Customer1's Name : {customer1.Name}");
            Console.WriteLine($"Customer1's Phone No. : {customer1.Phone_no}");

            //------------------------------------------------------------------//

            // Access parameterised constructor.
            Customer customer2 = new Customer("Tushar Kumar", 750857687, 190801);
            Console.WriteLine($"Customer2's Name : {customer2.Name}");
            Console.WriteLine($"Customer2's Phone No. : {customer2.Phone_no}");
            /* Console.WriteLine($"Customer2's Password : {customer2.Password}");*/

            // Copy Constructor.
            // It is Scenario or approch to one constructor object data copy to another.

            Customer customer3 = new Customer(customer1);
            Console.WriteLine($"Customer3's Name : {customer3.Name}");
            Console.WriteLine($"Customer3's Phone No. : {customer3.Phone_no}");
        }
    }
}