namespace Oops_Inheritance
{

    #region Q1
    class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double CalculateArea()
        {
            return width * height;
        }
    }

    class Circle : Shape
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
    #endregion

    //---------------------------------------------------------------------------------------------------------------//
    #region Q2

    class Account
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; set; }

        public Account(int accountNumber, string accountHolderName, double initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }
        public virtual bool Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public virtual void DisplayAccountDetails()
        {
            Console.WriteLine($"Accout Number : {AccountNumber}");
            Console.WriteLine($"Accout Holder Name : {AccountHolderName}");
            Console.WriteLine($"Accout Balance : {Balance}");
        }
    }


    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int accountNumber, string accountHolderName, double initialBalance, double interestRate) : base(accountNumber, accountHolderName, initialBalance)
        {
            InterestRate = interestRate;
        }

        public override void DisplayAccountDetails()
        {
            base.DisplayAccountDetails();
            Console.WriteLine($"InterestRate : {InterestRate}");
        }
    }

    class CurrentAccount : Account
    {
        public double OverDriftLimit { get; set; }

        public CurrentAccount(int accountNumber, string accountHolderName, double initialBalance, double overdraftlimit) : base(accountNumber, accountHolderName, initialBalance)
        {
            OverDriftLimit = overdraftlimit;
        }

        public override bool Withdraw(double amount)
        {
            if (Balance + OverDriftLimit >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public override void DisplayAccountDetails()
        {
            base.DisplayAccountDetails();
            Console.WriteLine($"Overdraft Limit : {OverDriftLimit}");
        }
    }

    #endregion
    //---------------------------------------------------------------------------------------------------------------//

    #region Q3

    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a Sound.");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dogs barks");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    #endregion
    //---------------------------------------------------------------------------------------------------------------//

    #region Q4

    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make : {Make}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Year : {Year}");
        }
    }

    class Car : Vehicle
    {
        public int NumDoors { get; set; }
        public Car(string make, string model, int year, int numDoors) : base(make, model, year)
        {
            NumDoors = NumDoors;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Doors : {NumDoors}");
        }

        public void Honk()
        {
            Console.WriteLine("Car honks!");
        }
    }

    class MotorCycle : Vehicle
    {
        public string Type { get; set; }

        public MotorCycle(string make, string model, int year, string type) : base(make, model, year)
        {
            Type = type;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type : {Type}");
        }
        public void StartEngine()
        {
            Console.WriteLine("MotorCycle engine started!");
        }

    }

    #endregion
    //---------------------------------------------------------------------------------------------------------------//

    #region Q5

    class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int employeeID, double salary)
        {
            Name = name;
            EmployeeID = employeeID;
            Salary = salary;
        }

        public virtual double CalculateBonud()
        {
            return 0;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"EmployeeID : {EmployeeID}");
            Console.WriteLine($"Salary : {Salary:C}");
        }
    }

    class Manager : Employee
    {
        public Manager(string name, int EmployeeID, double salary) : base(name, EmployeeID, salary)
        {

        }
        public override double CalculateBonud()
        {
            return Salary * 0.10;
        }
    }
    class Developer : Employee
    {
        public Developer(string name, int EmployeeID, double salary) : base(name, EmployeeID, salary)
        {

        }
        public override double CalculateBonud()
        {
            return Salary * 0.05;
        }
    }

    #endregion
    //---------------------------------------------------------------------------------------------------------------//


    //---------------------------------------------------------------------------------------------------------------//
    class Inheritnace
    {
        public static void Main(string[] args)
        {
            //Q1
            /*Shape shape1 = new Rectangle(4, 5);
            Console.WriteLine("The area of rectangle is : " + shape1.CalculateArea());*/

            //Q2
           /* SavingsAccount account1 = new SavingsAccount(123456789, "Deepak Kumar", 5000, 6);

            bool status1 = account1.Withdraw(1000);
            if (status1) Console.WriteLine("Sucessfully");
            else Console.WriteLine("Not Proceed...Please Check Your Balance");
            account1.DisplayAccountDetails();

            CurrentAccount account2 = new CurrentAccount(750857458, "Tushar Kumar", 5000, 5000);
            bool status2 = account2.Withdraw(10001);
            if (status2) Console.WriteLine("Sucessfully");
            else Console.WriteLine("Not Proceed...Please Check Your Balance");
            account2.DisplayAccountDetails();*/


            //Q3
            /*Animal dog = new Dog();
            dog.MakeSound();

            Animal cat = new Cat();
            cat.MakeSound();*/

            //Q4
            /*Car car = new Car("Toyota", "Harrier", 2023, 4);
            car.DisplayInfo();
            car.Honk();

            Console.WriteLine();

            MotorCycle motorCycle = new MotorCycle("Harley Davidson", "Sportster", 2022, "Crusier");
            motorCycle.DisplayInfo();
            motorCycle.StartEngine();*/

            //Q5

            /*Manager manager = new Manager("Harsh Tyagi", 1256, 50000);
            manager.DisplayEmployeeDetails();
            Console.WriteLine($"Manager Bonus: {manager.CalculateBonud():C}");


            Developer developer = new Developer("Deepak Kumar", 1056, 100000);
            developer.DisplayEmployeeDetails();
            Console.WriteLine($"Manager Bonus: {developer.CalculateBonud():C}");*/


        }
    }
}