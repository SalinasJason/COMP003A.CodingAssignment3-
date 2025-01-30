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

            List<(string Name, double Amount)> expenses = new List<(string, double)>();

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

                        expenses.Add((expenseName, expenseAmount));
                        Console.WriteLine("Expense added successfully.");
                        break;
                    case 2:
                        Console.WriteLine("Expenses");
                        break;
                    case 3:
                        Console.WriteLine("Select an expense to remove");
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invail Input");
                        break;
                }

                } while (choice != 4);
        }
    }
}
