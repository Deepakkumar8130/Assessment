namespace Oops_Polymorphism
{
    #region OVERLOADING
    class CalculateArea
    {
        public decimal Area(decimal length, decimal width)
        {
            return length * width;
        }
        // Polymorphism : same member with different arguments or datatype. this is overloading.
        /* This is Compile time polymorphism.*/
        public decimal Area(decimal length, decimal width, decimal height)
        {
            return length * width * height;
        }
        public double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
    #endregion

    //--------------------------------------------------------------------------------------------------//

    #region OVERRIDDING

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
            Console.WriteLine($"Accout Balance : {Balance:C}");
        }
    }


    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int accountNumber, string accountHolderName, double initialBalance, double interestRate) : base(accountNumber, accountHolderName, initialBalance)
        {
            InterestRate = interestRate;
        }
        /*This is Rum time Polymorphism.*/
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

    //--------------------------------------------------------------------------------------------------//
    class Polymorphism
    {
        public static void Main(string[] args)
        {
            /* CalculateArea rectangle = new CalculateArea();
             CalculateArea circle = new CalculateArea();

             CalculateArea cubic = new CalculateArea();

             Console.WriteLine(rectangle.Area(10, 10));

             Console.WriteLine(circle.Area(7));

             Console.WriteLine(cubic.Area(3,4,5));*/


            /*SavingsAccount account1 = new SavingsAccount(12469887, "Prince Sharma", 100000, 8);

            account1.Deposit(25000);
            account1.DisplayAccountDetails();*/



        }
    }
}