using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write your Hello World application here
            String intro = " My name is Vamsi";
            string concatenated = String.Format("Hello {0}!", "Al");
            Console.WriteLine("Hello World!" + intro + " "+ concatenated);
            Console.ReadLine();
        }
    }
}