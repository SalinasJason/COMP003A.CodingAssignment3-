// Author: Jason Salinas
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Budget management application demonstrating control flow.
namespace COMP003A.CodingAssignment3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Budget Management Tool!");

            int choice;
            double income;

            Console.Write("\nEnter your monthly income: ");
            income = double.Parse(Console.ReadLine());

            List<string> expenseNames = new List<string>();
            List<double> expenseAmounts = new List<double>();
            double totalExpenses = 0;

            do
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Add an Expense");
                Console.WriteLine("2. View Expenses and Budget");
                Console.WriteLine("3. Remove an Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter you choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the expense name: ");
                        string expenseName = Console.ReadLine();

                        Console.Write("Enter the expense amount: ");
                        double expenseAmount = double.Parse(Console.ReadLine());

                        expenseNames.Add(expenseName);
                        expenseAmounts.Add(expenseAmount);
                        totalExpenses += expenseAmount;
                        Console.WriteLine("Expense added successfully.");
                        break;
                    case 2:
                        Console.WriteLine("\nExpenses:");
                        for (int i = 0; i < expenseNames.Count; i++)
                        {
                            Console.WriteLine($" - {expenseNames[i]}: ${expenseAmounts[i]:0.00}");
                        }
                        Console.WriteLine($"Total Expenses: ${totalExpenses:0.00}");
                        Console.WriteLine($"Remaining Budget: ${income - totalExpenses:0.00}");
                        break;
                    case 3:
                        Console.Write("Enter the name of the expense to remove: ");
                        string removeExpenseName = Console.ReadLine();
                        int removeExpense = expenseNames.IndexOf(removeExpenseName);

                        if (removeExpense >= 0)
                        {
                            totalExpenses -= expenseAmounts[removeExpense];
                            expenseNames.RemoveAt(removeExpense);
                            expenseAmounts.RemoveAt(removeExpense);
                            Console.WriteLine("Expense removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Expense not found.");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

                } while (choice != 4);
        }
    }
}
