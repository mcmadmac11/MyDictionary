using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class Display
     {
        string K;
        int V;
        public static Tuple<T1, T2> Create<T1, T2>(T1 Key, T2 Val)
        {
            return Display.Create(Key, Val);
        }



        public Tuple<string,int> lockBox(string K, int V)
        {

           K = "Dan";

           V = 123321;

            return lockBox(K,V);
        }


        public string DefUserName()
        {

            Console.WriteLine("Enter desired user name: ");
            string userNameIsSet = Console.ReadLine();
            string un = userNameIsSet;
            return un;

        }
        

    }
     
}
