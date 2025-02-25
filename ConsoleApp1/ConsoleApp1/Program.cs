using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            Console.WriteLine("please input two numbers");
            string aString = Console.ReadLine();
            string bString= Console.ReadLine();
            a=Convert.ToDouble(aString);
            b=Convert.ToDouble(bString);
            Console.WriteLine("please input operator");
            string  myOperator=Console.ReadLine() ;
            if (myOperator.Length == 1) {
                switch (Convert.ToChar(myOperator))
                {
                    case '+':
                        double c = a + b;
                        Console.WriteLine(c);
                        break;
                    case '-':
                        double d = a - b;
                        Console.WriteLine(d);
                        break;
                    case '*':
                        double e = a * b;
                        Console.WriteLine(e);
                        break;
                    case '/':
                        if (b == 0)
                        {
                            Console.WriteLine("b should not be zero");
                            break;
                        }
                        double f = a / b;
                        Console.WriteLine(f);
                        break;
                    default: Console.WriteLine("not an operator");
                        break;

                }
            }
            Console.ReadLine(); 
        }
    }
}
