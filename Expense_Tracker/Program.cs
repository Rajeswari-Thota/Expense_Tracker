namespace Expense_Tracker
{
    class Transaction
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Date { get; set; }
        

    }
  
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Transaction> transactions = new List<Transaction>();
            decimal balance = 0;

            while (true)
            {
                Console.WriteLine("Welcome TO Expense Tracker App");
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1. Add Transaction");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. View Income");
                Console.WriteLine("4. Check Available Balance");

                int choice=Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Transaction Details:");
                        Transaction t = new Transaction();
                        Console.WriteLine("Enter Title:");
                        t.Title = Console.ReadLine();
                        Console.WriteLine("Enter Description:");
                        t.Description = Console.ReadLine();
                        Console.WriteLine("Enter Amount:");
                        t.Amount = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter Date:");
                        t.Date = Console.ReadLine();
                        if(t.Amount > 0)
                        {
                            transactions.Add(t);
                            balance += t.Amount;
                        }
                        else
                        {
                            transactions.Add(t);
                            balance += t.Amount;
                        }
                        
                        break;

                    case 2:
                        Console.WriteLine("Expense Transactions:");
                        foreach (var transaction in transactions)
                        {
                            if (transaction.Amount < 0)
                            {
                                Console.WriteLine($"Title\tDescription\tAmount\tDate");
                                Console.WriteLine($"{transaction.Title}\t{transaction.Description}\t\t{transaction.Amount}\t{transaction.Date}");
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Income Transactions:");
                        foreach (var transaction in transactions)
                        {
                            if (transaction.Amount > 0)
                            {
                                Console.WriteLine($"Title\tDescription\tAmount\tDate");
                                Console.WriteLine($"{transaction.Title}\t{transaction.Description}\t\t{transaction.Amount}\t{transaction.Date}");
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine($"Available Balance: {balance}");
                            Console.WriteLine();
                        }
                        break;

                    default:
                        Console.WriteLine("Wrong Choice Entered");
                        break;
                }
            }
        }
    }
}








   