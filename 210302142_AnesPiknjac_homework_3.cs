using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace hw3calculator
{
    class Program
    {
        public static double addition(double x, double y)
        {
            return x + y;

        }
        public static double subtraction(double x, double y)
        {

            return x - y;


        }

        public static double multiplication(double x, double y)
        {

            return x * y;

        }
        public static double division(double x, double y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("division by zero not posible");
                return 0;
            }

        }
        public static double reminder(double x, double y)
        {
            return x % y;
        }
        public static double exponential(double x, double y)
        {
            double result = 1;
            for (int i = 0; i < y; i++)
            {
                result = result * x;
            }
            return result;
        }
        public static double squareRoot(double x)
        {
            return Math.Sqrt(x);
        }

        static void Main(string[] args)
        {
            bool state = true;
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            int n = 0;
            string operation = "+";
            List<double> list = new List<double>();
            Console.WriteLine("Key Triggers");
            Console.WriteLine("+   Sum operation");
            Console.WriteLine("-   Subtraction operation");
            Console.WriteLine("/   Division operation");
            Console.WriteLine("*   Multiplication operation");
            Console.WriteLine("%   Reminder operation");
            Console.WriteLine("^   Exponential operation");
            Console.WriteLine("s   Square root");
            Console.WriteLine("Input the first number, operation, second number then the equal sign");
            while (state == true)
            {
                bool state1 = true;
                bool state2 = true;
                bool state3 = true;
                bool state4 = true;
                //first number
                while (state1 == true)
                {
                    string a = Console.ReadLine();
                    if (a == "+" || a == "-" || a == "*" || a == "/" || a == "^" || a == "%")
                    {
                        operation = a;
                        num1 = Convert.ToDouble(result);
                        state1 = false;
                        state2 = false;
                    }
                    else if (a == "s")
                    {
                        operation = "s";
                        state2 = false;
                        state3 = false;
                        state1 = false;

                    }
                    else if (a == "q" || a == "Q")
                    {
                        return;
                    }
                    else if (a == "M")
                    {
                        list.Add(num1);
                    }
                    else if (a == "P")
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(list[i]);
                        }
                    }
                    Regex regex = new Regex(@"R(\d)");
                    Match match = regex.Match(a);
                    if (match.Success)
                    {
                        n = int.Parse(match.Groups[1].Value)-1;
                        if (n < 0 || n > list.Count)
                        {
                            Console.WriteLine("invalid input 1");
                        }
                        else
                        {
                            num1 = Convert.ToDouble(list[n]);
                            state1 = false;
                        }
                    }
                    else
                    {
                        try
                        {
                      
                            num1 = Convert.ToDouble(a);
                            state1 = false;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            Console.WriteLine("enter a number or operation");
                        }
                    }
                }
                //operation
                while (state2 == true)
                {
                    string o = Console.ReadLine();
                    if (o == "M")
                    {
                        list.Add(num1);
                    }
                    else if(o == "P")
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(list[i]);
                        }
                    }
                    Regex regex = new Regex(@"R(\d)");
                    Match match = regex.Match(o);
                    if (match.Success)
                    {
                        n = int.Parse(match.Groups[1].Value) - 1;
                        if (n < 0 || n > list.Count)
                        {
                            Console.WriteLine("invalid input 2");
                        }
                        else
                        {
                            num1 = Convert.ToDouble(list[n]);
                        
                        }
                    }
                    else if (o == "q" || o == "Q")
                    {
                        return;
                    }
                    else if (o == "+" || o == "-" || o == "*" || o == "/" || o == "^" || o == "%")
                    {
                        operation = o;
                        state2 = false;
                    }
                    else if (o == "s")
                    {
                        operation = "s";
                        state3 = false;
                        state2 = false;


                    }
                    else
                    {
                        Console.WriteLine("enter operation");
                    }

                }
                //second number
                while (state3 == true)
                {
                    string b = Console.ReadLine();
                    if (b == "q" || b == "Q")
                    {
                        return;
                    }
                    else if (b == "M")
                    {
                        list.Add(num1);
                    }
                    else if (b == "P")
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(list[i]);
                        }
                    }
                    Regex regex = new Regex(@"R(\d)");
                    Match match = regex.Match(b);
                    if (match.Success)
                    {
                        n = int.Parse(match.Groups[1].Value) - 1;
                        if (n < 0 || n > list.Count)
                        {
                            Console.WriteLine("invalid input 3");
                        }
                        else
                        {
                            num2 = Convert.ToDouble(list[n]);
                            state3= false;

                        }
                    }
                    else
                    {
                        try
                        {
                            
                            num2 = Convert.ToDouble(b);
                            state3 = false;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            Console.WriteLine("enter second number");
                        }
                    }


                }
                //equal sign
                while (state4 == true)
                {
                    string sign = Console.ReadLine();
                    if (sign == "q" || sign == "Q")
                    {
                        return;
                    }
                    else if (sign == "M")
                    {
                        list.Add(num2);
                    }
                    else if (sign == "P")
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(list[i]);
                        }
                    }
                    Regex regex = new Regex(@"R(\d)");
                    Match match = regex.Match(sign);
                    if (match.Success)
                    {
                        n = int.Parse(match.Groups[1].Value) - 1;
                        if (n < 0 || n > list.Count)
                        {
                            Console.WriteLine("invalid input 4");
                        }
                        else
                        {
                            num1 = Convert.ToDouble(list[n]);
                            state4 = false;

                        }
                    }
                    else if (sign != "=" && sign != "")
                    {
                        Console.WriteLine("enter equal sign or press enter");
                    }
                    else
                    {
                        if (operation == "+")
                        {
                            result = addition(num1, num2);
                            num1 = Convert.ToDouble(result);
                            Console.WriteLine(result);
                            state4 = false;
                        }
                        if (operation == "-")
                        {
                            result = subtraction(num1, num2);
                            num1 = Convert.ToDouble(result);
                            Console.WriteLine(result);
                            break;
                        }
                        if (operation == "*")
                        {
                            result = multiplication(num1, num2);
                            num1 = Convert.ToDouble(result);
                            Console.WriteLine(result);
                            break;
                        }
                        if (operation == "/")
                        {
                            result = division(num1, num2);
                            num1 = Convert.ToDouble(result);
                            Console.WriteLine(result);
                            break;
                        }
                        if (operation == "^")
                        {
                            result = exponential(num1, num2);
                            num1 = Convert.ToDouble(result);
                            Console.WriteLine(result);
                            break;

                        }
                        if (operation == "s")
                        {
                            result = squareRoot(num1);
                            num1 = Convert.ToDouble(result);
                            Console.WriteLine(result);
                            break;
                        }
                        if (operation == "%")
                        {
                            result = reminder(num1, num2);
                            num1 = Convert.ToDouble(result);
                            Console.WriteLine(result);
                            break;
                        }
                    }
                }
            }

        }
    }

}
