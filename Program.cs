using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace first_assignment_grocery_app
{
    class Program
    {
        private static object grandtotal;

        static void Main(string[] args)
        {
            double a, b, c, d, e;
            double subtotal;
            string inputstring;

            Console.WriteLine("Please enter total frozen goods:");
            inputstring = Console.ReadLine();
            a = Convert.ToDouble(inputstring);

            Console.WriteLine("Please enter total for frozen packed goods:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your total for meats:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter total for produce");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter total for dairy:");
            e = Convert.ToDouble(Console.ReadLine());

            subtotal = a + b + c + d + e;
            Console.WriteLine("the total is " + subtotal + "!");


            writeline("this is a comment");


            grandtotal = (a + b + c + d + e) *.055 + a + b + c + d + e;
            Console.WriteLine("the Grandtotal is " + grandtotal + "!");
            Readkey();
             



             






        }

        private static void Writeline()
        {
            throw new NotImplementedException();
        }

        private static void Writeline(double total)
        {
            throw new NotImplementedException();
        }

        private static void Readkey()
        {
            throw new NotImplementedException();
        }

        private static string Readline()
        {
            throw new NotImplementedException();
        }

        private static void writeline(string v)
        {
            throw new NotImplementedException();
        }
    }
}
