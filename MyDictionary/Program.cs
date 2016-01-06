using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDictionary;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Display disp = new Display();
            
            Console.WriteLine("Your User Name is: {0}", disp.DefUserName());
        }

    }
}
