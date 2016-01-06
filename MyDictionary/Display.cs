using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
     public class Display
    {

        List <string> hashedUserName = new List<string>();

         public string DefUserName()
        {
            Console.WriteLine("Enter desired user name: ");
            string userNameIsSet = Console.ReadLine();

            return userNameIsSet;
            
        }


    }
}
