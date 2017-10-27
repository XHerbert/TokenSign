using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                int b = 100 / a;
            }
            catch (Exception ex)
            {

                Console.WriteLine("抛错了");
                //return;
            }
            finally
            {
                Console.WriteLine("finally");
                Console.ReadLine();
            }
            Console.WriteLine("继续执行");
            Console.ReadLine();
        }
    }
}
