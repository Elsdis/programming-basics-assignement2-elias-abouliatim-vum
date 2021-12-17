using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        private static void Main(string[] args)
        {
            MainMenu();
        }
       public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome, what is your request?");
            Console.WriteLine("");
            Console.WriteLine("1.Number Comparison");
            Console.WriteLine("2.Factorial Calculator");
            Console.WriteLine("3.Exit");
            Console.WriteLine("");
            Console.WriteLine("Type 1, 2 or 3 to navigate.");
            string mychoice;
            mychoice = Console.ReadLine();
            switch(mychoice)
            {
                case "1":
                    Comp();
                    break;
                case "2":
                    Fact();
                    break;
                case "3":
                    Exit();
                    break;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            MainMenu();
        }
        public static void Comp()
        {
            Console.WriteLine("Please enter the first number");
            string val1 = Console.ReadLine();
            int int1;
            bool isParsable = Int32.TryParse(val1, out int1);
            while(isParsable == false)
            {
                Console.WriteLine("Please enter a valid integer");
                val1 = Console.ReadLine();
                isParsable = Int32.TryParse(val1, out int1);
            }
            Console.WriteLine("Please enter the 2nd number");
            string val2 = Console.ReadLine();
            int int2;
            isParsable = Int32.TryParse(val2, out int2);
            while(isParsable == false)
            {
                Console.WriteLine("Please enter a valid integer");
                val2 = Console.ReadLine();
                isParsable = Int32.TryParse(val2, out int2);
            }
            int biggestValue;
            if(int1>int2)
            {
                biggestValue = int1;
            }
            else
            {
                biggestValue = int2;
            }
            Console.WriteLine(biggestValue + "" + "is the biggest value");
        }
        public static int Facto(int n)
        {
            if (n == 0)
                return 1;
            return n * Facto(n - 1);
        }
        public static void Fact()
        {
            Console.WriteLine("Enter the factorial you want to calculate");
            string fac1 = Console.ReadLine();
            int fac;
            bool isParsable = Int32.TryParse(fac1, out fac);
            while (isParsable == false||fac<0)
            {
                Console.WriteLine("Please enter a valid positive integer");
                fac1 = Console.ReadLine();
                isParsable = Int32.TryParse(fac1, out fac);
            }
            int factr = Facto(fac);
            Console.WriteLine(fac + "!=" + factr);
        }
        public static void Exit()
        {
            Console.WriteLine("End the program?");
            Console.WriteLine("Press Enter to confirm");
            Console.ReadKey();
            System.Environment.Exit(1);
        }
    }
}
