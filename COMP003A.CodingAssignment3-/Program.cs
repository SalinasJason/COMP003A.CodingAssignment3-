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

            Console.Write("\nEnter your monthly income: ");
            double num = double.Parse(Console.ReadLine());

            int choice;

            do
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Add an Expense");
                Console.WriteLine("2. View Expenses and Budget");
                Console.WriteLine("3. Remove an Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter you choice: ");
                choice = int.Parse(Console.ReadLine());
            } while (choice != 4);
        }
    }
}
