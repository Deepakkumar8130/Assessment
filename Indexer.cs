namespace Indexer
{

    internal class Employee
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public int Id { set; get; }

        //Declearation of Indexer by 'this' keyword.

        // By the help of index:
        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Name;
                        break;
                    case 1:
                        return Email;
                        break;
                    case 2:
                        return Id;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                        break;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        this.Name = (string)value;
                        break;
                    case 1:
                        this.Email = (string)value;
                        break;
                    case 2:
                        this.Id = (int)value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                        break;
                }
            }
        }

        // By the help of key:
        public object this[string key]
        {
            get
            {
                switch (key.ToLower())
                {
                    case "name":
                        return Name;
                        break;
                    case "email":
                        return Email;
                        break;
                    case "id":
                        return Id;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                        break;
                }
            }
            set
            {
                switch (key.ToLower())
                {
                    case "name":
                        this.Name = (string)value;
                        break;
                    case "email":
                        this.Email = (string)value;
                        break;
                    case "id":
                        this.Id = (int)value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                        break;
                }
            }
        }
    }


    //----------------------------------------------------------------------------------------------------------------//
    class Indexer
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            //  This is General Basic Method we use for get and set of data.

            //SET:
            employee.Name = "Deepak Kumar";
            employee.Email = "deepak123@gmail.com";
            employee.Id = 1;
            //GET:
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Email);
            Console.WriteLine(employee.Id);

            //But by the help of Indexer technique we use property like an array.
            //It's not a actual array only it behave like this.

            Employee employee2 = new Employee();
            employee2[0] = "Tushar Kumar";                 // By value
            employee2["EmaiL"] = "tshrfser1235@gmail.com"; // By key
            employee2[2] = 2;

            Console.WriteLine(employee2[0]);
            Console.WriteLine(employee2[1]);
            Console.WriteLine(employee2["iD"]);             // By key

        }
    }
}
