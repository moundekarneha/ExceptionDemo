using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first num: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter first num: ");
                int y = int.Parse(Console.ReadLine());

                //if y =1 then it will jump to end of this static main() method but in same case also it will execute finally block
                //- this is a speciality of finally block
                if(y==1)
                {
                    return;
                }

                int z = x / y;
                Console.WriteLine("\nResult = " + z);
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e.Message);
            }

            catch (FormatException e)
            {

                Console.WriteLine("Input must be numeric = " + e.Message);
            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block will execute in both cases whether the exception is occur or not");
            }

            Console.ReadLine();
        }
    }
}
