using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace ExpenseTrackerApp
{
    internal class Program
    {
        class Expense
        {
            static void Main(string[] args)
            {
               List<string> Title = new List<string>();
               List<string> Description = new List<string>();
               List<double> Amount = new List<double>();
               List<DateTime> Date = new List<DateTime>();
               List<string>types = new List<string>();
                while (true)
                {
                    Console.WriteLine("Welcome to Expense Tracker App");
                    Console.WriteLine("1.Add Transaction");
                    Console.WriteLine("2.View Transaction");
                    Console.WriteLine("3.View Income");
                    Console.WriteLine("4.Check Available Balance");
                    Console.WriteLine("Enter your choice");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("Enter Title");
                            string title = Console.ReadLine();
                            Console.WriteLine("Entre Description");
                            string description = Console.ReadLine();
                            Console.WriteLine("Enter amount");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Date(dd/mm/year)");
                            DateTime date = Convert.ToDateTime(Console.ReadLine());
                            string type = amount < 0 ? "Expense" : "Income";
                            Title.Add(title);
                            Description.Add(description);
                            Amount.Add(amount);
                            Date.Add(date);
                            types.Add(type);
                            Console.WriteLine("Transaction Added Successfully");
                            break;
                        case 2:
                            Console.WriteLine("Expense Transaction");
                            for (int i = 0; i < Title.Count; i++)
                            {
                                if (types[i] == "Expense")
                                {
                                    Console.WriteLine($"Title:{Title[i]}, Description:{Description[i]}, Amount:{Amount[i]}, Date:{Date[i]}");
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("Income Transactions:");
                            for (int i = 0; i < Title.Count; i++)
                            {
                                if (types[i] == "Income")
                                {
                                    Console.WriteLine($"Title:{Title[i]}, Description:{Description[i]}, Amount:{Amount[i]}, Date:{Date[i]}");
                                }
                            }
                            break;
                        case 4:
                            double balance = 0;
                            for (int i = 0; i < Amount.Count; i++)
                            {
                                balance = balance + Amount[i];
                            }
                            Console.WriteLine($"Available Balance:{balance}");
                            break;
                        default:
                            Console.WriteLine("Wrong Choice Entered!");
                            break;
                    }
                }   
            
            }
        }
    }
}