using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    public class MyCustomException : Exception
    {
        public MyCustomException(string message) : base(message) { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Exception[] exceptions = new Exception[5];
            exceptions[0] = new ArgumentNullException("Argument is null");
            exceptions[1] = new IndexOutOfRangeException("Index is out of range");
            exceptions[2] = new DivideByZeroException("Division by zero");
            exceptions[3] = new InvalidOperationException("Invalid operation");
            exceptions[4] = new MyCustomException("This is a custom exception");

            // Итерация по массиву исключений
            foreach (var ex in exceptions)
            {
                try
                {
                    throw ex; 
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine($"Caught ArgumentNullException: {e.Message}");
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine($"Caught IndexOutOfRangeException: {e.Message}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"Caught DivideByZeroException: {e.Message}");
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"Caught InvalidOperationException: {e.Message}");
                }
                catch (MyCustomException e)
                {
                    Console.WriteLine($"Caught MyCustomException: {e.Message}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Caught Exception: {e.Message}");
                }
                finally
                {
                    Console.WriteLine("Finally block executed.\n");
                    Console.ReadKey();
                }
            }
        }
    }

}

